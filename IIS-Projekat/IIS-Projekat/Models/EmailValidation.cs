namespace IIS_Projekat.Models
{

    public class EmailValidation : IEntity
    {
        public long Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public long Code { get; set; }
        public User User { get; set; } 
        public long UserId { get; set; }
    }
}
