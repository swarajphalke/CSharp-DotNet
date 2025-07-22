using Microsoft.AspNetCore.Mvc;

namespace Bootstrap_Demo.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
