using System.ComponentModel.DataAnnotations;

namespace PasswordGenerator.Models
{
    public class PasswordOptionsModel
    {
        [Required]
        [Range (4, 20)]
        public int PasswordLength { get; set; }
        public bool IncludeUppercase { get; set; }
        public bool IncludeLowercase { get; set; }
        public bool IncludeNumbers { get; set; }
        public bool IncludeSymbols { get; set; }

    }
}
