﻿using IIS_Projekat.Models;
using IIS_Projekat.SupportClasses.PasswordHasher;
using IIS_Projekat.SupportClasses.Roles;
using Microsoft.EntityFrameworkCore;

namespace IIS_Projekat.Data
{
    public class IIS_DBContext : DbContext
    {
        public DbSet<ExerciseMuscleGroup> ExerciseMuscleGroups { get; set; }
        public DbSet<MuscleGroup> MuscleGroups { get; set; }
        public DbSet<TrainingPlanRequest> TrainingPlanRequests { get; set; }
        public DbSet<TrainingPlan> TrainingPlans { get; set; }
        public DbSet<TrainingSession> TrainingSessions { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UsersProfile> Profiles { get; set; }
        public DbSet<Diagnosis> Diagnoses { get; set; }
        public DbSet<Nutrient> Nutrients { get; set; }
        public DbSet<Allergy> Allergies { get; set; }
        public DbSet<Food> Food { get; set; }
        public DbSet<NutrientShare> NutrientShares { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<FoodShare> FoodShares { get; set; }
        public DbSet<MedicalRecord> MedicalRecords { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<NutritionPlan> NutritionPlans { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Therapy> Therapies { get; set; }
        public DbSet<FoodPrice> FoodPrices { get; set; }
        public DbSet<FoodOrder> FoodOrders { get; set; }
        public DbSet<FoodSupplyReport> FoodSupplyReports { get; set; }
        public DbSet<Measurement> Measurements { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<EmailValidation> EmailValidations { get; set; }
        public DbSet<TrainingSet> TrainingSets { get; set; }
        public IIS_DBContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            byte[] salt;
            modelBuilder.Entity<User>().HasQueryFilter(user => !user.IsDeleted);
            modelBuilder.Entity<User>().HasKey(u => u.Id);
            modelBuilder.Entity<User>().Property(u => u.Email).IsRequired().HasMaxLength(64);
            modelBuilder.Entity<User>().Property(u => u.Password).IsRequired().HasMaxLength(128);
            modelBuilder.Entity<User>().Property(u => u.Role).IsRequired().HasMaxLength(16);
            modelBuilder.Entity<User>().HasOne(u => u.Profile).WithOne(p => p.User).HasForeignKey<UsersProfile>(p => p.UserId);
            modelBuilder.Entity<User>().HasOne(u => u.MedicalRecord).WithOne(mr => mr.Patient).HasForeignKey<MedicalRecord>(p => p.PatientId);
            modelBuilder.Entity<User>(user =>
            {
                user.HasData(
                    new
                    {
                        Id = 1L,
                        Email = "admin@gmail.com",
                        Password = PasswordHasher.HashPassword("123", out salt),
                        Salt = salt,
                        Role = Roles.Admin,
                        CreatedDate = DateTime.UtcNow,
                        ModifiedDate = DateTime.UtcNow,
                        IsDeleted = false
                    });
            });

            modelBuilder.Entity<UsersProfile>().Property(up => up.Name).IsRequired(false).HasMaxLength(128);
            modelBuilder.Entity<UsersProfile>().Property(up => up.Surname).IsRequired(false).HasMaxLength(128);
            modelBuilder.Entity<UsersProfile>().Property(up => up.BirthDate).IsRequired();
            modelBuilder.Entity<UsersProfile>().Property(up => up.Gender).IsRequired(false).HasMaxLength(16);
            modelBuilder.Entity<UsersProfile>().Property(up => up.Avatar).IsRequired(false);
            modelBuilder.Entity<UsersProfile>().Property(up => up.Biography).IsRequired(false).HasMaxLength(1024);
            modelBuilder.Entity<UsersProfile>().HasMany(up => up.UsersNotifications).WithOne(n => n.Reciever);

            modelBuilder.Entity<MuscleGroup>().HasQueryFilter(mg => !mg.IsDeleted);
            modelBuilder.Entity<MuscleGroup>().HasKey(mg => mg.Id);
            modelBuilder.Entity<MuscleGroup>().Property(mg => mg.Name).IsRequired().HasMaxLength(32);
            #region Muscle Group Dummy Data
            modelBuilder.Entity<MuscleGroup>(mg =>
            {
                mg.HasData(
                    new
                    {
                        Id = 1L,
                        Name = "Calves",
                        CreatedDate = DateTime.UtcNow,
                        ModifiedDate = DateTime.UtcNow,
                        IsDeleted = false
                    });
                mg.HasData(
                    new
                    {
                        Id = 2L,
                        Name = "Quads",
                        CreatedDate = DateTime.UtcNow,
                        ModifiedDate = DateTime.UtcNow,
                        IsDeleted = false
                    });
                mg.HasData(
                    new
                    {
                        Id = 3L,
                        Name = "Hamstrings",
                        CreatedDate = DateTime.UtcNow,
                        ModifiedDate = DateTime.UtcNow,
                        IsDeleted = false
                    });
                mg.HasData(
                    new
                    {
                        Id = 4L,
                        Name = "Abductors",
                        CreatedDate = DateTime.UtcNow,
                        ModifiedDate = DateTime.UtcNow,
                        IsDeleted = false
                    });
                mg.HasData(
                    new
                    {
                        Id = 5L,
                        Name = "Adductors",
                        CreatedDate = DateTime.UtcNow,
                        ModifiedDate = DateTime.UtcNow,
                        IsDeleted = false
                    });
                mg.HasData(
                    new
                    {
                        Id = 6L,
                        Name = "Gluteus",
                        CreatedDate = DateTime.UtcNow,
                        ModifiedDate = DateTime.UtcNow,
                        IsDeleted = false
                    });
                mg.HasData(
                    new
                    {
                        Id = 7L,
                        Name = "Core",
                        CreatedDate = DateTime.UtcNow,
                        ModifiedDate = DateTime.UtcNow,
                        IsDeleted = false
                    });
                mg.HasData(
                    new
                    {
                        Id = 8L,
                        Name = "Abs",
                        CreatedDate = DateTime.UtcNow,
                        ModifiedDate = DateTime.UtcNow,
                        IsDeleted = false
                    });
                mg.HasData(
                    new
                    {
                        Id = 9L,
                        Name = "Lower Back",
                        CreatedDate = DateTime.UtcNow,
                        ModifiedDate = DateTime.UtcNow,
                        IsDeleted = false
                    });
                mg.HasData(
                    new
                    {
                        Id = 10L,
                        Name = "Lats",
                        CreatedDate = DateTime.UtcNow,
                        ModifiedDate = DateTime.UtcNow,
                        IsDeleted = false
                    });
                mg.HasData(
                    new
                    {
                        Id = 11L,
                        Name = "Teres Major",
                        CreatedDate = DateTime.UtcNow,
                        ModifiedDate = DateTime.UtcNow,
                        IsDeleted = false
                    });
                mg.HasData(
                    new
                    {
                        Id = 12L,
                        Name = "Lower Traps",
                        CreatedDate = DateTime.UtcNow,
                        ModifiedDate = DateTime.UtcNow,
                        IsDeleted = false
                    });
                mg.HasData(
                    new
                    {
                        Id = 13L,
                        Name = "Traps",
                        CreatedDate = DateTime.UtcNow,
                        ModifiedDate = DateTime.UtcNow,
                        IsDeleted = false
                    });
                mg.HasData(
                    new
                    {
                        Id = 14L,
                        Name = "Rear Delts",
                        CreatedDate = DateTime.UtcNow,
                        ModifiedDate = DateTime.UtcNow,
                        IsDeleted = false
                    });
                mg.HasData(
                    new
                    {
                        Id = 15L,
                        Name = "Side Delts",
                        CreatedDate = DateTime.UtcNow,
                        ModifiedDate = DateTime.UtcNow,
                        IsDeleted = false
                    });
                mg.HasData(
                    new
                    {
                        Id = 16L,
                        Name = "Front Delts",
                        CreatedDate = DateTime.UtcNow,
                        ModifiedDate = DateTime.UtcNow,
                        IsDeleted = false
                    });
                mg.HasData(
                    new
                    {
                        Id = 17L,
                        Name = "Upper Chest",
                        CreatedDate = DateTime.UtcNow,
                        ModifiedDate = DateTime.UtcNow,
                        IsDeleted = false
                    });
                mg.HasData(
                    new
                    {
                        Id = 18L,
                        Name = "Lower Chest",
                        CreatedDate = DateTime.UtcNow,
                        ModifiedDate = DateTime.UtcNow,
                        IsDeleted = false
                    });
                mg.HasData(
                    new
                    {
                        Id = 19L,
                        Name = "Biceps",
                        CreatedDate = DateTime.UtcNow,
                        ModifiedDate = DateTime.UtcNow,
                        IsDeleted = false
                    });
                mg.HasData(
                    new
                    {
                        Id = 20L,
                        Name = "Triceps",
                        CreatedDate = DateTime.UtcNow,
                        ModifiedDate = DateTime.UtcNow,
                        IsDeleted = false
                    });
                mg.HasData(
                    new
                    {
                        Id = 21L,
                        Name = "Brachialis",
                        CreatedDate = DateTime.UtcNow,
                        ModifiedDate = DateTime.UtcNow,
                        IsDeleted = false
                    });
                mg.HasData(
                    new
                    {
                        Id = 22L,
                        Name = "Forearms",
                        CreatedDate = DateTime.UtcNow,
                        ModifiedDate = DateTime.UtcNow,
                        IsDeleted = false
                    });
            });
            #endregion
            modelBuilder.Entity<MuscleGroup>().HasMany(mg => mg.TargetedByExercises).WithOne(emg => emg.MuscleGroup).IsRequired();
            modelBuilder.Entity<MuscleGroup>().HasMany(mg => mg.TherapiesForInjury).WithOne(imt => imt.InjuredMuscle).IsRequired();

            modelBuilder.Entity<Exercise>().HasQueryFilter(e => !e.IsDeleted);
            modelBuilder.Entity<Exercise>().HasKey(e => e.Id);
            modelBuilder.Entity<Exercise>().Property(e => e.Name).IsRequired().HasMaxLength(64);
            modelBuilder.Entity<Exercise>().Property(e => e.IsHypertrophic).IsRequired();
            modelBuilder.Entity<Exercise>().HasMany(e => e.MuscleGroups).WithOne(emg => emg.Exercise).IsRequired();
            modelBuilder.Entity<Exercise>().HasMany(e => e.TrainingSessions).WithOne(ets => ets.Exercise).IsRequired();

            modelBuilder.Entity<ExerciseMuscleGroup>().HasQueryFilter(e => !e.IsDeleted);
            modelBuilder.Entity<ExerciseMuscleGroup>().HasKey(e => e.Id);
            modelBuilder.Entity<ExerciseMuscleGroup>().Property(e => e.IsPrimaryMuscleGroup).IsRequired();

            modelBuilder.Entity<ExerciseTrainingSession>().HasQueryFilter(e => !e.IsDeleted);
            modelBuilder.Entity<ExerciseTrainingSession>().HasKey(e => e.Id);
            modelBuilder.Entity<ExerciseTrainingSession>().Property(e => e.RepetitionRange).IsRequired().HasMaxLength(8);
            modelBuilder.Entity<ExerciseTrainingSession>().Property(e => e.NumberOfSets).IsRequired();
            modelBuilder.Entity<ExerciseTrainingSession>().Property(e => e.Note).IsRequired(false).HasMaxLength(400);
            modelBuilder.Entity<ExerciseTrainingSession>().Property(e => e.IsUnhappy).IsRequired().HasDefaultValue(false);

            modelBuilder.Entity<TrainingSession>().HasQueryFilter(ts => !ts.IsDeleted);
            modelBuilder.Entity<TrainingSession>().HasKey(ts => ts.Id);
            modelBuilder.Entity<TrainingSession>().Property(ts => ts.Name).IsRequired().HasMaxLength(32);
            modelBuilder.Entity<TrainingSession>().HasMany(ts => ts.ExercisesInSession).WithOne(ets => ets.TrainingSession)
                .IsRequired();

            modelBuilder.Entity<TrainingPlan>().HasQueryFilter(tp => !tp.IsDeleted);
            modelBuilder.Entity<TrainingPlan>().HasKey(tp => tp.Id);
            modelBuilder.Entity<TrainingPlan>().Property(tp => tp.TrainingGoal).IsRequired().HasMaxLength(8);
            modelBuilder.Entity<TrainingPlan>().Property(tp => tp.SessionsPerWeek).IsRequired();
            modelBuilder.Entity<TrainingPlan>().HasMany(tp => tp.TrainingSessions).WithOne(ts => ts.TrainingPlan).IsRequired();
            modelBuilder.Entity<TrainingPlan>().HasOne(tp => tp.Client).WithMany().HasForeignKey(tp => tp.ClientId).IsRequired();
            modelBuilder.Entity<TrainingPlan>().HasOne(tp => tp.Trainer).WithMany().HasForeignKey(tp => tp.TrainerId).IsRequired()
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<TrainingPlanRequest>().HasQueryFilter(tpr => !tpr.IsDeleted);
            modelBuilder.Entity<TrainingPlanRequest>().HasKey(tpr => tpr.Id);
            modelBuilder.Entity<TrainingPlanRequest>().Property(tpr => tpr.SessionsPerWeek).IsRequired();
            modelBuilder.Entity<TrainingPlanRequest>().Property(tpr => tpr.TrainingGoal).IsRequired().HasMaxLength(8);
            modelBuilder.Entity<TrainingPlanRequest>().HasOne(tpr => tpr.Client).WithMany().HasForeignKey(tp => tp.ClientId).IsRequired();
            modelBuilder.Entity<TrainingPlanRequest>().HasOne(tp => tp.Trainer).WithMany().HasForeignKey(tp => tp.TrainerId).IsRequired()
                .OnDelete(DeleteBehavior.NoAction);
           

            modelBuilder.Entity<Diagnosis>().HasQueryFilter(d => !d.IsDeleted);
            modelBuilder.Entity<Diagnosis>().HasKey(d => d.Id);
            modelBuilder.Entity<Diagnosis>().Property(d => d.Name).IsRequired();
            modelBuilder.Entity<Diagnosis>().HasMany(d => d.InadvisableFoods).WithMany(f => f.Diagnoses);

            modelBuilder.Entity<Nutrient>().HasQueryFilter(n => !n.IsDeleted);
            modelBuilder.Entity<Nutrient>().HasKey(n => n.Id);
            modelBuilder.Entity<Nutrient>().Property(n => n.Name).IsRequired();
            modelBuilder.Entity<Nutrient>().HasMany(r => r.Participations).WithOne(ns => ns.Nutrient).OnDelete(DeleteBehavior.Cascade).IsRequired();
            #region Nutrient Dummy Data
            modelBuilder.Entity<Nutrient>(n =>
            {
                n.HasData(
                        new
                        {
                            Id = 1L,
                            Name = "Protein",
                            CreatedDate = DateTime.UtcNow,
                            ModifiedDate = DateTime.UtcNow,
                            IsDeleted = false
                        }
                    );
                n.HasData(
                        new
                        {
                            Id = 2L,
                            Name = "Fat",
                            CreatedDate = DateTime.UtcNow,
                            ModifiedDate = DateTime.UtcNow,
                            IsDeleted = false
                        }
                    );
                n.HasData(
                        new
                        {
                            Id = 3L,
                            Name = "Carbohydrates",
                            CreatedDate = DateTime.UtcNow,
                            ModifiedDate = DateTime.UtcNow,
                            IsDeleted = false
                        }
                    );
                n.HasData(
                        new
                        {
                            Id = 4L,
                            Name = "Fiber",
                            CreatedDate = DateTime.UtcNow,
                            ModifiedDate = DateTime.UtcNow,
                            IsDeleted = false
                        }
                    );
                n.HasData(
                        new
                        {
                            Id = 5L,
                            Name = "Sugar",
                            CreatedDate = DateTime.UtcNow,
                            ModifiedDate = DateTime.UtcNow,
                            IsDeleted = false
                        }
                    );
                n.HasData(
                        new
                        {
                            Id = 6L,
                            Name = "Vitamin A",
                            CreatedDate = DateTime.UtcNow,
                            ModifiedDate = DateTime.UtcNow,
                            IsDeleted = false
                        }
                    );
                n.HasData(
                        new
                        {
                            Id = 7L,
                            Name = "Vitamin B1",
                            CreatedDate = DateTime.UtcNow,
                            ModifiedDate = DateTime.UtcNow,
                            IsDeleted = false
                        }
                    );
                n.HasData(
                        new
                        {
                            Id = 8L,
                            Name = "Vitamin B2",
                            CreatedDate = DateTime.UtcNow,
                            ModifiedDate = DateTime.UtcNow,
                            IsDeleted = false
                        }
                    );
                n.HasData(
                        new
                        {
                            Id = 9L,
                            Name = "Vitamin B3",
                            CreatedDate = DateTime.UtcNow,
                            ModifiedDate = DateTime.UtcNow,
                            IsDeleted = false
                        }
                    );
                n.HasData(
                        new
                        {
                            Id = 10L,
                            Name = "Vitamin C",
                            CreatedDate = DateTime.UtcNow,
                            ModifiedDate = DateTime.UtcNow,
                            IsDeleted = false
                        }
                    );
                n.HasData(
                        new
                        {
                            Id = 11L,
                            Name = "Vitamin D",
                            CreatedDate = DateTime.UtcNow,
                            ModifiedDate = DateTime.UtcNow,
                            IsDeleted = false
                        }
                    );
                n.HasData(
                        new
                        {
                            Id = 12L,
                            Name = "Vitamin E",
                            CreatedDate = DateTime.UtcNow,
                            ModifiedDate = DateTime.UtcNow,
                            IsDeleted = false
                        }
                    );
                n.HasData(
                        new
                        {
                            Id = 13L,
                            Name = "Calcium",
                            CreatedDate = DateTime.UtcNow,
                            ModifiedDate = DateTime.UtcNow,
                            IsDeleted = false
                        }
                    );
                n.HasData(
                        new
                        {
                            Id = 14L,
                            Name = "Iron",
                            CreatedDate = DateTime.UtcNow,
                            ModifiedDate = DateTime.UtcNow,
                            IsDeleted = false
                        }
                    );
                n.HasData(
                        new
                        {
                            Id = 15L,
                            Name = "Magnesium",
                            CreatedDate = DateTime.UtcNow,
                            ModifiedDate = DateTime.UtcNow,
                            IsDeleted = false
                        }
                    );
                n.HasData(
                        new
                        {
                            Id = 16L,
                            Name = "Potassium",
                            CreatedDate = DateTime.UtcNow,
                            ModifiedDate = DateTime.UtcNow,
                            IsDeleted = false
                        }
                    );
                n.HasData(
                        new
                        {
                            Id = 17L,
                            Name = "Sodium",
                            CreatedDate = DateTime.UtcNow,
                            ModifiedDate = DateTime.UtcNow,
                            IsDeleted = false
                        }
                    );
                n.HasData(
                        new
                        {
                            Id = 18L,
                            Name = "Zinc",
                            CreatedDate = DateTime.UtcNow,
                            ModifiedDate = DateTime.UtcNow,
                            IsDeleted = false
                        }
                    );
            });
            #endregion

            modelBuilder.Entity<Allergy>().HasQueryFilter(a => !a.IsDeleted);
            modelBuilder.Entity<Allergy>().HasKey(a => a.Id);
            modelBuilder.Entity<Allergy>().Property(a => a.Name).IsRequired();

            modelBuilder.Entity<Food>().HasQueryFilter(f => !f.IsDeleted);
            modelBuilder.Entity<Food>().HasKey(f => f.Id);
            modelBuilder.Entity<Food>().Property(f => f.Name).IsRequired();
            modelBuilder.Entity<Food>().Property(f => f.Category).IsRequired();
            modelBuilder.Entity<Food>().Property(f => f.Calories).IsRequired();
            modelBuilder.Entity<Food>().HasMany(f => f.Participations).WithOne(fs => fs.Food).OnDelete(DeleteBehavior.Cascade).IsRequired();
            modelBuilder.Entity<Food>().HasMany(f => f.NutrientShares).WithOne(ns => ns.Food).OnDelete(DeleteBehavior.Cascade).IsRequired();
            modelBuilder.Entity<Food>().HasMany(f => f.Allergies).WithMany(a => a.Food);

            modelBuilder.Entity<NutrientShare>().HasQueryFilter(ns => !ns.IsDeleted);
            modelBuilder.Entity<NutrientShare>().HasKey(ns => ns.Id);
            modelBuilder.Entity<NutrientShare>().Property(ns => ns.Share).IsRequired();

            modelBuilder.Entity<Recipe>().HasQueryFilter(r => !r.IsDeleted);
            modelBuilder.Entity<Recipe>().HasKey(r => r.Id);
            modelBuilder.Entity<Recipe>().Property(r => r.Name).IsRequired();
            modelBuilder.Entity<Recipe>().HasMany(r => r.FoodShares).WithOne(fs => fs.Recipe).OnDelete(DeleteBehavior.Cascade).IsRequired();

            modelBuilder.Entity<FoodShare>().HasQueryFilter(fs => !fs.IsDeleted);
            modelBuilder.Entity<FoodShare>().HasKey(fs => fs.Id);
            modelBuilder.Entity<FoodShare>().Property(fs => fs.Share).IsRequired();

            modelBuilder.Entity<MedicalRecord>().HasQueryFilter(mr => !mr.IsDeleted);
            modelBuilder.Entity<MedicalRecord>().HasKey(mr => mr.Id);
            modelBuilder.Entity<MedicalRecord>().Property(mr => mr.Anamnesis).IsRequired(false).HasMaxLength(2048);
            modelBuilder.Entity<MedicalRecord>().Property(mr => mr.Weight).IsRequired();
            modelBuilder.Entity<MedicalRecord>().Property(mr => mr.Height).IsRequired();
            modelBuilder.Entity<MedicalRecord>().Property(mr => mr.Therapy).IsRequired(false);
            modelBuilder.Entity<MedicalRecord>().HasMany(mr => mr.Allergies).WithMany(a => a.MedicalRecords);
            modelBuilder.Entity<MedicalRecord>().HasMany(mr => mr.Diagnoses).WithMany(d => d.MedicalRecords);
            modelBuilder.Entity<MedicalRecord>().HasMany(mr => mr.Therapies).WithOne(t => t.MedicalRecord)
                .HasForeignKey(t => t.MedicalRecordId).IsRequired();
            modelBuilder.Entity<MedicalRecord>().HasMany(mr => mr.Measurements)
                .WithOne(m => m.MedicalRecord).HasForeignKey(m => m.MedicalRecordId).IsRequired();

            modelBuilder.Entity<Injury>().HasQueryFilter(e => !e.IsDeleted);
            modelBuilder.Entity<Injury>().HasKey(e => e.Id);
            modelBuilder.Entity<Injury>().Property(e => e.InjurySeverity).IsRequired().HasMaxLength(8);

            modelBuilder.Entity<Appointment>().HasQueryFilter(a => !a.IsDeleted);
            modelBuilder.Entity<Appointment>().HasKey(a => a.Id);
            modelBuilder.Entity<Appointment>().Property(a => a.Beginning).IsRequired();
            modelBuilder.Entity<Appointment>().Property(a => a.Ending).IsRequired();
            modelBuilder.Entity<Appointment>().HasOne(a => a.Patient).WithMany().OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Appointment>().HasOne(a => a.Doctor).WithMany().OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<NutritionPlan>().HasQueryFilter(np => !np.IsDeleted);
            modelBuilder.Entity<NutritionPlan>().HasKey(np => np.Id);
            modelBuilder.Entity<NutritionPlan>().Property(np => np.Date).IsRequired();
            modelBuilder.Entity<NutritionPlan>().Property(np => np.IsOrdered).IsRequired();
            modelBuilder.Entity<NutritionPlan>().HasOne(np => np.User).WithMany().HasForeignKey(np => np.UserId).IsRequired();

            modelBuilder.Entity<Meal>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Meal>().HasKey(m => m.Id);
            modelBuilder.Entity<Meal>().Property(m => m.PortionSize).IsRequired();
            modelBuilder.Entity<Meal>().Property(m => m.Type).IsRequired();
            modelBuilder.Entity<Meal>().HasOne(m => m.Recipe).WithMany().HasForeignKey(m => m.RecipeId).IsRequired();
            modelBuilder.Entity<Meal>().HasOne(m => m.NutritionPlan).WithMany(np => np.Meals).IsRequired();

            modelBuilder.Entity<Therapy>().HasQueryFilter(t => !t.IsDeleted);
            modelBuilder.Entity<Therapy>().HasKey(t => t.Id);
            modelBuilder.Entity<Therapy>().Property(t => t.ReportMessage).IsRequired().HasMaxLength(1024);
            modelBuilder.Entity<Therapy>().HasMany(t => t.RecommendedExercises).WithMany();
            modelBuilder.Entity<Therapy>().HasMany(t => t.InjuredMuscles).WithOne(imt => imt.Therapy).IsRequired();

            modelBuilder.Entity<FoodPrice>().HasQueryFilter(fp => !fp.IsDeleted);
            modelBuilder.Entity<FoodPrice>().HasKey(fp => fp.Id);
            modelBuilder.Entity<FoodPrice>().Property(fp => fp.Price).IsRequired();
            modelBuilder.Entity<FoodPrice>().Property(fp => fp.Supplier).IsRequired();
            modelBuilder.Entity<FoodPrice>().HasOne(fp => fp.Food).WithMany().HasForeignKey(fp => fp.FoodId).IsRequired();

            modelBuilder.Entity<FoodSupplyReport>().HasQueryFilter(fsr => !fsr.IsDeleted);
            modelBuilder.Entity<FoodSupplyReport>().HasKey(fsr => fsr.Id);
            modelBuilder.Entity<FoodSupplyReport>().Property(fsr => fsr.DeliveryDate).IsRequired();
            modelBuilder.Entity<FoodSupplyReport>().Property(fsr => fsr.IsConfirmed).IsRequired();
            modelBuilder.Entity<FoodSupplyReport>().HasMany(fsr => fsr.FoodOrders).WithMany();

            modelBuilder.Entity<FoodOrder>().HasQueryFilter(fo => !fo.IsDeleted);
            modelBuilder.Entity<FoodOrder>().HasKey(fo => fo.Id);
            modelBuilder.Entity<FoodOrder>().Property(fo => fo.Amount).IsRequired();
            modelBuilder.Entity<FoodOrder>().HasOne(fo => fo.FoodPrice).WithMany().HasForeignKey(fo => fo.FoodPriceId).IsRequired();

            modelBuilder.Entity<Measurement>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Measurement>().HasKey(m => m.Id);
            modelBuilder.Entity<Measurement>().Property(m => m.Weight).IsRequired();
            modelBuilder.Entity<Measurement>().Property(m => m.Bicep).IsRequired();
            modelBuilder.Entity<Measurement>().Property(m => m.Forearm).IsRequired();
            modelBuilder.Entity<Measurement>().Property(m => m.Chest).IsRequired();
            modelBuilder.Entity<Measurement>().Property(m => m.Waist).IsRequired();
            modelBuilder.Entity<Measurement>().Property(m => m.Thigh).IsRequired();
            modelBuilder.Entity<Measurement>().Property(m => m.Calf).IsRequired();

            modelBuilder.Entity<Notification>().HasQueryFilter(n => !n.IsDeleted);
            modelBuilder.Entity<Notification>().HasKey(n => n.Id);
            modelBuilder.Entity<Notification>().Property(n => n.Content).IsRequired(false).HasMaxLength(64);

            modelBuilder.Entity<EmailValidation>().HasQueryFilter(ev => !ev.IsDeleted);
            modelBuilder.Entity<EmailValidation>().HasKey(ev => ev.Id);
            modelBuilder.Entity<EmailValidation>().Property(ev => ev.Code).IsRequired();
            modelBuilder.Entity<EmailValidation>().HasOne(ev => ev.User).WithMany();

            modelBuilder.Entity<TrainingSet>().HasQueryFilter(ts => !ts.IsDeleted);
            modelBuilder.Entity<TrainingSet>().HasKey(ts => ts.Id);
            modelBuilder.Entity<TrainingSet>().Property(ts => ts.Weight).IsRequired();
            modelBuilder.Entity<TrainingSet>().Property(ts => ts.Repetitions).IsRequired();
            modelBuilder.Entity<TrainingSet>().HasOne(ts => ts.TrainingSession).WithMany(ts => ts.DocumentedSets)
                .HasForeignKey(ts => ts.TrainingSessionId).IsRequired();
            modelBuilder.Entity<TrainingSet>().HasOne(ts => ts.Exercise).WithMany(e => e.ExerciseSets)
                .HasForeignKey(ts => ts.ExerciseId).IsRequired();
        }
    }
}
