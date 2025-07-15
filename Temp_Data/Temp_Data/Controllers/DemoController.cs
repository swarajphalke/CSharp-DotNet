using Microsoft.AspNetCore.Mvc;

namespace Temp_Data.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            TempData["data"] = "Welcome to all";
            TempData.Keep();
            return View();
        }

        public IActionResult Show()
        {
           string s1 = (string) TempData["data"];
            TempData.Keep();
            return View();
        }

        public IActionResult Error()
        {
            string s2 = (string)TempData["data"];
            return View();
        }
    }
}
