using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Stix.Models;
using MongoDB.Driver;
using MongoDB.Bson;

namespace Stix.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private MongoClient _client;

        // Incidents fields
        public List<IncidentsModel> infos = new List<IncidentsModel>();

        // Search function fields
        [BindProperty (SupportsGet = true)]
        public string searchString { get; set; }

        // Filter function fields
        public List<FiltersModel> _filters = new List<FiltersModel>();

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            _client = new MongoClient("mongodb://localhost:27017");
            this.getFilter();
            this.getIncidents();
            /*            foreach(var item in infos)
                        {
                            Console.WriteLine($"{item.Name}: {item.Description}");
                        }*/
        }

        public async void getIncidents()
        {
            try
            {
                IMongoDatabase database = _client.GetDatabase("Stix");
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

        public async void getFilter()
        {
            try
            {
                IMongoDatabase database = _client.GetDatabase("Stix");
                IMongoCollection<FiltersModel> collection = database.GetCollection<FiltersModel>("Filters");
                var results = collection.Find(new BsonDocument());
                this._filters = results.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }

        /*
         * There are 4 ways to do this: MQL, BsonDocument, Builder, and LINQ & Mapping Classes
         */
        [HttpGet]
        public async Task OnGetAsync()
        {
            if (string.IsNullOrEmpty(searchString))
            {
                return;
            }
            IMongoDatabase database = _client.GetDatabase("Stix");
            var collection = database.GetCollection<IncidentsModel>("Incidents");
            var filter = Builders<IncidentsModel>.Filter.Eq("title", "Germany");
        }

    }
}