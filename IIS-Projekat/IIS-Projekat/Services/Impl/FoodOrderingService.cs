using AutoMapper;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.FoodSupplying;
using IIS_Projekat.Repositories;
using IIS_Projekat.SupportClasses.GlobalExceptionHandler.CustomExceptions;
using Microsoft.EntityFrameworkCore;

namespace IIS_Projekat.Services.Impl
{
    public class FoodOrderingService : IFoodOrderingService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public FoodOrderingService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public FoodSupplyingReportDTO CreateOrder(NewFoodOrderDTO newFoodOrderDTO)
        {
            var report = _unitOfWork.FoodSupplyReportRepository.Create(new FoodSupplyReport
            {
                DeliveryDate = DateTime.Now.AddDays(new Random().Next(1, 4))
            });
            var orders = new List<FoodOrder>();
            foreach (var id in newFoodOrderDTO.NutritionPlansIds)
            {
                var plan = _unitOfWork.NutritionPlanRepository.GetAll(np => np.User).Where(np => np.Id == id)
                                                                                .Include(np => np.Meals)
                                                                                .ThenInclude(m => m.Recipe)
                                                                                .ThenInclude(r => r.FoodShares)
                                                                                .ThenInclude(fs => fs.Food).FirstOrDefault();
                if (plan == null)
                {
                    throw new NotFoundException($"Nutrition plan with sent {id} does not exist!");
                }
                foreach (var meal in plan.Meals)
                {
                    foreach (var foodShare in meal.Recipe.FoodShares)
                    {
                        if (!orders.Where(fo => fo.FoodPrice.Food.Name == foodShare.Food.Name).Any())
                        {
                            var foodPrices = _unitOfWork.FoodPriceRepository.GetAll(fp => fp.Food).Where(fp => fp.Food.Name == foodShare.Food.Name).ToList();
                            if (!foodPrices.Any())
                            {
                                throw new NotFoundException($"Food {foodShare.Food.Name} does not have price set!");
                            }
                            var foodPrice = foodPrices.Where(fp => fp.Price == foodPrices.Min(fp => fp.Price)).First();
                            orders.Add(
                                new FoodOrder
                                {
                                    Amount = 0,
                                    FoodPrice = foodPrice
                                }
                            );
                        }
                        foreach (var order in orders)
                        {
                            if (order.FoodPrice.Food.Name == foodShare.Food.Name)
                            {
                                order.Amount += foodShare.Share * meal.PortionSize;
                            }
                        }
                    }
                }
            }
            foreach (var order in orders)
            {
                _unitOfWork.FoodOrderRepository.Create(order);
                report.FoodOrders.Add(order);
            }
            _unitOfWork.SaveChanges();
            return CreateReport(report.Id);
        }
        private FoodSupplyingReportDTO CreateReport(long id)
        {
            var report = _unitOfWork.FoodSupplyReportRepository.GetAll().Where(fsr => fsr.Id == id)
                                                                        .Include(fsr => fsr.FoodOrders)
                                                                        .ThenInclude(fo => fo.FoodPrice)
                                                                        .ThenInclude(fp => fp.Food).FirstOrDefault();
            if (report == null)
            {
                throw new NotFoundException($"Report with id {id} does not exist!");
            }
            var response = new FoodSupplyingReportDTO
            {
                DeliveryDate = report.DeliveryDate,
                TotalPrice = 0
            };
            foreach (var foodOrder in report.FoodOrders)
            {
                response.FoodOrders.Add(_mapper.Map<PreviewFoodOrderDTO>(foodOrder));
                response.TotalPrice += foodOrder.Amount * foodOrder.FoodPrice.Price;
            }
            return response;
        }
    }

}
