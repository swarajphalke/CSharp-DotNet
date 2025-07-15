using Microsoft.AspNetCore.Mvc;

namespace Cookie_Demo.Controllers
{
    public class DemoController : Controller
    {
        public string Cookieuname;
        public string Cookieuid;
         
        public IActionResult Create()
        {
            CookieOptions options = new CookieOptions();
            Response.Cookies.Append("Cookieuname", "SwarajPhalke");
            Response.Cookies.Append("Cookieuid", "12345");
            return View();
        }
        public string Read()
        {
            string uid = "Id: " + Request.Cookies["Cookieuid"].ToString();
            string uname = "\nUsername: " + Request.Cookies["Cookieuname"].ToString();
            return uid + uname;
        }

        public string Delete()
        {
            Response.Cookies.Delete("Cookieuid");
            Response.Cookies.Delete("Cookieuname");
            return ("Cookie Deleted Successfully...!");
        }


    }
}
