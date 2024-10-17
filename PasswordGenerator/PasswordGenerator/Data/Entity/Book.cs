using System.ComponentModel.DataAnnotations;

namespace PasswordGenerator.Data.Entity
{
    public class Book : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string PublishedDate { get; set; }
        public string Picture { get; set; }
    }
}
