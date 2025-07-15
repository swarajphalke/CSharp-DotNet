using Microsoft.AspNetCore.Mvc;
using Tag_Helper.Models;
using Microsoft.AspNetCore.Mvc.Rendering; // <-- This is needed

namespace Tag_Helper.Controllers
{
    public class StudController : Controller
    {
        public IActionResult Index()
        { 
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.AllGenders = Enum.GetValues(typeof(Gender)).Cast<Gender>();
            ViewBag.allBranches = new List<SelectListItem>() {
            new SelectListItem {Text = "None", Value ="1"},
            new SelectListItem {Text = "CSE", Value ="2"},
            new SelectListItem {Text = "ENTC", Value ="3"},
            new SelectListItem {Text = "Mech", Value ="4"}
            };
            return View();
        }
    }
}
