using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using Stix.Models;
using MongoDB.Driver;
using Microsoft.AspNetCore.Mvc.Rendering;
using MongoDB.Bson;

namespace Stix.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public List<IncidentsModel> infos = new List<IncidentsModel>();

        [BindProperty (SupportsGet = true)]
        public string searchString { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            this.getIncidents();
        }

        public async void getIncidents()
        {
            try
            {
                MongoClient dbClient = new MongoClient("mongodb://localhost:27017");
                IMongoDatabase database = dbClient.GetDatabase("Stix");
                IMongoCollection<IncidentsModel> collection = database.GetCollection<IncidentsModel>("Incidents");
                //var results = await collection.FindAsync(_ => true); 
                var results = collection.Find(new BsonDocument());
                this.infos = results.ToList();
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

        }

        public void OnPost() 
        { 
            
        }
    }
}