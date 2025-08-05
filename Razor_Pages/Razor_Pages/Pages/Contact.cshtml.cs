using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class ContactModel : PageModel
{
    [BindProperty]
    public string Name { get; set; }

    [BindProperty]
    public string Message { get; set; }

    public string Response { get; set; }

    public void OnPost()
    {
        Response = $"Thanks, {Name}! You said: {Message}";
    }
}