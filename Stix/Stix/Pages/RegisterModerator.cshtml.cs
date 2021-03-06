using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Stix.Models;

namespace Stix.Pages
{
    public class RegisterModeratorModel : PageModel
    {
        public void OnGet()
        {
        }

        [BindProperty]
        public ModeratorModel Moderator { get; set; }

        public void onGet()
        {
        }

        public void onPost()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }

            return RedirectToPage("/login/LoginUser");
        }
    }
}
