using System.ComponentModel.DataAnnotations;

namespace PasswordGenerator.Models
{
    public class PasswordOptionsModel
    {
        [Required]
        [MinLength(4)]
        [MaxLength(20)]
        public int PasswordLength { get; set; }
        public bool IncludeUppercaseLetters { get; set; }
        public bool IncludeLowercaseLetters { get; set; }
        public bool IncludeNumbers { get; set; }
        public bool IncludeSymbols { get; set; }

    }
}
