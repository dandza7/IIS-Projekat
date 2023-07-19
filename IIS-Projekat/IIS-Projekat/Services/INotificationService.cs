using IIS_Projekat.Models.DTOs.Notification;
using IIS_Projekat.Models.DTOs.Pagination;

namespace IIS_Projekat.Services
{
    public interface INotificationService
    {
        public PaginationWrapper<PreviewNotificationDTO> GetUsersNotifications(PaginationQuery paginationQuery, string email);
        public void DeleteNotificaiton(long notificationId);
    }
}
