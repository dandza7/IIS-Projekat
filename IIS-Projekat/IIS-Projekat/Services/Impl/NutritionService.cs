using AutoMapper;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.NutritionPlan;
using IIS_Projekat.Models.DTOs.Recipe;
using IIS_Projekat.Repositories;
using IIS_Projekat.SupportClasses.GlobalExceptionHandler.CustomExceptions;
using Microsoft.EntityFrameworkCore;

namespace IIS_Projekat.Services.Impl
{
    public class NutritionService : INutritionService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public NutritionService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void Update(NewNutritionPlanDTO newNutritionPlanDTO)
        {
            var nutritionPlan = _unitOfWork.NutritionPlanRepository.GetAll(np => np.Meals).Where(np => np.User.Id == newNutritionPlanDTO.UserId && np.Date == newNutritionPlanDTO.Date).FirstOrDefault();
            if (nutritionPlan == null)
            {
                throw new NotFoundException("Nutrition plan for sent user and date does not exist!");
            }
            var meals = _unitOfWork.MealRepository.GetAll().Where(m => m.NutritionPlan.Id == nutritionPlan.Id);
            foreach (var meal in meals)
            {
                nutritionPlan.Meals.Remove(meal);
            }
            AddMeals(newNutritionPlanDTO.Breakfasts, "BREAKFAST", nutritionPlan);
            AddMeals(newNutritionPlanDTO.Lunches, "LUNCH", nutritionPlan);
            AddMeals(newNutritionPlanDTO.Dinners, "DINNER", nutritionPlan);
            AddMeals(newNutritionPlanDTO.Snacks, "SNACK", nutritionPlan);
            _unitOfWork.SaveChanges();
        }

        private void AddMeals(List<NewMealDTO> newMeals, string type, NutritionPlan nutritionPlan)
        {
            foreach (var meal in newMeals)
            {
                var recipe = _unitOfWork.RecipeRepository.GetById(meal.RecipeId);
                if (recipe == null)
                {
                    throw new NotFoundException($"Recipe with sent id {meal.RecipeId} does not exist!");
                }
                _unitOfWork.MealRepository.Create(new Meal
                {
                    Type = type,
                    PortionSize = meal.PortionSize,
                    Recipe = recipe,
                    NutritionPlan = nutritionPlan
                });
            }
        }

        public ResponseNutritionPlanDTO GetOne(NutritionPlanKeyDTO nutritionPlanKeyDTO)
        {
            var nutritionPlan = _unitOfWork.NutritionPlanRepository.GetAll(np => np.User, np => np.Meals)
                                                                   .Where(np => np.UserId == nutritionPlanKeyDTO.UserId && np.Date == nutritionPlanKeyDTO.Date).FirstOrDefault();
            if (nutritionPlan == null)
            {
                var user = _unitOfWork.UserRepository.GetById(nutritionPlanKeyDTO.UserId);
                if (user == null)
                {
                    throw new NotFoundException($"User with sent id {nutritionPlanKeyDTO.UserId} does not exist!");
                }
                var newNutritionPlan = _unitOfWork.NutritionPlanRepository.Create(
                        new NutritionPlan
                        {
                            Date = nutritionPlanKeyDTO.Date,
                            User = user
                        }
                );
                _unitOfWork.SaveChanges();
                return new ResponseNutritionPlanDTO();
            }
            var response = new ResponseNutritionPlanDTO();
            foreach (var meal in nutritionPlan.Meals)
            {
                switch (meal.Type)
                {
                    case "BREAKFAST":
                        response.Breakfasts.Add(new PreviewMealDTO { PortionSize = meal.PortionSize, Recipe = GetDetailed(meal.RecipeId) });
                        break;
                    case "LUNCH":
                        response.Lunches.Add(new PreviewMealDTO { PortionSize = meal.PortionSize, Recipe = GetDetailed(meal.RecipeId) });
                        break;
                    case "DINNER":
                        response.Dinners.Add(new PreviewMealDTO { PortionSize = meal.PortionSize, Recipe = GetDetailed(meal.RecipeId) });
                        break;
                    case "SNACK":
                        response.Snacks.Add(new PreviewMealDTO { PortionSize = meal.PortionSize, Recipe = GetDetailed(meal.RecipeId) });
                        break;
                }
            }
            return response;
        }

        public IEnumerable<PreviewNutritionPlanDTO> GetNutritionPlans()
        {
            return _mapper.Map<List<PreviewNutritionPlanDTO>>(_unitOfWork.NutritionPlanRepository.GetAll(np => np.User).Where(np => np.Date > DateTime.UtcNow && !np.IsOrdered).ToList());
        }

