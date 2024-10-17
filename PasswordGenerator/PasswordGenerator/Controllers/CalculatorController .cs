using Microsoft.AspNetCore.Mvc;
using PasswordGenerator.Models;
using System.Diagnostics;

namespace PasswordGenerator.Controllers
{
    public class CalculatorController : Controller
    {
        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Calculator()
        {
            return View(new CalculatorModel());
        }

        [HttpPost]
        public IActionResult Calculate(CalculatorModel calculatorModel)
        {
            try
            {
                switch (calculatorModel.Operation)
                {
                    case "Add":
                        calculatorModel.Result = calculatorModel.Number1 + calculatorModel.Number2;
                        break;
                    case "Subtract":
                        calculatorModel.Result = calculatorModel.Number1 - calculatorModel.Number2;
                        break;
                    case "Multiply":
                        calculatorModel.Result = calculatorModel.Number1 * calculatorModel.Number2;
                        break;
                    case "Divide":
                        if (calculatorModel.Number2 != 0)
                        {
                            calculatorModel.Result = calculatorModel.Number1 / calculatorModel.Number2;
                        }
                        else
                        {
                            calculatorModel.Error = "Division by zero is not allowed.";
                        }
                        break;
                    case "Power":
                        calculatorModel.Result = Math.Pow(calculatorModel.Number1, calculatorModel.Number2);
                        break;
                    case "SquareRoot":
                        calculatorModel.Result = Math.Sqrt(calculatorModel.Number1);
                        break;
                    default:
                        calculatorModel.Error = "Invalid operation.";
                        break;
                }

            }
            catch (Exception ex)
            {
                calculatorModel.Error = ex.Message;
            }
            return View("Calculator", calculatorModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}