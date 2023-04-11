using FluentValidation;
using IIS_Projekat.Models.DTOs.UsersProfile;

namespace IIS_Projekat.SupportClasses.Validators
{
    public class UpdateOwnProfileDTOValidator : AbstractValidator<UpdateOwnProfileDTO>
    {
        public UpdateOwnProfileDTOValidator()
        {
            RuleFor(p => p.Gender).Must(gender => gender == "Male" || gender == "Female").WithMessage("Gender must be either Male or Female");
        }
    }
}
