using Microsoft.AspNetCore.Mvc;

namespace Model_MVC.Models
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public int Display()
        {
            Test d = new Test();
            int a = d.Sum(12, 12);
            return a;
        }
        public string xyz()
        {
            Test d1 = new Test();
            string Messs = d1.Mess("Hiii wellcome to profound edutech pvt ltd");
            return Messs;
        }
        public IActionResult Message()
        {
            Test d2 = new Test();
            d2.Mess("Hiii wellcome to profound edutech pvt ltd");

            return View(d2);
        }
    }
}
