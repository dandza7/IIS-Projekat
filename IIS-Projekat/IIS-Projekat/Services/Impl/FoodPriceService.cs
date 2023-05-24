using AutoMapper;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.FoodPrice;
using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Repositories;
using IIS_Projekat.SupportClasses.GlobalExceptionHandler.CustomExceptions;

namespace IIS_Projekat.Services.Impl
{
    public class FoodPriceService : IFoodPriceService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public FoodPriceService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public long CreateOrUpdate(NewFoodPriceDTO newFoodPriceDTO)
        {
            var foodPrice = _unitOfWork.FoodPriceRepository.GetAll().Where(fp => fp.FoodId == newFoodPriceDTO.FoodId && fp.Supplier == newFoodPriceDTO.Supplier).FirstOrDefault();
            if (foodPrice == null)
            {
                var food = _unitOfWork.FoodRepository.GetById(newFoodPriceDTO.FoodId);
                if (food == null)
                {
                    throw new NotFoundException($"Food with sent id {newFoodPriceDTO.FoodId} does not exist!");
                }
                var newFoodPrice = _unitOfWork.FoodPriceRepository.Create(
                    new FoodPrice
                    {
                        Food = food,
                        Price = newFoodPriceDTO.Price,
                        Supplier = newFoodPriceDTO.Supplier
                    }
                );
                _unitOfWork.SaveChanges();
                return newFoodPrice.Id;
            }
            else
            {
                foodPrice.Price = newFoodPriceDTO.Price;
                _unitOfWork.FoodPriceRepository.Update(foodPrice);
                _unitOfWork.SaveChanges();
                return foodPrice.Id;
            }
        }

        public PaginationWrapper<PreviewFoodPricesDTO> GetAll(int page)
        {
            var food = _unitOfWork.FoodRepository.GetAll();
            var count = food.Count();
            var foodPrices = _mapper.Map<List<PreviewFoodPricesDTO>>(food.Skip((page - 1) * 10).Take(10));
            foreach (var f in foodPrices)
            {
                var prices = _unitOfWork.FoodPriceRepository.GetAll().Where(fp => fp.FoodId == f.FoodId).ToList();
                f.FoodPrices = _mapper.Map<List<PreviewFoodPriceDTO>>(prices);
            }
            return new PaginationWrapper<PreviewFoodPricesDTO>(foodPrices, count);
        }
        public void Delete(long id)
        {
            var foodPrice = _unitOfWork.FoodPriceRepository.GetById(id);
            if (foodPrice == null)
            {
                throw new NotFoundException($"Food price with sent id {id} does not exist!");
            }
            _unitOfWork.FoodPriceRepository.Delete(foodPrice);
            _unitOfWork.SaveChanges();
        }
    }
}
