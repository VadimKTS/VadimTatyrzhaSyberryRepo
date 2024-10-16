using Microsoft.EntityFrameworkCore;
using PasswordGenerator.Data;
using PasswordGenerator.Models;
using PasswordGenerator.Services.Interface;

namespace PasswordGenerator.Services.Service
{
    public class BookService : IBookService
    {
        private readonly ApplicationDbContext _context;

        public BookService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<BookModel>> SearchBooksAsync(string query)
        {
            return await _context.Books
                                 .Where(b => b.Title.Contains(query) || b.Author.Contains(query))
                                 .ToListAsync();
        }
    }
}
