using PasswordGenerator.Models;

namespace PasswordGenerator.Services.Interface
{
    public interface IBookService
    {
        Task<IEnumerable<BookModel>> SearchBooksAsync(string query);
    }
}
