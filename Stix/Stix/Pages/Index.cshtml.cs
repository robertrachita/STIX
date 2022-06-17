using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Stix.Controllers;
using System.Text.Json;
using Newtonsoft.Json;
using Stix.Models;
using Newtonsoft.Json.Linq;

namespace Stix.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public List<Incident> incidentList = new List<Incident>();

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;

            this.title = true;
            this.date = true;
            this.additional_info = false;
            this.impact_area = false;
            this.impact = false;
            this.victim_country = false;
            this.victim_location = false;
            this.identity = false;
            this.victim_type = false;
            this.affected_system = false;
            this.method = false;
            this.malware_type = false;
            this.ransomware_type = false;
            this.attack_pattern = true;
            this.campaign = false;
            this.impact = false;
            this.summary = false;
            this.reference_short = false;
            this.reference_long = false;
        }
        // Filter Properties
        [BindProperty(SupportsGet = true)]
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
        public bool victim_country { get; set; }

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
        public bool threat_actor_country { get; set; }

        [BindProperty(SupportsGet = true)]
        public bool additional_info { get; set; }

        [BindProperty(SupportsGet = true)]
        public bool reference_short { get; set; }

        [BindProperty(SupportsGet = true)]
        public bool reference_long { get; set; }
        public async Task OnGetAsync()
        {
            await OnGetIncidentsAsync();
        }

        public async Task<ActionResult> OnGetIncidentsAsync()
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    using (HttpResponseMessage response = await httpClient.GetAsync("https://stix-test.herokuapp.com/api/Incident/GetAllIncidents.json/"))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        this.incidentList = JsonConvert.DeserializeObject<List<Incident>>(apiResponse).ToList();
                        foreach (var item in this.incidentList)
                        {
                            return Page();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return RedirectToPage("Login");
        }

        [HttpPost]
        public async Task<IActionResult> OnPost()
        {
            return RedirectToPage("Filter", new
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
                malware_type = this.malware_type,
                ransomware_type = this.ransomware_type,
                method = this.method,
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
