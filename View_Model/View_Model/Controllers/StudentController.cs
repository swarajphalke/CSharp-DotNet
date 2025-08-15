using Microsoft.AspNetCore.Mvc;
using View_Model.Models;
using View_Model.StudentModel;
namespace View_Model.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details()
        {

            
            Student s = new Student()
            {
                StudentId = 12,
                Name = "Swaraj",
                Branch = "CSE",
                Gender = "Male"
            };

            Address a = new Address()
            {
                StudentId = 12,
                City = "Pune",
                State = "Maharashtra",
                Pin = "412803",
                Country = "India",
            };

            StudentDetails st = new StudentDetails()
            {
                Std = s,
                Add = a,
                Header = "Students Details",
                Title = "student_pages",
            };
            return View(st);
        }
    }
}
