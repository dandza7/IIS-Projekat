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

            modelBuilder.Entity<Exercise>().HasQueryFilter(e => !e.IsDeleted);
            modelBuilder.Entity<Exercise>().HasKey(e => e.Id);
            modelBuilder.Entity<Exercise>().Property(e => e.Name).IsRequired();
            modelBuilder.Entity<Exercise>().Property(e => e.Repetitions).IsRequired();
            modelBuilder.Entity<Exercise>().HasMany(e => e.Exercises).WithOne(emg => emg.Exercise).OnDelete(DeleteBehavior.Cascade).IsRequired();

            modelBuilder.Entity<ExerciseMuscleGroup>().HasQueryFilter(e => !e.IsDeleted);
            modelBuilder.Entity<ExerciseMuscleGroup>().HasKey(e => e.Id);
            modelBuilder.Entity<ExerciseMuscleGroup>().Property(e => e.IsPrimaryMuscleGroup).IsRequired();

            modelBuilder.Entity<TrainingSession>().HasQueryFilter(ts => !ts.IsDeleted);
            modelBuilder.Entity<TrainingSession>().HasKey(ts => ts.Id);
            modelBuilder.Entity<TrainingSession>().Property(ts => ts.NumberOfExercises).IsRequired();
            modelBuilder.Entity<TrainingSession>().HasMany(ts => ts.Exercises).WithMany(e => e.TrainingSessions);
            
            modelBuilder.Entity<TrainingPlan>().HasQueryFilter(tp => !tp.IsDeleted);
            modelBuilder.Entity<TrainingPlan>().HasKey(tp => tp.Id);
            modelBuilder.Entity<TrainingPlan>().Property(tp => tp.TrainingGoal).IsRequired();
            modelBuilder.Entity<TrainingPlan>().Property(tp => tp.SessionsPerWeek).IsRequired();
            modelBuilder.Entity<TrainingPlan>().HasMany(tp => tp.TrainingSessions).WithOne(ts => ts.TrainingPlan).OnDelete(DeleteBehavior.Cascade).IsRequired();

            modelBuilder.Entity<TrainingPlanRequest>().HasQueryFilter(tpr => !tpr.IsDeleted);
            modelBuilder.Entity<TrainingPlanRequest>().HasKey(tpr => tpr.Id);
            modelBuilder.Entity<TrainingPlanRequest>().Property(tpr => tpr.SessionsPerWeek).IsRequired();
            modelBuilder.Entity<TrainingPlanRequest>().Property(tpr => tpr.TrainingGoal).IsRequired();
        }
    }
}
