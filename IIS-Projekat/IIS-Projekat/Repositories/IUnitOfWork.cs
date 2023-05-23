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
        IGenericRepository<Nutrient> NutrientRepository { get; }
        IGenericRepository<Allergy> AllergyRepository { get; }
        IGenericRepository<Food> FoodRepository { get; }
        IGenericRepository<NutrientShare> NutrientShareRepository { get; }
        IGenericRepository<Recipe> RecipeRepository { get; }
        IGenericRepository<FoodShare> FoodShareRepository { get; }
        IGenericRepository<Injury> InjuryRepository { get; }
        IGenericRepository<MedicalRecord> MedicalRecordRepository { get; }
        IGenericRepository<Appointment> AppointmentRepository { get; }
        IGenericRepository<TrainingPlan> TrainingPlanRepository { get; }
        IGenericRepository<TrainingSession> TrainingSessionRepository { get; }
        IGenericRepository<ExerciseTrainingSession> ExerciseTrainingSessionRepository { get; }
        IGenericRepository<InjuryMedicalRecord> InjuryMedicalRecordRepository { get; }
        IGenericRepository<UsersProfile> ProfileRepository { get; }
        IGenericRepository<Therapy> TherapyRepository { get; }
        IGenericRepository<Meal> MealRepository { get; }
        IGenericRepository<NutritionPlan> NutritionPlanRepository { get; }
        IGenericRepository<FoodOrder> FoodOrderRepository { get; }
        IGenericRepository<FoodPrice> FoodPriceRepository { get; }
        IGenericRepository<FoodSupplyReport> FoodSupplyReportRepository { get; }
        void SaveChanges();
    }
}
