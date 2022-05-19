using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Stix.Pages
{
    public class ImportModel : PageModel
    {
        [BindProperty]
        public IFormFile ExcelFile { get; set; }
        public void OnGet()
        {
        }
    }
}
