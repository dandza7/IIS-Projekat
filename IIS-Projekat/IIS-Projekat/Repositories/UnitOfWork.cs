using IIS_Projekat.Models;
using Microsoft.EntityFrameworkCore;

namespace IIS_Projekat.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private IGenericRepository<User> _userRepository;
        private IGenericRepository<UsersProfile> _profileRepository;
        private IGenericRepository<TrainingPlanRequest> _trainingPlanRequestRepository;
        private DbContext _dbContext;

        public UnitOfWork(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IGenericRepository<User> UserRepository
        {
            get
            {
                _userRepository ??= new GenericRepository<User>(_dbContext);
                return _userRepository;
            }
        }

        public IGenericRepository<UsersProfile> ProfileRepository
        {
            get
            {
                _profileRepository ??= new GenericRepository<UsersProfile>(_dbContext);
                return _profileRepository;
            }
        }

        public IGenericRepository<TrainingPlanRequest> TrainingPlanRequestRepository
        {
            get
            {
                _trainingPlanRequestRepository ??= new GenericRepository<TrainingPlanRequest>(_dbContext);
                return _trainingPlanRequestRepository;
            }
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
