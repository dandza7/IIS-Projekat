using FluentValidation;
using IIS_Projekat.Models.DTOs.User;

namespace IIS_Projekat.SupportClasses.Validators
{
    public class UpdateUsersRoleDTOValidator : AbstractValidator<UpdateUsersRoleDTO>
    {
        public UpdateUsersRoleDTOValidator()
        {
            RuleFor(u => u.Role).Must(role => Roles.Roles.IsRoleValid(role)).WithMessage($"Role must be one of following: {Roles.Roles.AvailableRoles}");
        }
    }
}
