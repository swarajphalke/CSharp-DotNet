using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

public class IndexModel : PageModel
{
    [BindProperty]
    [Required]
    public string Name { get; set; }

    [BindProperty]
    [Required, EmailAddress]
    public string Email { get; set; }

    [BindProperty]
    [Required, Phone]
    public string Phone { get; set; }

    [BindProperty]
    [Required]
    public string Gender { get; set; }

    [BindProperty]
    [Required, DataType(DataType.Date)]
    public DateTime DOB { get; set; }

    [BindProperty]
    [Required]
    public string Address { get; set; }

    [BindProperty]
    [Required]
    public string City { get; set; }

    [BindProperty]
    [Required, MinLength(6)]
    public string Password { get; set; }

    [BindProperty]
    [Compare("Password", ErrorMessage = "Passwords do not match.")]
    public string ConfirmPassword { get; set; }

    public void OnPost()
    {
        if (!ModelState.IsValid)
        {
            return;
        }

        // Process form (save data, etc.)
    }
}
