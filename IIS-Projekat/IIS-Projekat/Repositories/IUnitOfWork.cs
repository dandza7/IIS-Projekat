using IIS_Projekat.Models;

namespace IIS_Projekat.Repositories
{
    public interface IUnitOfWork
    {
        IGenericRepository<User> UserRepository { get; }
        IGenericRepository<TrainingPlanRequest> TrainingPlanRequestRepository { get; }
        void SaveChanges();
    }
}
