namespace IIS_Projekat.Models.DTOs.UsersProfile
{
    public class PreviewUsersProfileDTO
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string Role { get; set; }
    }
}
