using Microsoft.EntityFrameworkCore;
using PasswordGenerator.Data.Entity;

namespace PasswordGenerator.Data.Repositiries.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetAllAsync(T entity);
        Task<T> GetByIdAsync(long id);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task DeleteByIdAsync(long id);
    }
}
