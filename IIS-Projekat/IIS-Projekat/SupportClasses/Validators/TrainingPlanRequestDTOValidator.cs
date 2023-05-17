using System;
using FluentValidation;
using IIS_Projekat.Models.DTOs.Training.Request;

namespace IIS_Projekat.SupportClasses.Validators
{
    public class TrainingPlanRequestDTOValidator : AbstractValidator<TrainingPlanRequestDTO>
    {
        public TrainingPlanRequestDTOValidator()
        {
            RuleFor(tpr => tpr.SessionsPerWeek).Must(num => num > 1 && num < 7).WithMessage("Number of sessions per week must be between 2 and 6, inclusive.");
            RuleFor(tpr => tpr.TrainingGoal).Must(goal => Goal.Goal.IsGoalValid(goal)).WithMessage($"Training goal is not valid! Valid goals are {Goal.Goal.ValidGoals}");
        }
    }
}
