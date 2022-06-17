using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Stix.Models;
using MongoDB.Driver;
using MongoDB.Bson;
namespace Stix.Pages
{
    public class FilterModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public IDictionary<string, bool> filtering { get; set; }

        [BindProperty (SupportsGet = true)]
        public FiltersModel filters { get; set; }

        [BindProperty (SupportsGet = true)]
        public bool title { get; set; }

        [BindProperty(SupportsGet = true)]
        public bool summary { get; set; }

        [BindProperty(SupportsGet = true)]
        public bool date { get; set; }

        [BindProperty(SupportsGet = true)]
        public bool affected_system { get; set; }

        [BindProperty(SupportsGet = true)]
        public bool method { get; set; }

        [BindProperty(SupportsGet = true)]
        public bool impact_area { get; set; }

        [BindProperty(SupportsGet = true)]
        public bool victim_location { get; set; }

        [BindProperty(SupportsGet = true)]
        public bool identity { get; set; }

        [BindProperty(SupportsGet = true)]
        public bool victim_type { get; set; }

        [BindProperty(SupportsGet = true)]
        public bool malware_type { get; set; }

        [BindProperty(SupportsGet = true)]
        public bool ransomware_type { get; set; }

        [BindProperty(SupportsGet = true)]
        public bool attack_pattern { get; set; }

        [BindProperty(SupportsGet = true)]
        public bool campaign { get; set; }

        [BindProperty(SupportsGet = true)]
        public bool impact { get; set; }

        [BindProperty(SupportsGet = true)]
        public bool threat_actor { get; set; }

        [BindProperty(SupportsGet = true)]
        public bool additional_info { get; set; }

        [HttpGet]
        public async void OnGet(FiltersModel filters, bool title)
        {
            this.filters = filters;
            this.filters.Title = title;
        }

        [HttpPost]
        public async Task<IActionResult> OnPostAsync()
        {
            return RedirectToPage("Index", new { title = this.title, summary = this.summary, date = this.date, additonal_info = this.additional_info });
        }

    }
}
