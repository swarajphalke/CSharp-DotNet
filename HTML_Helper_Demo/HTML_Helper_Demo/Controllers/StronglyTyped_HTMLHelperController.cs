using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using HTML_Helper_Demo.Models;
namespace HTML_Helper_Demo.Controllers
{
    public class StronglyTyped_HTMLHelperController : Controller
    {
        public IActionResult Index()
        {
            // Fill City Dropdown using ViewBag
            ViewBag.Cities = new SelectList(new List<string> { "Satara", "Pune", "Mumbai" });

            return View(new Student()); // send empty model to view
        }

        [HttpPost]
        public IActionResult Submit(Student student)
        {
            // Student object automatically filled from form
            return View(student); // return same data to next view
        }
    }
}
