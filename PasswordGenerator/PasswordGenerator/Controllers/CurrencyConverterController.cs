using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.IdentityModel.Tokens;
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
        public IActionResult CurrencyConverter()
        {
            var model = new CurrencyConverterModel
            {
                Currencies = GetCurrencies() 
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Convert(CurrencyConverterModel model)
        {
            if (ModelState.IsValid)
            {
                var rate = await _currencyService.GetExchangeRateAsync(model.SourceCurrency, model.DestinationCurrency);
                if (!rate.errorMessage.IsNullOrEmpty())
                {
                    return BadRequest(rate.errorMessage);
                }
                model.ConvertedAmount = (decimal)(model.Amount * rate.Cur_OfficialRate); 
            }

            model.Currencies = GetCurrencies(); 
            return View("CurrencyConverter", model);
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
