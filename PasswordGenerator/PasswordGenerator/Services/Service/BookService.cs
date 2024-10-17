using PasswordGenerator.Data.Entity;
using PasswordGenerator.Data.Repositiries;
using PasswordGenerator.Services.Interface;

namespace PasswordGenerator.Services.Service
{
    public class BookService : ServiceConstructor, IBookService
    {
        public BookService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        public async Task<IEnumerable<Book>> SearchBooksAsync(string query)
        {
            var allBooks = await _unitOfWork.Books.GetAllAsync();
            return allBooks.Where(b => b.Title.Contains(query) ||
                                        b.Author.Contains(query)).ToList();
        }
    }
}
