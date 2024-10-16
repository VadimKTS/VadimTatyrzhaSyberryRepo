using System.ComponentModel.DataAnnotations;

namespace PasswordGenerator.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string PublishedDate { get; set; }
        public string Picture { get; set; }
    }
}
