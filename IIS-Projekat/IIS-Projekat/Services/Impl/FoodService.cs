using AutoMapper;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.Food;
using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Repositories;
using IIS_Projekat.SupportClasses.GlobalExceptionHandler.CustomExceptions;

namespace IIS_Projekat.Services.Impl
{
    public class FoodService : IFoodService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public FoodService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public long Create(NewFoodDTO newFoodDTO)
        {
            if (_unitOfWork.FoodRepository.GetAll().Where(f => f.Name == newFoodDTO.Name).Any())
            {
                throw new DuplicateItemException($"Food with Name {newFoodDTO.Name} already exists!");
            }
            var newFood = _mapper.Map<Food>(newFoodDTO);
            newFood = _unitOfWork.FoodRepository.Create(newFood);
            AddAllergiesToFood(newFoodDTO.AllergyIds, newFood);
            AddNutrientsToFood(newFoodDTO.NutrientTable, newFood);
            _unitOfWork.SaveChanges();
            return newFood.Id;
        }

        public PaginationWrapper<PreviewFoodDTO> GetAll(PaginationQuery paginationQuery)
        {
            var paginationResult = _unitOfWork.FoodRepository.Filter(paginationQuery, f => f.Allergies);
            var result = new PaginationWrapper<PreviewFoodDTO>(_mapper.Map<List<PreviewFoodDTO>>(paginationResult.Items), paginationResult.TotalCount);
            foreach (var item in result.Items)
            {
                AddNutrientTable(item);
            }
            return result;
        }

        private void AddNutrientTable(PreviewFoodDTO previewFoodDTO)
        {
            var nutrientShares = _unitOfWork.NutrientShareRepository.GetAll(ns => ns.Nutrient).Where(fs => fs.Food.Id == previewFoodDTO.Id).ToList();
            foreach (var share in nutrientShares)
            {
                var nutrient = _unitOfWork.NutrientRepository.GetById(share.Nutrient.Id);
                switch (nutrient.Name)
                {
                    case "Protein":
                        previewFoodDTO.NutrientTable.Protein = share.Share;
                        break;
                    case "Fat":
                        previewFoodDTO.NutrientTable.Fat = share.Share;
                        break;
                    case "Carbohydrates":
                        previewFoodDTO.NutrientTable.Carbohydrates = share.Share;
                        break;
                    case "Fiber":
                        previewFoodDTO.NutrientTable.Fiber = share.Share;
                        break;
                    case "Sugar":
                        previewFoodDTO.NutrientTable.Sugar = share.Share;
                        break;
                    case "Vitamin A":
                        previewFoodDTO.NutrientTable.VitaminA = share.Share;
                        break;
                    case "Vitamin B1":
                        previewFoodDTO.NutrientTable.VitaminB1 = share.Share;
                        break;
                    case "Vitamin B2":
                        previewFoodDTO.NutrientTable.VitaminB2 = share.Share;
                        break;
                    case "Vitamin B3":
                        previewFoodDTO.NutrientTable.VitaminB3 = share.Share;
                        break;
                    case "Vitamin C":
                        previewFoodDTO.NutrientTable.VitaminC = share.Share;
                        break;
                    case "Vitamin D":
                        previewFoodDTO.NutrientTable.VitaminD = share.Share;
                        break;
                    case "Vitamin E":
                        previewFoodDTO.NutrientTable.VitaminE = share.Share;
                        break;
                    case "Calcium":
                        previewFoodDTO.NutrientTable.Calcium = share.Share;
                        break;
                    case "Iron":
                        previewFoodDTO.NutrientTable.Iron = share.Share;
                        break;
                    case "Magnesium":
                        previewFoodDTO.NutrientTable.Magnesium = share.Share;
                        break;
                    case "Potassium":
                        previewFoodDTO.NutrientTable.Potassium = share.Share;
                        break;
                    case "Sodium":
                        previewFoodDTO.NutrientTable.Sodium = share.Share;
                        break;
                    case "Zinc":
                        previewFoodDTO.NutrientTable.Zinc = share.Share;
                        break;
                }
            }
        }

        private void AddAllergiesToFood(List<int> allergyIds, Food newFood)
        {
            foreach (var allergyId in allergyIds)
            {
                var allergy = _unitOfWork.AllergyRepository.GetAll().Where(a => a.Id == allergyId).FirstOrDefault();
                if (allergy == null)
                {
                    throw new NotFoundException($"Allergy with ID {allergyId} is not found!");
                }
                newFood.Allergies.Add(allergy);
            }
        }

        private void AddNutrientsToFood(NutrientTableDTO nutrientTableDTO, Food newFood)
        {
            CreateNutrientShare("Protein", newFood, nutrientTableDTO.Protein);
            CreateNutrientShare("Fat", newFood, nutrientTableDTO.Fat);
            CreateNutrientShare("Carbohydrates", newFood, nutrientTableDTO.Carbohydrates);
            CreateNutrientShare("Fiber", newFood, nutrientTableDTO.Fiber);
            CreateNutrientShare("Sugar", newFood, nutrientTableDTO.Sugar);
            CreateNutrientShare("Vitamin A", newFood, nutrientTableDTO.VitaminA);
            CreateNutrientShare("Vitamin B1", newFood, nutrientTableDTO.VitaminB1);
            CreateNutrientShare("Vitamin B2", newFood, nutrientTableDTO.VitaminB2);
            CreateNutrientShare("Vitamin B3", newFood, nutrientTableDTO.VitaminB3);
            CreateNutrientShare("Vitamin C", newFood, nutrientTableDTO.VitaminC);
            CreateNutrientShare("Vitamin D", newFood, nutrientTableDTO.VitaminD);
            CreateNutrientShare("Vitamin E", newFood, nutrientTableDTO.VitaminE);
            CreateNutrientShare("Calcium", newFood, nutrientTableDTO.Calcium);
            CreateNutrientShare("Iron", newFood, nutrientTableDTO.Iron);
            CreateNutrientShare("Magnesium", newFood, nutrientTableDTO.Magnesium);
            CreateNutrientShare("Potassium", newFood, nutrientTableDTO.Potassium);
            CreateNutrientShare("Sodium", newFood, nutrientTableDTO.Sodium);
            CreateNutrientShare("Zinc", newFood, nutrientTableDTO.Zinc);
        }

        private void CreateNutrientShare(string nutrientName, Food newFood, int share)
        {
            _unitOfWork.NutrientShareRepository.Create(
                    new NutrientShare
                    {
                        Share = share,
                        Nutrient = _unitOfWork.NutrientRepository.GetAll().Where(n => n.Name == nutrientName).FirstOrDefault(),
                        Food = newFood
                    }
                );
        }

        public void Delete(long id)
        {
            var food = _unitOfWork.FoodRepository.GetById(id);
            if (food == null)
            {
                throw new NotFoundException($"Food with ID {id} is not found!");
            }
            _unitOfWork.FoodRepository.Delete(food);
            _unitOfWork.SaveChanges();
        }
    }
}
