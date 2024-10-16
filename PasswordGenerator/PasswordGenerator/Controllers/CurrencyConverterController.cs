using Microsoft.AspNetCore.Mvc;
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


    }
}
