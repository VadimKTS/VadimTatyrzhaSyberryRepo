using Microsoft.AspNetCore.Mvc.Rendering;

namespace PasswordGenerator.Models
{
    public class CurrencyConverterModel
    {
        public decimal Amount { get; set; }
        public string SourceCurrency { get; set; }
        public string DestinationCurrency { get; set; }
        public decimal ConvertedAmount { get; set; }
        public IEnumerable<SelectListItem> Currencies { get; set; } = Enumerable.Empty<SelectListItem>();
    }
}
