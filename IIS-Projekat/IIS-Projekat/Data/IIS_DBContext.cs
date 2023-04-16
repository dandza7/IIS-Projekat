using IIS_Projekat.Models;
using IIS_Projekat.SupportClasses.PasswordHasher;
using IIS_Projekat.SupportClasses.Roles;
using Microsoft.EntityFrameworkCore;

namespace IIS_Projekat.Data
{
    public class IIS_DBContext : DbContext
    {
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

            modelBuilder.Entity<Exercise>().HasQueryFilter(e => !e.IsDeleted);
            modelBuilder.Entity<Exercise>().HasKey(e => e.Id);
            modelBuilder.Entity<Exercise>().Property(e => e.Name).IsRequired();
            modelBuilder.Entity<Exercise>().Property(e => e.PrimaryTargetMuscle).IsRequired();
            modelBuilder.Entity<Exercise>().Property(e => e.SeconaryTargetMuscles).IsRequired();
            modelBuilder.Entity<Exercise>().Property(e => e.Repetitions).IsRequired();
            modelBuilder.Entity<Exercise>().Property(e => e.TrainingSessionId).IsRequired();

            modelBuilder.Entity<TrainingSession>().HasQueryFilter(ts => !ts.IsDeleted);
            modelBuilder.Entity<TrainingSession>().HasKey(ts => ts.Id);
            modelBuilder.Entity<TrainingSession>().Property(ts => ts.NumberOfExercises).IsRequired();
            modelBuilder.Entity<TrainingSession>().Property(ts => ts.Exercises).IsRequired();

            modelBuilder.Entity<TrainingPlan>().HasQueryFilter(tp => !tp.IsDeleted);
            modelBuilder.Entity<TrainingPlan>().HasKey(tp => tp.Id);
            modelBuilder.Entity<TrainingPlan>().Property(tp => tp.TrainingGoal).IsRequired();
            modelBuilder.Entity<TrainingPlan>().Property(tp => tp.SessionsPerWeek).IsRequired();
            modelBuilder.Entity<TrainingPlan>().Property(tp => tp.TrainingSession).IsRequired();
            modelBuilder.Entity<TrainingPlan>().Property(tp => tp.ClientId).IsRequired();

            modelBuilder.Entity<TrainingPlanRequest>().HasQueryFilter(tpr => !tpr.IsDeleted);
            modelBuilder.Entity<TrainingPlanRequest>().HasKey(tpr => tpr.Id);
            modelBuilder.Entity<TrainingPlanRequest>().Property(tpr => tpr.SessionsPerWeek).IsRequired();
            modelBuilder.Entity<TrainingPlanRequest>().Property(tpr => tpr.TrainingGoal).IsRequired();
            modelBuilder.Entity<TrainingPlanRequest>().Property(tpr => tpr.ClientId).IsRequired();
        }
    }
}
