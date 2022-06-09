using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Stix.Controllers;

namespace Stix.Pages
{
    public class LandingModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private IncidentController incidentController;
        public dynamic incidentList;

        public IndexModel(ILogger<IndexModel> logger)   
        {
            _logger = logger;
            incidentController = new IncidentController();
            GetIncidents();
        }

        [BindProperty]
        public string incidentName { get; set; } = "Default name";
        [BindProperty]
        public string description { get; set; } = "This section describes the incident";
        [BindProperty]
        public string addedOn { get; set; } = "2022-02-22\n" +
            "T69:42:00";
        [BindProperty]
        public string viewMore { get; set; } = "";

        public void OnGet()
        {
        }

        public void OnPost()
        {

        }
        
        public async void GetIncidents()
        {
            this.incidentList = await IncidentController.Index();
            //return 
        }

    }
}
