using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razor_Pages_Practice.Pages
{
    public class DisplayModel : PageModel
    {

        public string Name { get; set; }
        public int Count { get; set; }
        public void OnGet()
        {
            Name = "Swaraj";
        }
    }
}

