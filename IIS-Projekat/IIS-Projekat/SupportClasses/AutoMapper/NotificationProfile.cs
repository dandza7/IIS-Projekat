using AutoMapper;
using IIS_Projekat.Models;
using IIS_Projekat.Models.DTOs.Notification;

namespace IIS_Projekat.SupportClasses.AutoMapper
{
    public class NotificationProfile: Profile
    {
        public NotificationProfile()
        {
            CreateMap<Notification, PreviewNotificationDTO>();
        }
    }
}
