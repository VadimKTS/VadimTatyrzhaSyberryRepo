using PasswordGenerator.Data.Entity;
using PasswordGenerator.Data.Repositiries.Interfaces;
using PasswordGenerator.Data.Repositiries.Services;

namespace PasswordGenerator.Data.Repositiries
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly ApplicationDbContext _dbContext;
        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IBaseRepository<Book> Books => new BaseRepository<Book>(_dbContext);
    }
}
