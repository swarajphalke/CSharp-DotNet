using Microsoft.AspNetCore.Mvc;
using Unit_Testing_Demo.Models;

namespace Unit_Testing_Demo.Controllers
{
    public class calculatorController : Controller
    {
        private Icalculator _calculatorService = null;

        public calculatorController(Icalculator calculatorServices)
        {
            _calculatorService = calculatorServices;
        }

        public double Add(double x1, double x2)
        {
            return _calculatorService.Add(x1, x2);
        }
        [HttpPost]

        public double Divide(double x1, double x2)
        {
            return _calculatorService.Divide(x1, x2);
        }
        [HttpPost]

        public double Multiply(double x1, double x2)
        {
            return _calculatorService.Multiply(x1, x2);
        }
        [HttpPost]

        public double Substract(double x1, double x2)
        {
            return _calculatorService.Substract(x1, x2);
        }
    }
}
