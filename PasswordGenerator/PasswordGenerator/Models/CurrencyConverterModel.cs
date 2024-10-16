using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace PasswordGenerator.Models
{
    public class CurrencyConverterModel
    {
        [Required(ErrorMessage = "Amount is required.")]
        [Range(0, 999999999, ErrorMessage = "Amount must be between 0 and 999999999.")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "Source currency is required.")]
        public string SourceCurrency { get; set; }

        [Required(ErrorMessage = "Destination currency is required.")]
        public string DestinationCurrency { get; set; }

        public decimal ConvertedAmount { get; set; }
		
        public IEnumerable<SelectListItem> Currencies { get; set; } = Enumerable.Empty<SelectListItem>();
    }
}
