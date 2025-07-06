using Microsoft.AspNetCore.Mvc;

namespace MVC_Demo.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public int Number()
        {
            return 2 + 5;
        }

        public string Greet()
        {
            return "Welcom to my world..!";
        }

        public bool Result()
        {
            return true;
        }
    }
}
