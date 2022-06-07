using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Stix.Pages
{
    public class FilterModel : PageModel
    {
        [BindProperty]
        public string referenceValue { get; set; }
        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost(string referenceNumber)
        {
            return RedirectToPage("/Index", new {referenceNumber = referenceNumber});    
        }
    }
}
