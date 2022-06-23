using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Stix.Pages
{
    public class IncidentModel : PageModel
    {
        private readonly ILogger<IncidentModel> _logger;

        public IncidentModel(ILogger<IncidentModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            string dateTime = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss", new CultureInfo("en-NL"));
            ViewData["IncidentName"] = "Example Incident";
            ViewData["IncidentDate"] = dateTime;
            ViewData["IncidentAdded"] = dateTime;
            ViewData["IncidentSource"] = "https://www.definitely-a-valid-source.com/incident";
        }
    }
}