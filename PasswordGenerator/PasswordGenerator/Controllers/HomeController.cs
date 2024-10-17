using Microsoft.AspNetCore.Mvc;
using PasswordGenerator.Models;
using System.Diagnostics;

namespace PasswordGenerator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GoToPasswordGenerator()
        {
            return RedirectToAction("PasswordGenerator", "Password");
        } 

        [HttpGet]
        public IActionResult GoToCurrencyConverter()
        {
            return RedirectToAction("CurrencyConverter", "CurrencyConverter");
        }

        [HttpGet]
        public IActionResult GoToBookFinder()
        {
            return RedirectToAction("BookFinder", "Book");
        }

        [HttpGet]
        public IActionResult GoToCalculator()
        {
            return RedirectToAction("Calculator", "Calculator");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}