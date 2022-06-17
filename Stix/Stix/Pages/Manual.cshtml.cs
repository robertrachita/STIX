using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Stix.Models;

namespace Stix.Pages
{
    public class ManualModel : PageModel
    {
        [BindProperty]
        public Incident Incident { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }  

            return RedirectToPage("Index");
        }
    }
}
