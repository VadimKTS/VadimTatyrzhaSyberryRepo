using Microsoft.EntityFrameworkCore;
using PasswordGenerator.Models;

namespace PasswordGenerator.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<BookModel> Books { get; set; }
    }
}
