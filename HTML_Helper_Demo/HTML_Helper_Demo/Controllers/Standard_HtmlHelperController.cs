using Microsoft.AspNetCore.Mvc;

namespace HTML_Helper_Demo.Controllers
{
    public class Standard_HtmlHelperController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(IFormCollection form)
        {
            ViewBag.Name = form["name"];
            ViewBag.Comment = form["comment"];
            ViewBag.Password = form["password"];
            ViewBag.IsActive = form["isActive"];
            ViewBag.Gender = form["gender"];
            ViewBag.City = form["cityList"];

            return View("Submitted");
        }
    }
}
