namespace IIS_Projekat.Models.DTOs.UsersProfile
{
    public class UpdateUsersProfileDTO
    {
        public long UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string Biography { get; set; }
    }
}
