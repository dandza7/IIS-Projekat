using IIS_Projekat.Models;

namespace IIS_Projekat.Repositories
{
    public interface IUnitOfWork
    {
        IGenericRepository<User> UserRepository { get; }
        IGenericRepository<TrainingPlanRequest> TrainingPlanRequestRepository { get; }
        IGenericRepository<Exercise> ExerciseRepository { get; }
        IGenericRepository<MuscleGroup> MuscleGroupRepository { get; }
        IGenericRepository<ExerciseMuscleGroup> ExerciseMuscleGroupRepository { get; }
        IGenericRepository<Diagnosis> DiagnosisRepository { get; }
        IGenericRepository<Nutrition> NutritionRepository { get; }
        IGenericRepository<Allergy> AllergyRepository { get; }
        IGenericRepository<Food> FoodRepository { get; }
        IGenericRepository<NutritionShare> NutritionShareRepository { get; }
        IGenericRepository<Recipe> RecipeRepository { get; }
        IGenericRepository<FoodShare> FoodShareRepository { get; }
        IGenericRepository<Injury> InjuryRepository { get; }
        IGenericRepository<MedicalRecord> MedicalRecordRepository { get; }
        IGenericRepository<Appointment> AppointmentRepository { get; }
        IGenericRepository<Report> ReportRepository { get; }


        void SaveChanges();
    }
}
