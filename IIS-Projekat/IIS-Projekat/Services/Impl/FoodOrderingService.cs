using AutoMapper;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.FoodSupplying;
using IIS_Projekat.Models.DTOs.Pagination;
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
            var plansIds = new List<long>();
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
                plansIds.Add(plan.Id);
                _unitOfWork.NutritionPlanRepository.Update(plan);
            }
            foreach (var order in orders)
            {
                _unitOfWork.FoodOrderRepository.Create(order);
                report.FoodOrders.Add(order);
            }
            _unitOfWork.SaveChanges();
            return CreateReport(report.Id, plansIds);
        }

        public PaginationWrapper<FoodSupplyingReportDTO> GetAll(int page)
        {
            var allReportsIds = _unitOfWork.FoodSupplyReportRepository.GetAll().Select(fsr => fsr.Id);
            var count = allReportsIds.Count();
            var reportsIds = allReportsIds.Skip((page - 1) * 10).Take(10).ToList();
            var responseList = new List<FoodSupplyingReportDTO>();
            foreach (var id in reportsIds)
            {
                responseList.Add(CreateReport(id));
            }
            return new PaginationWrapper<FoodSupplyingReportDTO>(responseList, count);
        }

        public DateTime UpdateOrdersStatus(OrderConfirmationDTO orderConfirmationDTO)
        {
            var report = _unitOfWork.FoodSupplyReportRepository.GetById(orderConfirmationDTO.Id);
            if (report == null)
            {
                throw new NotFoundException($"Order report with id {orderConfirmationDTO.Id} does not exist!");
            }
            if (orderConfirmationDTO.ToConfirm)
            {
                report.IsConfirmed = true;
                foreach (var id in orderConfirmationDTO.PlansIds)
                {
                    var plan = _unitOfWork.NutritionPlanRepository.GetById(id);
                    if (plan == null)
                    {
                        throw new NotFoundException($"Nutrition plan with id {id} does not exist!");
                    }
                    plan.IsOrdered = true;
                }
                _unitOfWork.SaveChanges();
                return report.DeliveryDate;
            }
            else
            {
                _unitOfWork.FoodSupplyReportRepository.Delete(report);
                _unitOfWork.SaveChanges();
                return DateTime.Now;
            }
        }

        private FoodSupplyingReportDTO CreateReport(long id, List<long> plansIds = null)
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
                ReportId = report.Id,
                DeliveryDate = report.DeliveryDate,
                TotalPrice = 0,
                PlansIds = plansIds
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
