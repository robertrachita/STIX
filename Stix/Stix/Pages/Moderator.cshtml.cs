using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Stix.Pages
{
    public class Moderator : PageModel
    {
        
        [BindProperty]
        public string incidentName { get; set; } = "Default name";
        [BindProperty]
        public string description { get; set; } = "This section describes the incident";
        [BindProperty]
        public string addedOn { get; set; } = "2022-02-22\n" + "T69:42:00";
        [BindProperty]
        public string viewMore { get; set; } = "";
        [BindProperty]
        public IDictionary<string, string> users { get; set; } = new Dictionary<string, string>() { { "Chris", "12-12-2021" }, { "Joe", "9-11-1996" } };
        public void OnGet()
        {
            
        }

        public void OnPost() 
        { 
            
        }
    }
}