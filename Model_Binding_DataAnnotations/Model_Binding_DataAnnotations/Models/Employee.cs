using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model_Binding_DataAnnotations.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [StringLength(10, MinimumLength = 4, ErrorMessage = "Last name should be between 4 and 10 characters")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Email is required")]
        [RegularExpression(@"^([a-z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
            ErrorMessage = "Please enter a valid email address")]
        public string Emailld { get; set; }


        [Required(ErrorMessage = "Age is Required")]
        [Range(18, 60, ErrorMessage = "Age must be between 18 and 60")]
        public int Age { get; set; }

        [MinLength(5, ErrorMessage = "The Address must be at least 5 characters")]
        [MaxLength(25, ErrorMessage = "The Address cannot be more than 25 characters")]
        public string Address { get; set; }

        [DataType(DataType.PostalCode, ErrorMessage = "Please Enter a Valid PIN/ZIP Code")]
        public string PostalCode { get; set; }

        [DataType(DataType.Url, ErrorMessage = "Please Enter a Valid URL")]
        public string WebsiteURL { get; set; }


        [Required(ErrorMessage = "Password is Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.PhoneNumber, ErrorMessage = "Please Enter a Valid Phone Number")]
        public string Mobile { get; set; }



        [Range(10000, 1000000, ErrorMessage = "Please Enter a Value Between 10000 and 1000000")]
        [DataType(DataType.Currency)] // This is for UI hint (e.g., currency symbol), not validation.
        [Column(TypeName = "decimal(18, 2)")] // Used for database schema definition (e.g., for Entity Framework)
        public decimal Salary { get; set; }

        // This is the 'ConfirmPassword' from the second image
        [Required(ErrorMessage = "Confirm Password is Required")]
        [DataType(DataType.Password)] // UI hint
        [Compare("Password", ErrorMessage = "Password and Confirm Password must match")] // Validates against the 'Password' property
        public string ConfirmPassword { get; set; }
    }
}
