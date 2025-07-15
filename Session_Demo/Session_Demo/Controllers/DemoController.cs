using Microsoft.AspNetCore.Mvc;

namespace Session_Demo.Controllers
{
    public class DemoController : Controller
    {
        public string SessionUserName;
        public string SessionUserId;

        //public IActionResult Index()
        //{
        //    return View();
        //}
        public IActionResult Index()
        {
            HttpContext.Session.SetString("SessionUserName", "SwarajPhalke");
            HttpContext.Session.SetInt32("SessionUserId", 1234567 );

            return View();
        }
        public string Read()
        {
            //Accessing the Session Data inside a Method
            string? UserName = HttpContext.Session.GetString("SessionUserName");
            int? UserId = HttpContext.Session.GetInt32("SessionUserId");
            string Message = $"UserName: {UserName}, UserId: {UserId}";
            return Message;
        }
    }
}
