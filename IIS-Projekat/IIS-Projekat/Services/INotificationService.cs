using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.Notification;
using IIS_Projekat.Models.DTOs.Pagination;

namespace IIS_Projekat.Services
{
    public interface INotificationService
    {
        public long CreateNotification(NewNotificationDTO newNotificationDTO);
        public PaginationWrapper<PreviewNotificationDTO> GetUsersNotifications(PaginationQuery paginationQuery, string email);
        public long MarkNotificationAsRead(long notificationId);
        public int GetUnreadNotificationsCount(string email);
        Task<bool> SendAsync(MailData mailData, CancellationToken ct);
        public void DeleteNotifications(ICollection<long> notificationIds);
    }
}

