using Microsoft.AspNetCore.Mvc;
using PasswordGenerator.Models;
using System.Diagnostics;

namespace PasswordGenerator.Controllers
{
    public class PasswordController : Controller
    {
        private readonly ILogger<PasswordController> _logger;

        public PasswordController(ILogger<PasswordController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult PasswordGenerator()
        {
            return View(new PasswordOptionsModel());
        }

        [HttpPost]
        public IActionResult Generate(PasswordOptionsModel optionsModel)
        {
            if (ModelState.IsValid)
            {
                var password = GeneratePassword(optionsModel);
                ViewBag.Password = password;
                return View("PasswordGenerator", optionsModel);
            }
            return RedirectToAction("Error");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private string GeneratePassword(PasswordOptionsModel optionsModel)
        {
            const string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string lowercase = "abcdefghijklmnopqrstuvwxyz";
            const string numbers = "1234567890";
            const string symbols = "!@#$%^&*()_+[]{}|:;,.<>?";
            string charset = "";

            if (optionsModel.IncludeUppercase) charset += uppercase;
            if (optionsModel.IncludeLowercase) charset += lowercase;
            if (optionsModel.IncludeNumbers) charset += numbers;
            if (optionsModel.IncludeSymbols) charset += symbols;

            var random = new Random();
            var passwordChar = Enumerable.Repeat(charset, optionsModel.PasswordLength)
                .Select(str => str[random.Next(str.Length)])
                .ToArray();

            return new string(passwordChar);
        }
    }
}