using Microsoft.AspNetCore.Mvc;
using Model_Binding_FromForm.Models;
namespace Model_Binding_FromForm.Controllers
{
    public class UserController : Controller
    {
        // inside controller
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([FromForm] Users user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }
            return RedirectToAction("successful");
        }

        public string successful()
        {
            return "user created sucessfully";
        }
    }
}
