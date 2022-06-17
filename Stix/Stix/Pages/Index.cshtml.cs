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
            
        }

        [BindProperty(SupportsGet = true)]
        public bool title { get; set; }

        public bool title2 = false;
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
            return RedirectToPage("Filter", new { title = this.title2});
        }
    }
}
