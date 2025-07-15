using Microsoft.AspNetCore.Mvc;
using Tag_Helper2.Models;

namespace Tag_Helper2.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Register()
        {
            return View(); // Loads the Register.cshtml view
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                // If valid, redirect to Success page
                return RedirectToAction("Success");
            }

            // Otherwise show form again with validation errors
            return View(user);
        }

        public IActionResult Success()
        {
            return Content("Registration Successful!");
        }
    }
}
