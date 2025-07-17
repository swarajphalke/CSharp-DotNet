using Microsoft.AspNetCore.Mvc;

namespace SessionDemo.Controllers
{
    public class SessionController : Controller
    {
        // GET: Show login form
        public IActionResult Index()
        {
            return View();
        }

        // POST: Handle form, store in session
        [HttpPost]
        public IActionResult Index(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                HttpContext.Session.SetString("username", name);
                return RedirectToAction("Welcome");
            }

            ViewBag.Message = "Please enter a valid name.";
            return View();
        }

        // GET: Display welcome page
        public IActionResult Welcome()
        {
            string? name = HttpContext.Session.GetString("username");

            if (name == null)
                return RedirectToAction("Index");

            ViewBag.UserName = name;
            return View();
        }

        // GET: Logout
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View();
        }

    }
}
