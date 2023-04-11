using IIS_Projekat.Models;
using Microsoft.EntityFrameworkCore;

namespace IIS_Projekat.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private IGenericRepository<User> _userRepository;
        private IGenericRepository<UsersProfile> _profileRepository;
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

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
