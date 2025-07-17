using System.Diagnostics;
using CookiesDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CookiesDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(User u)
        {
            if (ModelState.IsValid)
            {
                Response.Cookies.Append("username", u.Username, new CookieOptions
                {
                    Expires = DateTimeOffset.UtcNow.AddMinutes(1)
                });
             }
            return RedirectToAction("Index","Dashboard");
        }
    }
}
