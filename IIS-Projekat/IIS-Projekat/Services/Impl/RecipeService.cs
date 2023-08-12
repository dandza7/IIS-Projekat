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

        public PaginationWrapper<PreviewRecipeDTO> GetSuitableRecipes(long patientId, PaginationQuery paginationQuery)
        {
            var recipes = RemoveUnsuitableRecipes(patientId);
            var recipeDTOs = _mapper.Map<List<PreviewRecipeDTO>>(recipes);
            return PaginationWrapper<PreviewRecipeDTO>.WrapItems(_mapper, paginationQuery, recipeDTOs);
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

        public PaginationWrapper<PreviewRecipeDetailedDTO> GetSuitableRecipesDetailed(long patientId, PaginationQuery paginationQuery)
        {
            var recipes = RemoveUnsuitableRecipes(patientId);
            var detailedList = new List<PreviewRecipeDetailedDTO>();
            foreach (var recipe in recipes)
            {
                detailedList.Add(GetDetailed(recipe.Id));
            }
            return PaginationWrapper<PreviewRecipeDetailedDTO>.WrapItems(_mapper, paginationQuery, detailedList);
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

        private List<Recipe> RemoveUnsuitableRecipes(long patientId)
        {
            var recipes = _unitOfWork.RecipeRepository.GetAll()
                .Include(r => r.FoodShares)
                    .ThenInclude(fs => fs.Food)
                    .ThenInclude(f => f.Allergies)
                .Include(r => r.FoodShares)
                    .ThenInclude(fs => fs.Food)
                    .ThenInclude(f => f.Diagnoses)
                .ToList();
            var medicalRecord = _unitOfWork.MedicalRecordRepository
                .GetAll(mr => mr.Diagnoses, mr => mr.Allergies).Where(mr => mr.PatientId == patientId).FirstOrDefault();
            if (medicalRecord == null)
            {
                throw new NotFoundException($"Patient with id: {patientId} does not have a medical record.");
            }
            foreach (var recipe in recipes)
            {
                foreach (var foodShares in recipe.FoodShares)
                {
                    bool isAllergic = false, isInadvisable = false;
                    foreach (var allergy in medicalRecord.Allergies)
                    {
                        if (foodShares.Food.Allergies.Contains(allergy)) isAllergic = true;
                    }
                    foreach (var diagnosis in medicalRecord.Diagnoses)
                    {
                        if (foodShares.Food.Diagnoses.Contains(diagnosis)) isInadvisable = true;
                    }
                    if (isAllergic || isInadvisable) recipes.Remove(recipe);
                }
            }
            return recipes;
        }
    }
}