        public PreviewNutritionPlanContentDTO GetNutritionPlanWithIngredients(long id)
        {
            var plan = _unitOfWork.NutritionPlanRepository.GetAll(np => np.User).Where(np => np.Id == id)
                                                                                .Include(np => np.Meals)
                                                                                .ThenInclude(m => m.Recipe)
                                                                                .ThenInclude(r => r.FoodShares)
                                                                                .ThenInclude(fs => fs.Food).FirstOrDefault();
            if (plan == null)
            {
                throw new NotFoundException($"Nutrition plan with id {id} does not exist!");
            }
            var response = new PreviewNutritionPlanContentDTO
            {
                Details = _mapper.Map<PreviewNutritionPlanDTO>(plan)
            };
            foreach (var meal in plan.Meals)
            {
                foreach (var foodShare in meal.Recipe.FoodShares)
                {
                    if (!response.Ingredients.Where(i => i.Name == foodShare.Food.Name).Any())
                    {
                        response.Ingredients.Add(
                            new PreviewIngredientDTO
                            {
                                Name = foodShare.Food.Name
                            }
                        );
                    }
                    foreach (var ingredient in response.Ingredients)
                    {
                        if (ingredient.Name == foodShare.Food.Name)
                        {
                            ingredient.Amount += foodShare.Share * meal.PortionSize;
                        }
                    }
                }
            }
            return response;
        }

        private PreviewRecipeDetailedDTO GetDetailed(long id)
        {
            var recipe = _unitOfWork.RecipeRepository.GetById(id, r => r.FoodShares);
            if (recipe == null)
            {
                throw new NotFoundException($"Recipe with ID {id} does not exist!");
            }
            var recipeDTO = _mapper.Map<PreviewRecipeDetailedDTO>(recipe);
            foreach (var shareId in recipe.FoodShares.Select(fs => fs.Id))
            {
                IncreaseNutrients(shareId, recipeDTO);
            }
            return recipeDTO;
        }

        private void IncreaseNutrients(long foodShareId, PreviewRecipeDetailedDTO recipe)
        {
            var foodShare = _unitOfWork.FoodShareRepository.GetById(foodShareId, fs => fs.Food);
            var food = _unitOfWork.FoodRepository.GetById(foodShare.Food.Id, f => f.NutrientShares);
            recipe.Calories += foodShare.Share * food.Calories;
            recipe.Ingredients.Add(
                new PreviewIngredientDTO
                {
                    Name = food.Name,
                    Amount = foodShare.Share
                }
            );
            if (!recipe.Categories.Contains(food.Category))
            {
                recipe.Categories.Add(food.Category);
            }
            foreach (var share in food.NutrientShares)
            {
                var nutrientShare = _unitOfWork.NutrientShareRepository.GetById(share.Id, ns => ns.Nutrient);
                switch (nutrientShare.Nutrient.Name)
                {
                    case "Protein":
                        recipe.NutrientTable.Protein += share.Share * foodShare.Share;
                        break;
                    case "Fat":
                        recipe.NutrientTable.Fat += share.Share * foodShare.Share;
                        break;
                    case "Carbohydrates":
                        recipe.NutrientTable.Carbohydrates += share.Share * foodShare.Share;
                        break;
                    case "Fiber":
                        recipe.NutrientTable.Fiber += share.Share * foodShare.Share;
                        break;
                    case "Sugar":
                        recipe.NutrientTable.Sugar += share.Share * foodShare.Share;
                        break;
                    case "Vitamin A":
                        recipe.NutrientTable.VitaminA += share.Share * foodShare.Share;
                        break;
                    case "Vitamin B1":
                        recipe.NutrientTable.VitaminB1 += share.Share * foodShare.Share;
                        break;
                    case "Vitamin B2":
                        recipe.NutrientTable.VitaminB2 += share.Share * foodShare.Share;
                        break;
                    case "Vitamin B3":
                        recipe.NutrientTable.VitaminB3 += share.Share * foodShare.Share;
                        break;
                    case "Vitamin C":
                        recipe.NutrientTable.VitaminC += share.Share * foodShare.Share;
                        break;
                    case "Vitamin D":
                        recipe.NutrientTable.VitaminD += share.Share * foodShare.Share;
                        break;
                    case "Vitamin E":
                        recipe.NutrientTable.VitaminE += share.Share * foodShare.Share;
                        break;
                    case "Calcium":
                        recipe.NutrientTable.Calcium += share.Share * foodShare.Share;
                        break;
                    case "Iron":
                        recipe.NutrientTable.Iron += share.Share * foodShare.Share;
                        break;
                    case "Magnesium":
                        recipe.NutrientTable.Magnesium += share.Share * foodShare.Share;
                        break;
                    case "Potassium":
                        recipe.NutrientTable.Potassium += share.Share * foodShare.Share;
                        break;
                    case "Sodium":
                        recipe.NutrientTable.Sodium += share.Share * foodShare.Share;
                        break;
                    case "Zinc":
                        recipe.NutrientTable.Zinc += share.Share * foodShare.Share;
                        break;
                }
            }
        }
    }
}
