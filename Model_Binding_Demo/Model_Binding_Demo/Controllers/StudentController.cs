using Microsoft.AspNetCore.Mvc;
using Model_Binding_Demo.Models;
namespace Model_Binding_Demo.Controllers
{
        public class StudentController : Controller
        {
            // Show the form (GET)
            public IActionResult Create()
            {
                return View();
            }

            // Receive form data (POST)
            [HttpPost]
            public IActionResult Create(Student1 student)
            {
                if (ModelState.IsValid)
                {
                    // Return a simple result for demo
                    return Content($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}, Email: {student.Email}");
                }

                // If validation fails, return form with validation messages
                return View(student);
            }
        }
    }

