using Microsoft.AspNetCore.Mvc;
using Model_Binding_Demo.Models;

namespace Model_Binding_Demo.Controllers
{
    public class ModelBindingController : Controller
    {
        //1. Binding Simple Types (int, string, etc.)

        public IActionResult Index(int id, string name)
        {
            return Content($"ID: {id}, Name: {name}");
        }

        //2. Binding Complex Types (Model)
        //Get
        public IActionResult Save()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save(Student student)
        {
            return Content($"ID: {student.Id}, Name: {student.Name}");
        }

        //3. Binding from Query String
        public IActionResult Search([FromQuery] string keyword)
        {
            return Content("Searched for: " + keyword);
        }

        //4. Binding from Route
        [Route("student/details/{id}")]
        public IActionResult Details([FromRoute] int id)
        {
            return Content("Student ID = " + id);
        }

        //5. Binding from Form (POST Request)
        public IActionResult Submit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Submit([FromForm] string email)
        {
            return Content("Email = " + email);
        }


    }
}

