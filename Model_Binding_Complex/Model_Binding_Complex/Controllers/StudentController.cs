using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Reflection;
using Model_Binding_Complex.Models;

namespace Model_Binding_Complex.Controllers
{
    public class StudentController : Controller
    {

        // [HttpGet] for displaying the form
        [HttpGet]
        public ViewResult Create()
        {
            // Populate Gender dropdown data
            ViewBag.AllGenders = Enum.GetValues(typeof(Gender))
                                     .Cast<Gender>()
                                     .Select(g => new SelectListItem { Text = g.ToString(), Value = g.ToString() }) // Convert Enum to SelectListItem
                                     .ToList();

            // Populate Branch dropdown data
            ViewBag.AllBranches = new List<SelectListItem>()
        {
            new SelectListItem { Text = "None", Value = "None" }, // Value should match enum name
            new SelectListItem { Text = "CSE", Value = "CS" },    // Value should match enum name
            new SelectListItem { Text = "ETC", Value = "Entc" },  // Value should match enum name
            new SelectListItem { Text = "Mech", Value = "Mech" } // Value should match enum name
        };

            return View(); // Display the form
        }

        // [HttpPost] for handling form submission
        [HttpPost]
        public IActionResult Create(Student std) // The submitted form data binds to a Student object
        {
            if (ModelState.IsValid)
            {

                return RedirectToAction("Successful");
            }
            else
            {

                ViewBag.AllGenders = Enum.GetValues(typeof(Gender))
                                         .Cast<Gender>()
                                         .Select(g => new SelectListItem { Text = g.ToString(), Value = g.ToString() })
                                         .ToList();

                ViewBag.AllBranches = new List<SelectListItem>()
            {
                new SelectListItem { Text = "None", Value = "None" },
                new SelectListItem { Text = "CSE", Value = "CS" },
                new SelectListItem { Text = "ETC", Value = "Entc" },
                new SelectListItem { Text = "Mech", Value = "Mech" }
            };

                // Return the view with the 'std' object, so pre-filled data and validation errors are shown.
                return View(std);
            }
        }

        // Action for success message
        public string Successful()
        {
            return "Student Created Successfully";
        }
    }
}

