using Microsoft.AspNetCore.Mvc;
using Model_Binding_DataAnnotations.Models;

namespace Model_Binding_DataAnnotations.Controllers
{
    public class EmployeeController : Controller
    {

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Employee emp)
        {

            if (ModelState.IsValid)
            {

                return RedirectToAction("Success");
            }
            else
            {

                return View(emp);
            }
        }


        public string Success()
        {
            return "User created successfully";
        }
    }
}
