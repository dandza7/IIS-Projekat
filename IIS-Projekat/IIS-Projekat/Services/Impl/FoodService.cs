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
            CreateNutrientShare("Protein", newFood, nutrientTableDTO.Protein, "g");
            CreateNutrientShare("Fat", newFood, nutrientTableDTO.Fat, "g");
            CreateNutrientShare("Carbohydrates", newFood, nutrientTableDTO.Carbohydrates, "g");
            CreateNutrientShare("Fiber", newFood, nutrientTableDTO.Fiber, "g");
            CreateNutrientShare("Sugar", newFood, nutrientTableDTO.Sugar, "g");
            CreateNutrientShare("Vitamin A", newFood, nutrientTableDTO.VitaminA, "UI");
            CreateNutrientShare("Vitamin B1", newFood, nutrientTableDTO.VitaminB1, "mg");
            CreateNutrientShare("Vitamin B2", newFood, nutrientTableDTO.VitaminB2, "mg");
            CreateNutrientShare("Vitamin B3", newFood, nutrientTableDTO.VitaminB3, "mg");
            CreateNutrientShare("Vitamin C", newFood, nutrientTableDTO.VitaminC, "mg");
            CreateNutrientShare("Vitamin D", newFood, nutrientTableDTO.VitaminD, "mg");
            CreateNutrientShare("Vitamin E", newFood, nutrientTableDTO.VitaminE, "UI");
            CreateNutrientShare("Calcium", newFood, nutrientTableDTO.Calcium, "mg");
            CreateNutrientShare("Iron", newFood, nutrientTableDTO.Iron, "mg");
            CreateNutrientShare("Magnesium", newFood, nutrientTableDTO.Magnesium, "mg");
            CreateNutrientShare("Potassium", newFood, nutrientTableDTO.Potassium, "mg");
            CreateNutrientShare("Sodium", newFood, nutrientTableDTO.Sodium, "mg");
            CreateNutrientShare("Zinc", newFood, nutrientTableDTO.Zinc, "mg");
        }

        private void CreateNutrientShare(string nutrientName, Food newFood, int share, string unit)
        {
            _unitOfWork.NutrientShareRepository.Create(
                    new NutrientShare
                    {
                        Share = share,
                        Unit = unit,
                        Nutrient = _unitOfWork.NutrientRepository.GetAll().Where(n => n.Name == nutrientName).FirstOrDefault(),
                        Food = newFood
                    }
                );
        }
    }
}
