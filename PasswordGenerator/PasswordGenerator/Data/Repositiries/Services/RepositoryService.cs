using Microsoft.EntityFrameworkCore;
using PasswordGenerator.Data.Repositiries.Interfaces;

namespace PasswordGenerator.Data.Repositiries.Services
{
    public class RepositoryService<T> : IRepositoryService<T> where T : class
    {
        private readonly ApplicationDbContext _dbContext;
        public RepositoryService(ApplicationDbContext context)
        {
            _dbContext = context;
        }
        
        public async Task<IList<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }
    }
}
