﻿using IIS_Projekat.Models;
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
        private IGenericRepository<MedicalRecord> _medicalRecordRepository;
        private IGenericRepository<Appointment> _appointmentRepository;
        private IGenericRepository<TrainingPlan> _trainingPlanRepository;
        private IGenericRepository<TrainingSession> _trainingSessionRepository;
        private IGenericRepository<ExerciseTrainingSession> _exerciseTrainingSessionRepository;
        private IGenericRepository<Injury> _injuryMedicalRecordRepository;
        private IGenericRepository<Therapy> _therapyRepository;
        private IGenericRepository<Meal> _mealRepository;
        private IGenericRepository<NutritionPlan> _nutritionPlanRepository;
        private IGenericRepository<FoodSupplyReport> _foodSupplyReportRepository;
        private IGenericRepository<FoodPrice> _foodPriceRepository;
        private IGenericRepository<FoodOrder> _foodOrderRepository;
        private IGenericRepository<Measurement> _measurementRepository;
        private IGenericRepository<Notification> _notificationRepository;
        private IGenericRepository<EmailValidation> _emailValidationRepository;
        private IGenericRepository<TrainingSet> _trainingSetRepository;

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

        public IGenericRepository<Injury> InjuredMuscleTherapyRepository
        {
            get
            {
                _injuryMedicalRecordRepository ??= new GenericRepository<Injury>(_dbContext);
                return _injuryMedicalRecordRepository;
            }
        }

        public IGenericRepository<Therapy> TherapyRepository
        {
            get
            {
                _therapyRepository ??= new GenericRepository<Therapy>(_dbContext);
                return _therapyRepository;
            }
        }

        public IGenericRepository<Meal> MealRepository
        {
            get
            {
                _mealRepository ??= new GenericRepository<Meal>(_dbContext);
                return _mealRepository;
            }
        }

        public IGenericRepository<NutritionPlan> NutritionPlanRepository
        {
            get
            {
                _nutritionPlanRepository ??= new GenericRepository<NutritionPlan>(_dbContext);
                return _nutritionPlanRepository;
            }
        }

        public IGenericRepository<FoodOrder> FoodOrderRepository
        {
            get
            {
                _foodOrderRepository ??= new GenericRepository<FoodOrder>(_dbContext);
                return _foodOrderRepository;
            }
        }

        public IGenericRepository<FoodPrice> FoodPriceRepository
        {
            get
            {
                _foodPriceRepository ??= new GenericRepository<FoodPrice>(_dbContext);
                return _foodPriceRepository;
            }
        }

        public IGenericRepository<FoodSupplyReport> FoodSupplyReportRepository
        {
            get
            {
                _foodSupplyReportRepository ??= new GenericRepository<FoodSupplyReport>(_dbContext);
                return _foodSupplyReportRepository;
            }
        }

        public IGenericRepository<Measurement> MeasurementRepository
        {
            get
            {
                _measurementRepository ??= new GenericRepository<Measurement>(_dbContext);
                return _measurementRepository;
            }
        }

        public IGenericRepository<Notification> NotificationRepository
        {
            get
            {
                _notificationRepository ??= new GenericRepository<Notification>(_dbContext);
                return _notificationRepository;
            }
        }

        public IGenericRepository<EmailValidation> EmailValidationRepository
        {
            get
            {
                _emailValidationRepository ??= new GenericRepository<EmailValidation>(_dbContext);
                return _emailValidationRepository;
            }
        }

        public IGenericRepository<TrainingSet> TrainingSetRepository
        {
            get
            {
                _trainingSetRepository ??= new GenericRepository<TrainingSet>(_dbContext);
                return _trainingSetRepository;
            }
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
