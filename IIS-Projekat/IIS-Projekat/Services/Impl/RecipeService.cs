using AutoMapper;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Models.DTOs.Recipe;
using IIS_Projekat.Repositories;
using IIS_Projekat.SupportClasses.GlobalExceptionHandler.CustomExceptions;
using Microsoft.EntityFrameworkCore;

namespace IIS_Projekat.Services.Impl
{
    public class RecipeService : IRecipeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public RecipeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public long Create(NewRecipeDTO newRecipeDTO)
        {
            if (_unitOfWork.RecipeRepository.GetAll().Where(r => r.Name == newRecipeDTO.Name).Any())
            {
                throw new DuplicateItemException("Recipe with sent name already exists");
            }
            var newRecipe = _mapper.Map<Recipe>(newRecipeDTO);
            AddIngredientsToRecipe(newRecipe, newRecipeDTO.Ingredients);
            _unitOfWork.RecipeRepository.Create(newRecipe);
            _unitOfWork.SaveChanges();
            return newRecipe.Id;
        }
        private void AddIngredientsToRecipe(Recipe recipe, ICollection<NewIngredientDTO> ingredients)
        {
            foreach (var ingredient in ingredients)
            {
                var food = _unitOfWork.FoodRepository.GetById(ingredient.FoodId);
                if (food == null)
                {
                    throw new NotFoundException($"Food with ID {ingredient.FoodId} is does not exist!");
                }
                _unitOfWork.FoodShareRepository.Create(
                new FoodShare
                {
                    Share = ingredient.Amount,
                    Recipe = recipe,
                    Food = food
                });
            }
        }

        public PaginationWrapper<PreviewRecipeDTO> GetAll(PaginationQuery paginationQuery)
        {
            var paginationResult = _unitOfWork.RecipeRepository.Filter(paginationQuery);
            return new PaginationWrapper<PreviewRecipeDTO>(_mapper.Map<List<PreviewRecipeDTO>>(paginationResult.Items), paginationResult.TotalCount);
        }

        public PaginationWrapper<PreviewRecipeDTO> GetSuitableRecipes(long id, int page)
        {
            var user = _unitOfWork.UserRepository.GetAll().Where(u => u.Id == id).Include(u => u.MedicalRecord).Include(u => u.MedicalRecord.Allergies).FirstOrDefault();
            if (user == null)
            {
                throw new NotFoundException($"User with id {id} does not exist!");
            }
            var allergies = user.MedicalRecord.Allergies;
            var recipes = _unitOfWork.RecipeRepository.GetAll().Include(r => r.FoodShares).ThenInclude(fs => fs.Food).ThenInclude(f => f.Allergies).ToList();
            var suitableRecipes = new List<Recipe>();
            foreach (var recipe in recipes)
            {
                var isSutiable = true;
                foreach (var share in recipe.FoodShares)
                {
                    foreach (var allergy in share.Food.Allergies)
                    {
                        if (allergies.Contains(allergy))
                        {
                            isSutiable = false;
                            break;
                        }
                    }
                    if (!isSutiable)
                    {
                        break;
                    }
                }
                if (isSutiable)
                {
                    suitableRecipes.Add(recipe);
                }
            }
            var count = suitableRecipes.Count();
            return new PaginationWrapper<PreviewRecipeDTO>(_mapper.Map<List<PreviewRecipeDTO>>(suitableRecipes.Skip((page - 1) * 10).Take(10)), count);
        }

        public PaginationWrapper<PreviewRecipeDetailedDTO> GetAllDetailed(PaginationQuery paginationQuery)
        {
            var paginationResult = _unitOfWork.RecipeRepository.Filter(paginationQuery);
            var detailedList = new List<PreviewRecipeDetailedDTO>();
            foreach (var recipe in paginationResult.Items)
            {
                detailedList.Add(GetDetailed(recipe.Id));
            }
            return new PaginationWrapper<PreviewRecipeDetailedDTO>(detailedList, paginationResult.TotalCount);
        }

        public PreviewRecipeDetailedDTO GetDetailed(long id)
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
