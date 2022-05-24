using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Stix.Models;

namespace Stix.Pages
{
    public class IncidentModel : PageModel
    {
        [BindProperty]
        public IncidentInfoModel Incident { get; set; }

        private readonly ILogger<IncidentModel> _logger;

        public IncidentModel(ILogger<IncidentModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            string dateTime = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss", new CultureInfo("en-NL"));
            /* {TO DO}: Uncomment this when API is implemented */
            //ViewData["IncidentName"] = Incident.Name;
            //ViewData["IncidentDate"] = Incident.Date;
            //ViewData["IncidentAdded"] = Incident.AddedDate;
            //ViewData["IncidentSource"] = Incident.Source;
            ViewData["IncidentName"] = "Example Incident";
            ViewData["IncidentDate"] = dateTime;
            ViewData["IncidentAdded"] = dateTime;
            ViewData["IncidentSource"] = "https://www.definitely-a-valid-source.com/incident";
        }
    }
}