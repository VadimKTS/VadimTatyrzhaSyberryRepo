using PasswordGenerator.Data.Entity;
using PasswordGenerator.Data.Repositiries.Interfaces;

namespace PasswordGenerator.Data.Repositiries
{
    public interface IUnitOfWork
    {
        IBaseRepository<Book> Books { get; }
    }
}
