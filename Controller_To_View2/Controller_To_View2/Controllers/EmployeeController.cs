using Microsoft.AspNetCore.Mvc;
using Controller_To_View2.Models;

namespace Controller_To_View2.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult EmployeeData()
        {
            Employee e = new Employee();
            e.Eid = 101;
            e.Ename = "Priyanka";
            e.Salary = 58000;
            e.Dept = "Software Engineer";
            return View(e);
        }
    }
}
