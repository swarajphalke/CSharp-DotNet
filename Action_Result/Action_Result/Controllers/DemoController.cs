using Microsoft.AspNetCore.Mvc;

namespace Action_Result.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Show()
        {
            //return Content("Welcome all..!");
            //return Content("<html> <b> <i> <u>Swaraj Phalke</u> </i> </b> </html>", "text/html");
            return Content("<fullname> <fname>Swaraj</fname> <lname>Phalke</lname> </fullname>", "text/xml");
        }

        public IActionResult Display()
        {
            return Redirect("https://www.google.com");
            //return RedirectToAction("Show");
            //return RedirectToAction("Privacy", "Home");
            //return RedirectToRoute(new {Controller= "Home",action = "Index"});
        }
        public IActionResult Result()
        {
            List<string> li = new List<string>();
            li.Add("Swaraj");
            li.Add("Aditya");
            li.Add("Pranav");
            li.Add("Purvesh");
            li.Add("Mayuresh");
            return Json(li);
        }
        public IActionResult Error()
        {
            //return StatusCode(404);
            return StatusCode(500);
        }
    }
}
