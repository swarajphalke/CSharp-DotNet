using Microsoft.AspNetCore.Mvc;

namespace Query_String.Controllers
{
    public class StudentController : Controller
    {

        public IActionResult Details(int id, string name)
        {
            // GET: /Student/Details?id=1&name=Aditya
            ViewBag.StudentId = id;
            ViewBag.StudentName = name;
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
