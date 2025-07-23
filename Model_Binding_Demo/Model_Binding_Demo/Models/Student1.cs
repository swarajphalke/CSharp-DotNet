using System.ComponentModel.DataAnnotations;

namespace Model_Binding_Demo.Models
{
    public class Student1
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Range(1, 100, ErrorMessage = "Age must be between 1 and 100")]
        public int Age { get; set; }

        [EmailAddress(ErrorMessage = "Enter a valid email")]
        public string Email { get; set; }
    }
}
