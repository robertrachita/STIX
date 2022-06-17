using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Stix.Models;
using MongoDB.Driver;
using MongoDB.Bson;
namespace Stix.Pages
{
    public class FilterModel : PageModel
    {
        public List<FiltersModel> _filters = new List<FiltersModel>();

        [BindProperty (SupportsGet = true)]
        public bool title { get; set; }

        [HttpPost]
        public async Task<IActionResult> OnPostAsync()
        {
            return RedirectToPage("Index", new { title = this.title });
        }

    }
}
