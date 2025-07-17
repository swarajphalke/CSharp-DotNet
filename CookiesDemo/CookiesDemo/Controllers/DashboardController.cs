using Microsoft.AspNetCore.Mvc;

namespace CookiesDemo.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            string username = Request.Cookies["username"];  // Read cookie
            ViewBag.Username = username;
            return View();
         }
    }
}
