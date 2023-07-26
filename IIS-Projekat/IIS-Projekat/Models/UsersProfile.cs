using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IIS_Projekat.Models
{
    public class UsersProfile : IEntity
    {
        public UsersProfile() { }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public byte[] Avatar { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public long UserId { get; set; }
        public virtual User User { get; set; }
        public bool IsEmailSubscribed { get; set; } = false;
        public ICollection<Notification> UsersNotifications { get; set; } = new List<Notification>();
        [MaxLength(800)]
        public string Biography { get; set; } = string.Empty;
    }
}
