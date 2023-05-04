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
        void SaveChanges();
    }
}
