using Microsoft.AspNetCore.Mvc;

namespace Routing_Conventional_Attribute.Controllers
{
    [Route("Practice")]
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("demo")] // → /Practice/demo
        public IActionResult Demo()
        {
            ViewData["message"] = "Welcome to ASP.NET Core!";
            ViewData["Year"] = 2025;
            return View();
        }

        [Route("numbers/{id}")] // → /Practice/numbers/22
        public IActionResult numbers(int id)
        {
            ViewData["id1"] = 1;
            ViewData["id2"] = 2025;
            ViewData["fromUrl"] = id;
            return View();
        }

    }
}
