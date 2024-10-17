using System.ComponentModel.DataAnnotations;

namespace PasswordGenerator.Models
{
    public class BookViewModel
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string PublishedDate { get; set; }
        public string Picture { get; set; }
    }
}
