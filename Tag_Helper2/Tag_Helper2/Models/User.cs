using System.ComponentModel.DataAnnotations;

namespace Tag_Helper2.Models
{
    public class User
    {

        [Required] // Field is required
        public string Name { get; set; }

        [Required] // Required and must be valid email format
        [EmailAddress]
        public string Email { get; set; }

        [Required] // Required and should be a password
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Range(18, 60)] // Must be between 18 and 60
        public int Age { get; set; }

        public string Gender { get; set; }

        public string Bio { get; set; }

        public bool AcceptTerms { get; set; } // Checkbox
    }
}
