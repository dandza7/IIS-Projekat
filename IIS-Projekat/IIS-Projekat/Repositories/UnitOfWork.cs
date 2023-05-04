using IIS_Projekat.Models;
using Microsoft.EntityFrameworkCore;

namespace IIS_Projekat.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private IGenericRepository<User> _userRepository;
        private IGenericRepository<UsersProfile> _profileRepository;
        private IGenericRepository<TrainingPlanRequest> _trainingPlanRequestRepository;
        private IGenericRepository<Exercise> _exerciseRepository;
        private IGenericRepository<MuscleGroup> _muscleGroupRepository;
        private IGenericRepository<ExerciseMuscleGroup> _exerciseMuscleGroupRepository;

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

        public IGenericRepository<Exercise> ExerciseRepository
        {
            get
            {
                _exerciseRepository ??= new GenericRepository<Exercise>(_dbContext);
                return _exerciseRepository;
            }
        }

        public IGenericRepository<MuscleGroup> MuscleGroupRepository
        {
            get
            {
                _muscleGroupRepository ??= new GenericRepository<MuscleGroup>(_dbContext);
                return _muscleGroupRepository;
            }
        }
        
        public IGenericRepository<ExerciseMuscleGroup> ExerciseMuscleGroupRepository
        {
            get
            {
                _exerciseMuscleGroupRepository ??= new GenericRepository<ExerciseMuscleGroup>(_dbContext);
                return _exerciseMuscleGroupRepository;
            }
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
