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
        private IGenericRepository<Diagnosis> _diagnosisRepository;
        private IGenericRepository<Nutrient> _nutrientRepository;
        private IGenericRepository<Allergy> _allergyRepository;
        private IGenericRepository<Food> _foodRepository;
        private IGenericRepository<NutrientShare> _nutrientShareRepository;
        private IGenericRepository<Recipe> _recipeRepository;
        private IGenericRepository<FoodShare> _foodShareRepository;
        private IGenericRepository<Injury> _injuryRepository;
        private IGenericRepository<MedicalRecord> _medicalRecordRepository;
        private IGenericRepository<Appointment> _appointmentRepository;
        private IGenericRepository<Report> _reportRepository;
        private IGenericRepository<TrainingPlan> _trainingPlanRepository;
        private IGenericRepository<TrainingSession> _trainingSessionRepository;
        private IGenericRepository<ExerciseTrainingSession> _exerciseTrainingSessionRepository;

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

        public IGenericRepository<Diagnosis> DiagnosisRepository
        {
            get
            {
                _diagnosisRepository ??= new GenericRepository<Diagnosis>(_dbContext);
                return _diagnosisRepository;
            }
        }

        public IGenericRepository<Nutrient> NutrientRepository
        {
            get
            {
                _nutrientRepository ??= new GenericRepository<Nutrient>(_dbContext);
                return _nutrientRepository;
            }
        }

        public IGenericRepository<Allergy> AllergyRepository
        {
            get
            {
                _allergyRepository ??= new GenericRepository<Allergy>(_dbContext);
                return _allergyRepository;
            }
        }

        public IGenericRepository<Food> FoodRepository
        {
            get
            {
                _foodRepository ??= new GenericRepository<Food>(_dbContext);
                return _foodRepository;
            }
        }

        public IGenericRepository<NutrientShare> NutrientShareRepository
        {
            get
            {
                _nutrientShareRepository ??= new GenericRepository<NutrientShare>(_dbContext);
                return _nutrientShareRepository;
            }
        }

        public IGenericRepository<Recipe> RecipeRepository
        {
            get
            {
                _recipeRepository ??= new GenericRepository<Recipe>(_dbContext);
                return _recipeRepository;
            }
        }

        public IGenericRepository<FoodShare> FoodShareRepository
        {
            get
            {
                _foodShareRepository ??= new GenericRepository<FoodShare>(_dbContext);
                return _foodShareRepository;
            }
        }

        public IGenericRepository<Injury> InjuryRepository
        {
            get
            {
                _injuryRepository ??= new GenericRepository<Injury>(_dbContext);
                return _injuryRepository;
            }
        }

        public IGenericRepository<MedicalRecord> MedicalRecordRepository
        {
            get
            {
                _medicalRecordRepository ??= new GenericRepository<MedicalRecord>(_dbContext);
                return _medicalRecordRepository;
            }
        }

        public IGenericRepository<Appointment> AppointmentRepository
        {
            get
            {
                _appointmentRepository ??= new GenericRepository<Appointment>(_dbContext);
                return _appointmentRepository;
            }
        }

        public IGenericRepository<Report> ReportRepository
        {
            get
            {
                _reportRepository ??= new GenericRepository<Report>(_dbContext);
                return _reportRepository;
            }
        }

        public IGenericRepository<TrainingPlan> TrainingPlanRepository
        {
            get
            {
                _trainingPlanRepository ??= new GenericRepository<TrainingPlan>(_dbContext);
                return _trainingPlanRepository;
            }
        }

        public IGenericRepository<TrainingSession> TrainingSessionRepository
        {
            get
            {
                _trainingSessionRepository ??= new GenericRepository<TrainingSession>(_dbContext);
                return _trainingSessionRepository;
            }
        }

        public IGenericRepository<ExerciseTrainingSession> ExerciseTrainingSessionRepository
        {
            get
            {
                _exerciseTrainingSessionRepository ??= new GenericRepository<ExerciseTrainingSession>(_dbContext);
                return _exerciseTrainingSessionRepository;
            }
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
