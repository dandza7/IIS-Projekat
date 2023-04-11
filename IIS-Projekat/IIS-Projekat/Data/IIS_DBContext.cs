using IIS_Projekat.Models;
using IIS_Projekat.SupportClasses.PasswordHasher;
using IIS_Projekat.SupportClasses.Roles;
using Microsoft.EntityFrameworkCore;

namespace IIS_Projekat.Data
{
    public class IIS_DBContext : DbContext
    {
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
            modelBuilder.Entity<UsersProfile>().Property(up => up.Name).IsRequired(false);
            modelBuilder.Entity<UsersProfile>().Property(up => up.Surname).IsRequired(false);
            modelBuilder.Entity<UsersProfile>().Property(up => up.BirthDate).IsRequired();
            modelBuilder.Entity<UsersProfile>().Property(up => up.Gender).IsRequired(false);
            modelBuilder.Entity<UsersProfile>().Property(up => up.Avatar).IsRequired(false);
        }
    }
}
