using FluentValidation;
using IIS_Projekat.Models.DTOs.User;
using IIS_Projekat.Services;

namespace IIS_Projekat.SupportClasses.Validators
{
    public class NewUserDTOValidator : AbstractValidator<NewUserDTO>
    {
        private readonly IUserService _userService;
        public NewUserDTOValidator(IUserService userService)
        {
            _userService = userService;
            RuleFor(u => u.Email).NotEmpty().EmailAddress();
            RuleFor(u => u.Email).Must(email => _userService.IsEmailAvailable(email)).WithMessage("Email is already taken!");
            RuleFor(user => user.Password).NotEmpty().WithMessage("Password is required!")
                .NotNull().WithMessage("Password is required!")
                .Matches("[A-Z]").WithMessage("'{PropertyName}' must contain one or more capital letters!")
                .Matches("[a-z]").WithMessage("'{PropertyName}' must contain one or more lowercase letters!")
                .Matches(@"\d").WithMessage("'{PropertyName}' must contain one or more digits!")
                .Matches(@"[][""!@$%^&*(){}:;<>,.?/+_=|'~\\-]").WithMessage("'{PropertyName}' must contain one or more special characters!")
                .Matches("^[^£# “”]*$").WithMessage("'{PropertyName}' must not contain the following characters £ # “” or spaces!")
                .Length(8, 16).WithMessage("Password should be between 8 and 16 characters!");
        }
    }
}
