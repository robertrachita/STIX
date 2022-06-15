using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Stix.Controllers;
using System.Text.Json;
using Newtonsoft.Json;

namespace Stix.Pages
{
    public class LandingModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private IncidentController incidentController;
        [BindProperty]
        public dynamic incidentList { get; set; }

        public IndexModel(ILogger<IndexModel> logger)   
        {
            _logger = logger;
            incidentController = new IncidentController();
            //GetIncidents();
            OnGetIncidentsAsync();            
        }

        [BindProperty]
        public string incidentName { get; set; } = "Default name";
        [BindProperty]
        public string description { get; set; } = "This section describes the incident";
        [BindProperty]
        public string addedOn { get; set; } = "2022-02-22\n" +
            "T69:42:00";
        

        public void OnGet()
        {
        }

        public void OnPost()
        {

        }

        public async Task<JsonResult> OnGetIncidentsAsync()
        {
            List<IncidentModel> incidents = new List<IncidentModel>();
            using (var httpClient = new HttpClient())
            {
                using (HttpResponseMessage response = await httpClient.GetAsync("https://stix-test.herokuapp.com/api/Incident/GetAllIncidents.json/"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    //incidents = JsonSerializer.Deserialize<List<IncidentModel>>(apiResponse);
                    incidents = JsonConvert.DeserializeObject<List<IncidentModel>>(apiResponse);
                }
            }
            return new JsonResult(incidents);
        }
        
    }
}
