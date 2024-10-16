using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PasswordGenerator.Models;
using PasswordGenerator.Services.Interface;

namespace PasswordGenerator.Controllers
{
    public class CurrencyConverterController : Controller
    {
        private readonly ICurrencyService _currencyService;

        public CurrencyConverterController(ICurrencyService currencyService)
        {
            _currencyService = currencyService;

        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = new CurrencyConverterModel
            {
                Currencies = GetCurrencies() 
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Convert(CurrencyConverterModel model)
        {
            if (ModelState.IsValid)
            {
                var rate = _currencyService.GetExchangeRate(model.SourceCurrency, model.DestinationCurrency);
                model.ConvertedAmount = model.Amount * rate; 
            }

            model.Currencies = GetCurrencies(); 
            return View("Index", model);
        }

        private IEnumerable<SelectListItem> GetCurrencies()
        {
            return new List<SelectListItem>
            {
                new SelectListItem { Value = "USD", Text = "USD" }, 
                new SelectListItem { Value = "EUR", Text = "EUR" },
                new SelectListItem { Value = "BYN", Text = "BYN" },
                new SelectListItem { Value = "RUB", Text = "RUB" },
            };
        }
    }
}
