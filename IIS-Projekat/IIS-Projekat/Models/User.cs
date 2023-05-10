using System.ComponentModel.DataAnnotations.Schema;

namespace IIS_Projekat.Models
{
    public class User : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public byte[] Salt { get; set; }
        public string Role { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; } = false;
        public virtual UsersProfile Profile { get; set; }
        public virtual MedicalRecord MedicalRecord { get; set; }
    }
}
