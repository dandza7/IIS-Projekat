using IIS_Projekat.Models;
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
        public DbSet<Injury> Injuries { get; set; }
        public DbSet<MedicalRecord> MedicalRecords { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Report> Reports { get; set; }
        public IIS_DBContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            byte[] salt;
            modelBuilder.Entity<User>().HasQueryFilter(user => !user.IsDeleted);
            modelBuilder.Entity<User>().HasKey(u => u.Id);
            modelBuilder.Entity<User>().Property(u => u.Email).IsRequired();
            modelBuilder.Entity<User>().Property(u => u.Password).IsRequired();
            modelBuilder.Entity<User>().Property(u => u.Role).IsRequired();
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

            modelBuilder.Entity<UsersProfile>().Property(up => up.Name).IsRequired(false);
            modelBuilder.Entity<UsersProfile>().Property(up => up.Surname).IsRequired(false);
            modelBuilder.Entity<UsersProfile>().Property(up => up.BirthDate).IsRequired();
            modelBuilder.Entity<UsersProfile>().Property(up => up.Gender).IsRequired(false);
            modelBuilder.Entity<UsersProfile>().Property(up => up.Avatar).IsRequired(false);

            modelBuilder.Entity<MuscleGroup>().HasQueryFilter(mg => !mg.IsDeleted);
            modelBuilder.Entity<MuscleGroup>().HasKey(mg => mg.Id);
            modelBuilder.Entity<MuscleGroup>().Property(mg => mg.Name).IsRequired();
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
            modelBuilder.Entity<MuscleGroup>().HasMany(mg => mg.MuscleGroups).WithOne(emg => emg.MuscleGroup).OnDelete(DeleteBehavior.Cascade).IsRequired();
            modelBuilder.Entity<MuscleGroup>().HasMany(mg => mg.Injuries).WithOne(i => i.Muscle).OnDelete(DeleteBehavior.Cascade).IsRequired();

            modelBuilder.Entity<Exercise>().HasQueryFilter(e => !e.IsDeleted);
            modelBuilder.Entity<Exercise>().HasKey(e => e.Id);
            modelBuilder.Entity<Exercise>().Property(e => e.Name).IsRequired();
            modelBuilder.Entity<Exercise>().Property(e => e.IsHypertrophic).IsRequired();
            modelBuilder.Entity<Exercise>().HasMany(e => e.ExercisesMG).WithOne(emg => emg.Exercise).OnDelete(DeleteBehavior.Cascade).IsRequired();
            modelBuilder.Entity<Exercise>().HasMany(e => e.ExercisesTS).WithOne(ets => ets.Exercise).OnDelete(DeleteBehavior.Cascade).IsRequired();

            modelBuilder.Entity<ExerciseMuscleGroup>().HasQueryFilter(e => !e.IsDeleted);
            modelBuilder.Entity<ExerciseMuscleGroup>().HasKey(e => e.Id);
            modelBuilder.Entity<ExerciseMuscleGroup>().Property(e => e.IsPrimaryMuscleGroup).IsRequired();

            modelBuilder.Entity<ExerciseTrainingSession>().HasQueryFilter(e => !e.IsDeleted);
            modelBuilder.Entity<ExerciseTrainingSession>().HasKey(e => e.Id);
            modelBuilder.Entity<ExerciseTrainingSession>().Property(e => e.RepetitionRange).IsRequired();
            modelBuilder.Entity<ExerciseTrainingSession>().Property(e => e.NumberOfSets).IsRequired();

            modelBuilder.Entity<TrainingSession>().HasQueryFilter(ts => !ts.IsDeleted);
            modelBuilder.Entity<TrainingSession>().HasKey(ts => ts.Id);
            modelBuilder.Entity<TrainingSession>().Property(ts => ts.Name).IsRequired();
            modelBuilder.Entity<TrainingSession>().HasMany(ts => ts.TrainingSessions).WithOne(ets => ets.TrainingSession).OnDelete(DeleteBehavior.Cascade).IsRequired();

            modelBuilder.Entity<TrainingPlan>().HasQueryFilter(tp => !tp.IsDeleted);
            modelBuilder.Entity<TrainingPlan>().HasKey(tp => tp.Id);
            modelBuilder.Entity<TrainingPlan>().Property(tp => tp.TrainingGoal).IsRequired();
            modelBuilder.Entity<TrainingPlan>().Property(tp => tp.SessionsPerWeek).IsRequired();
            modelBuilder.Entity<TrainingPlan>().HasMany(tp => tp.TrainingSessions).WithOne(ts => ts.TrainingPlan).OnDelete(DeleteBehavior.Cascade).IsRequired();
            modelBuilder.Entity<TrainingPlan>().HasOne(tp => tp.Client).WithMany().HasForeignKey(tp => tp.ClientId).IsRequired();

            modelBuilder.Entity<TrainingPlanRequest>().HasQueryFilter(tpr => !tpr.IsDeleted);
            modelBuilder.Entity<TrainingPlanRequest>().HasKey(tpr => tpr.Id);
            modelBuilder.Entity<TrainingPlanRequest>().Property(tpr => tpr.SessionsPerWeek).IsRequired();
            modelBuilder.Entity<TrainingPlanRequest>().Property(tpr => tpr.TrainingGoal).IsRequired();
            modelBuilder.Entity<TrainingPlanRequest>().HasOne(tpr => tpr.Client).WithMany().HasForeignKey(tpr => tpr.ClientId).IsRequired();

            modelBuilder.Entity<Diagnosis>().HasQueryFilter(d => !d.IsDeleted);
            modelBuilder.Entity<Diagnosis>().HasKey(d => d.Id);
            modelBuilder.Entity<Diagnosis>().Property(d => d.Name).IsRequired();

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

            modelBuilder.Entity<Injury>().HasQueryFilter(i => !i.IsDeleted);
            modelBuilder.Entity<Injury>().HasKey(i => i.Id);
            modelBuilder.Entity<Injury>().Property(i => i.InjurySeverity).IsRequired();

            modelBuilder.Entity<MedicalRecord>().HasQueryFilter(mr => !mr.IsDeleted);
            modelBuilder.Entity<MedicalRecord>().HasKey(mr => mr.Id);
            modelBuilder.Entity<MedicalRecord>().Property(mr => mr.Anamnesis).IsRequired(false);
            modelBuilder.Entity<MedicalRecord>().Property(mr => mr.Weight).IsRequired();
            modelBuilder.Entity<MedicalRecord>().Property(mr => mr.Height).IsRequired();
            modelBuilder.Entity<MedicalRecord>().Property(mr => mr.Therapy).IsRequired(false);
            modelBuilder.Entity<MedicalRecord>().HasMany(mr => mr.Injuries).WithMany(i => i.MedicalRecords);
            modelBuilder.Entity<MedicalRecord>().HasMany(mr => mr.Allergies).WithMany(a => a.MedicalRecords);
            modelBuilder.Entity<MedicalRecord>().HasMany(mr => mr.Diagnoses).WithMany(d => d.MedicalRecords);

            modelBuilder.Entity<Appointment>().HasQueryFilter(a => !a.IsDeleted);
            modelBuilder.Entity<Appointment>().HasKey(a => a.Id);
            modelBuilder.Entity<Appointment>().Property(a => a.Beginning).IsRequired();
            modelBuilder.Entity<Appointment>().Property(a => a.Ending).IsRequired();
            modelBuilder.Entity<Appointment>().HasOne(a => a.Patient).WithMany().OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Appointment>().HasOne(a => a.Doctor).WithMany().OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Report>().HasQueryFilter(r => !r.IsDeleted);
            modelBuilder.Entity<Report>().HasKey(r => r.Id);
            modelBuilder.Entity<Report>().Property(r => r.Message).IsRequired();
            modelBuilder.Entity<Report>().HasOne(r => r.Appointment).WithOne(a => a.Report).HasForeignKey<Appointment>(a => a.ReportId);
        }
    }
}
