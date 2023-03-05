using FluentValidation;
using IIS_Projekat.Models.DTOs.User;

namespace IIS_Projekat.SupportClasses.Validators
{
    public class UserCredentialsDTOValidator : AbstractValidator<UserCredentialsDTO>
    {
        public UserCredentialsDTOValidator()
        {
            RuleFor(u => u.Email).NotEmpty().EmailAddress();
        }
    }
}
