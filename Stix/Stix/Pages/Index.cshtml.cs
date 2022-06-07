using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using Stix.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Stix.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public List<IncidentsModel> infos = new List<IncidentsModel>();

        [BindProperty (SupportsGet = true)]
        public string searchString { get; set; }

        public string query = "SELECT * FROM incidents";

        public string referenceNumber { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            this.getIncidents(query);
        }

        public void getIncidents(string query)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }



        /*public void OnGet()
        {
            //string search = Request.Form["search"];
            if (!string.IsNullOrEmpty(searchString))
            {
                this.query = "SELECT * FROM incidents WHERE title LIKE @NAME";
                this.getIncidents(query);
            }
        }*/

        public async Task OnGetAsync()
        {
            if (!string.IsNullOrEmpty(searchString))
            {
                this.query = "SELECT * FROM incidents WHERE title LIKE @NAME";
                this.getIncidents(query);
            }
        }

        public void OnPost() 
        { 
            
        }
    }
}