using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Stix.Models;
using MongoDB.Driver;
using MongoDB.Bson;
namespace Stix.Pages
{
    public class FilterModel : PageModel
    {

        [BindProperty]
        public List<bool> AreChecked { get; set; }

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
        public bool victim_country { get; set; }

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
        public bool threat_actor_country { get; set; }

        [BindProperty(SupportsGet = true)]
        public bool additional_info { get; set; }

        [BindProperty(SupportsGet = true)]
        public bool reference_short { get; set; }

        [BindProperty(SupportsGet = true)]
        public bool reference_long { get; set; }

        [HttpPost]
        public async Task<IActionResult> OnPostAsync()
        {
            return RedirectToPage("Index", new
            {
                title = this.title,
                summary = this.summary,
                date = this.date,
                impact_area = this.impact_area,
                impact = this.impact,
                victim_location = this.victim_location,
                victim_country = this.victim_country,
                victim_type = this.victim_type,
                identity = this.identity,
                affected_system = this.affected_system,
                method = this.method,
                malware_type = this.malware_type,
                ransomware_type = this.ransomware_type,
                attack_pattern = this.attack_pattern,
                campaign = this.campaign,
                threat_actor = this.threat_actor,
                threat_actor_country = this.threat_actor_country,
                additional_info = this.additional_info,
                reference_short = this.reference_short,
                reference_long = this.reference_long
            });
        }

    }
}
