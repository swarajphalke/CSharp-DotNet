using System.ComponentModel.DataAnnotations;

namespace Model_Binding_FromForm.Models
{
    // The FromForm attribute instructs the model binder to fetch the data from the form body of the request and try to bind
    // it to the specified action method parameters or model properties.
    // where you can use from form
    // traditional html form
    // file uploads
    // complex modelbinding with form data
    // inside model folder create a class
    public class Users
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Mobile { get; set; }
    }
}
