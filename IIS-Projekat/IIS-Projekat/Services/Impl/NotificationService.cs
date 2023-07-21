using AutoMapper;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.Notification;
using IIS_Projekat.Models.DTOs.Pagination;
using IIS_Projekat.Repositories;
using IIS_Projekat.SupportClasses.GlobalExceptionHandler.CustomExceptions;

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

        public long CreateNotification(NewNotificationDTO newNotificationDTO)
        {
            var user = _unitOfWork.UserRepository.GetAll().Where(u => u.Email == newNotificationDTO.RecieverEmail).FirstOrDefault();
            if (user == null)
            {
                throw new NotFoundException($"User with given email does not exist.");
            }
            var usersProfile = _unitOfWork.ProfileRepository.GetAll().Where(p => p.UserId == user.Id).FirstOrDefault();
            if (usersProfile == null)
            {
                throw new NotFoundException($"User does not have a profile.");
            }
            var notification = new Notification();
            notification.Reciever = usersProfile;
            notification.Content = newNotificationDTO.Content;
            notification = _unitOfWork.NotificationRepository.Create(notification);
            return notification.Id;
        }

        public PaginationWrapper<PreviewNotificationDTO> GetUsersNotifications(PaginationQuery paginationQuery, string email)
        {
            var user = _unitOfWork.UserRepository.GetAll().Where(u => u.Email == email).ToList().FirstOrDefault();
            if (user == null)
            {
                throw new NotFoundException($"User with given email does not exist.");
            }
            var usersProfile = _unitOfWork.ProfileRepository.GetAll().Where(p => p.UserId == user.Id).ToList().FirstOrDefault();
            if (usersProfile == null)
            {
                throw new NotFoundException($"User does not have a profile.");
            }
            var notifications = _unitOfWork.NotificationRepository.GetAll(n => n.Reciever).Where(n => n.Reciever == usersProfile).ToList();
            notifications.ForEach(n => n.IsRead = true);
            _unitOfWork.SaveChanges();
            return new PaginationWrapper<PreviewNotificationDTO>(_mapper.Map<List<PreviewNotificationDTO>>(notifications), notifications.Count);
        }

        public int GetUnreadNotificationsCount(string email)
        {
            var user = _unitOfWork.UserRepository.GetAll().Where(u => u.Email == email).ToList().FirstOrDefault();
            if (user == null)
            {
                throw new NotFoundException($"User with given email does not exist.");
            }
            var usersProfile = _unitOfWork.ProfileRepository.GetAll().Where(p => p.UserId == user.Id).ToList().FirstOrDefault();
            if (usersProfile == null)
            {
                throw new NotFoundException($"User does not have a profile.");
            }
            var notifications = _unitOfWork.NotificationRepository.GetAll(n => n.Reciever).Where(n => n.Reciever == usersProfile).ToList();
            int unreadCount = 0;
            foreach(var notification in notifications)
            {
                if(notification.IsRead == false) { unreadCount++; }
            }
            return unreadCount;
        }

        public void DeleteNotification(long notificationId)
        {
            var notification = _unitOfWork.NotificationRepository.GetById(notificationId);
            if(notification == null)
            {
                throw new NotFoundException($"Notification does not exist.");
            }
            _unitOfWork.NotificationRepository.Delete(notification);
            _unitOfWork.SaveChanges();
        }
    }
}
