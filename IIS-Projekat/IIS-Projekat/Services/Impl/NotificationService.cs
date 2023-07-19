using AutoMapper;
using IIS_Projekat.Models.DTOs.Notification;
using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Repositories;

namespace IIS_Projekat.Services.Impl
{
    public class NotificationService: INotificationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public NotificationService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public PaginationWrapper<PreviewNotificationDTO> GetUsersNotifications(PaginationQuery paginationQuery, string email)
        {
            throw new NotImplementedException();
        }
        public void DeleteNotificaiton(long notificationId)
        {
            throw new NotImplementedException();
        }
    }
}
