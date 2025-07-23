using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Model_Binding_FormQuery.Models;

namespace Model_Binding_FormQuery.Controllers
{
    public class HomeController : Controller
    {
        private List<User> _users;

        public HomeController()
        {
            _users = new List<User>()
        {
            new User() { Id = 1, Name = "Pranaya", Age = 35 },
            new User() { Id = 2, Name = "Priyanka", Age = 30 },
            new User() { Id = 3, Name = "Anurag", Age = 35 },
            new User() { Id = 4, Name = "Prateek", Age = 30 },
            new User() { Id = 5, Name = "Hina", Age = 35 }
        };
        }

        public IActionResult Search([FromQuery] UserCriteria cri)
        {
            List<User> li = new List<User>();

            if (cri != null)
            {
                if (cri.Name.Length > 6 && cri.Age >= 20)
                {
                    li = _users;
                }
            }

            return Ok(li);
        }
    }
}
