namespace IIS_Projekat.Models
{
    public interface IEntity
    {
        long Id { get; set; }
        DateTime CreatedDate { get; set; }
        DateTime ModifiedDate { get; set; }
        bool IsDeleted { get; set; }
    }
}
