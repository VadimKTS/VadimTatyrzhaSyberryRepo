using Microsoft.EntityFrameworkCore;
using PasswordGenerator.Data.Entity;
using PasswordGenerator.Data.Repositiries.Interfaces;

namespace PasswordGenerator.Data.Repositiries.Services
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly ApplicationDbContext _dbcontext;
        protected DbSet<T> _dbSet;

        public BaseRepository(ApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
            _dbSet = _dbcontext.Set<T>();
        }

        public virtual async void CreateAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _dbcontext.SaveChangesAsync();
        }
        public virtual async Task<List<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }
        public virtual async Task<T> GetByIdAsync(long id)
        {
            return await _dbSet.FindAsync(id); //Return: The entity found or NULL!
        }
        public virtual async Task UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
            await _dbcontext.SaveChangesAsync();
        }
        public virtual async Task DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);
            await _dbcontext.SaveChangesAsync();
        }
        public virtual async Task DeleteByIdAsync(long id)
        {
            await DeleteAsync(await GetByIdAsync(id));
            await _dbcontext.SaveChangesAsync();
        }
    }
}
