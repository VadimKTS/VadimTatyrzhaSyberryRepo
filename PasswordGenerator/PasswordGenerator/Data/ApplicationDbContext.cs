using Microsoft.EntityFrameworkCore;
using PasswordGenerator.Data.Entity;
using PasswordGenerator.Models;

namespace PasswordGenerator.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<BookModel> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", PublishedDate = "1925", Picture = "default" },
                new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", PublishedDate = "1960", Picture = "default" },
                new Book { Id = 3, Title = "1984", Author = "George Orwell", PublishedDate = "1949", Picture = "default" },
                new Book { Id = 4, Title = "The Master and Margarita", Author = "Mikhail Bulgakov", PublishedDate = "1940", Picture = "default" },
                new Book { Id = 5, Title = "The Lord of the Rings", Author = "John Ronald Reuel Tolkien", PublishedDate = "1949", Picture = "default" }
            );
        }
    }
}
