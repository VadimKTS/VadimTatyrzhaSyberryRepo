using PasswordGenerator.Data.Entity;

namespace PasswordGenerator.Services.Interface
{
    public interface IBookService
    {
        Task<IEnumerable<Book>> SearchBooksAsync(string query);
    }
}
