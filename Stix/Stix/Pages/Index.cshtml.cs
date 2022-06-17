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
        private IncidentController incidentController;

        public List<Incident> incidentList = new List<Incident>();
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;

            this.filters = new FiltersModel();
            this.filters.Title = true;
            this.filters.Description = true;

            this.title = true;
            this.summary = true;
            this.date = true;
            this.additional_info = false;
        }

        // Filter Properties

        [BindProperty(SupportsGet = true)]
        public FiltersModel filters { get; set; }

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
            return RedirectToPage("Filter", new { filters = this.filters, title = this.filters.Title });
        }
    }
}
