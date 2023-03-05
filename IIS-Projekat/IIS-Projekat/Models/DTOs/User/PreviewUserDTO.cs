namespace IIS_Projekat.Models.DTOs.User
{
    public class PreviewUserDTO
    {
        public long Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;

        public PreviewUserDTO(long id, string email, string role)
        {
            Id = id;
            Email = email;
            Role = role;
        }
    }
}
