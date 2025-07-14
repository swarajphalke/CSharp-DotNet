using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razor_Pages_Practice.Pages
{
    public class CountModel : PageModel
    {
        public int Count { get; set; }

        public void OnGet()
        {
            Count = 0; // Initial value
        }

        public void OnPost()
        {
            // Maintain count using TempData or hidden field; simplified version resets each time
            if (Request.HasFormContentType && int.TryParse(Request.Form["count"], out int currentCount))
            {
                Count = currentCount + 1;
            }
            else
            {
                Count = 1;
            }
        }
    }
}

