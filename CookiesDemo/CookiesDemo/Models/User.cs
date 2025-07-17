using System.ComponentModel.DataAnnotations;

namespace CookiesDemo.Models
{
    public class User
    {
        [Required(ErrorMessage ="Username is required")]
        public string Username { get; set; }
    }
}
