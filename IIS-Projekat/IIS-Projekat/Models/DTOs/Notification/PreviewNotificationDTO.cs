namespace IIS_Projekat.Models.DTOs.Notification
{
    public class PreviewNotificationDTO
    {
        public long Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Content { get; set; }
        public bool isRead { get; set; }
    }
}
