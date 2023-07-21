using IIS_Projekat.Models.DTOs.Notification;
using IIS_Projekat.Models.DTOs.Pagination;

namespace IIS_Projekat.Services
{
    public interface INotificationService
    {
        public long CreateNotification(NewNotificationDTO newNotificationDTO);
        public PaginationWrapper<PreviewNotificationDTO> GetUsersNotifications(PaginationQuery paginationQuery, string email);
        public int GetUnreadNotificationsCount(string email);
        public void DeleteNotification(long notificationId);
    }
}

