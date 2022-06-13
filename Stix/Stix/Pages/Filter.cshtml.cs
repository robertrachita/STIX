using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Stix.Models;
using MongoDB.Driver;
using MongoDB.Bson;
namespace Stix.Pages
{
    public class FilterModel : PageModel
    {
        public List<FiltersModel> _filters = new List<FiltersModel>();

        [BindProperty (SupportsGet = true)]
        public bool title { get; set; }

        [BindProperty (SupportsGet = true)]
        public bool description { get; set; }

        [BindProperty (SupportsGet = true)]
        public bool date { get; set; }
        public async void OnGetAsync() 
        {
            try
            {
                MongoClient dbClient = new MongoClient("mongodb://localhost:27017");
                IMongoDatabase database = dbClient.GetDatabase("Stix");
                IMongoCollection<FiltersModel> collection = database.GetCollection<FiltersModel>("Filters");
                var results = collection.Find(new BsonDocument());
                this._filters = results.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }

        [HttpPost]
        public async Task<IActionResult> OnPost()
        {
            try
            {
                MongoClient dbClient = new MongoClient("mongodb://localhost:27017");
                IMongoDatabase database = dbClient.GetDatabase("Stix");
                IMongoCollection<FiltersModel> collection = database.GetCollection<FiltersModel>("Filters");
                var filter = Builders<FiltersModel>.Filter.Eq("_id", "62a6e2451819b1a2a1f723a1");
                var update = Builders<FiltersModel>.Update.Set("title", title).Set("description", description).Set("date", date);
                collection.UpdateOne(filter, update);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
            return RedirectToPage("./Index");
        }

    }
}
