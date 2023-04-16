using IIS_Projekat.Models;
using IIS_Projekat.SupportClasses.PasswordHasher;
using IIS_Projekat.SupportClasses.Roles;
using Microsoft.EntityFrameworkCore;

namespace IIS_Projekat.Data
{
    public class IIS_DBContext : DbContext
    {   
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
                    });
                mg.HasData(
                    new
                    {
                        Id = 1L,
                        Name = "Quads",
                    });
                mg.HasData(
                    new
                    {
                        Id = 1L,
                        Name = "Hamstrings",
                    });
                mg.HasData(
                    new
                    {
                        Id = 1L,
                        Name = "Abductors",
                    });
                mg.HasData(
                    new
                    {
                        Id = 1L,
                        Name = "Adductors",
                    });
                mg.HasData(
                    new
                    {
                        Id = 1L,
                        Name = "Gluteus",
                    });
                mg.HasData(
                    new
                    {
                        Id = 1L,
                        Name = "Core",
                    });
                mg.HasData(
                    new
                    {
                        Id = 1L,
                        Name = "Abs",
                    });
                mg.HasData(
                    new
                    {
                        Id = 1L,
                        Name = "Lower Back",
                    });
                mg.HasData(
                    new
                    {
                        Id = 1L,
                        Name = "Lats",
                    });
                mg.HasData(
                    new
                    {
                        Id = 1L,
                        Name = "Teres Major",
                    });
                mg.HasData(
                    new
                    {
                        Id = 1L,
                        Name = "Lower Traps",
                    });
                mg.HasData(
                    new
                    {
                        Id = 1L,
                        Name = "Traps",
                    });
                mg.HasData(
                    new
                    {
                        Id = 1L,
                        Name = "Rear Delts",
                    });
                mg.HasData(
                    new
                    {
                        Id = 1L,
                        Name = "Side Delts",
                    });
                mg.HasData(
                    new
                    {
                        Id = 1L,
                        Name = "Front Delts",
                    });
                mg.HasData(
                    new
                    {
                        Id = 1L,
                        Name = "Upper Chest",
                    });
                mg.HasData(
                    new
                    {
                        Id = 1L,
                        Name = "Lower Chest",
                    });
                mg.HasData(
                    new
                    {
                        Id = 1L,
                        Name = "Biceps",
                    });
                mg.HasData(
                    new
                    {
                        Id = 1L,
                        Name = "Triceps",
                    });
                mg.HasData(
                    new
                    {
                        Id = 1L,
                        Name = "Brachialis",
                    });
                mg.HasData(
                    new
                    {
                        Id = 1L,
                        Name = "Forearms",
                    });
            });
            #endregion

            modelBuilder.Entity<Exercise>().HasQueryFilter(e => !e.IsDeleted);
            modelBuilder.Entity<Exercise>().HasKey(e => e.Id);
            modelBuilder.Entity<Exercise>().Property(e => e.Name).IsRequired();
            modelBuilder.Entity<Exercise>().Property(e => e.PrimaryTargetMuscle).IsRequired();
            modelBuilder.Entity<Exercise>().Property(e => e.SecondaryTargetMuscles).IsRequired();
            modelBuilder.Entity<Exercise>().Property(e => e.Repetitions).IsRequired();

            modelBuilder.Entity<TrainingSession>().HasQueryFilter(ts => !ts.IsDeleted);
            modelBuilder.Entity<TrainingSession>().HasKey(ts => ts.Id);
            modelBuilder.Entity<TrainingSession>().Property(ts => ts.NumberOfExercises).IsRequired();
            modelBuilder.Entity<TrainingSession>().HasMany(ts => ts.Exercises).WithOne(e => e.TrainingSession).OnDelete(DeleteBehavior.Cascade).IsRequired();

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
