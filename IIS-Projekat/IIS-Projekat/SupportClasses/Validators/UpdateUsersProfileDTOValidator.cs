using FluentValidation;
using IIS_Projekat.Models.DTOs.UsersProfile;

namespace IIS_Projekat.SupportClasses.Validators
{
    public class UpdateUsersProfileDTOValidator : AbstractValidator<UpdateUsersProfileDTO>
    {
        public UpdateUsersProfileDTOValidator()
        {
            RuleFor(p => p.UserId).NotNull();
            RuleFor(p => p.Gender).Must(gender => gender == "Male" || gender == "Female").WithMessage("Gender must be either Male or Female");
        }
    }
}
