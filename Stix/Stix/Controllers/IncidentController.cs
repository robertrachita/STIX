using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Stix.Models;

namespace Stix.Controllers
{
    public class IncidentController : Controller
    {
        //private static readonly Uri conn = new Uri("https://10.0.2.2:56552/api/incident/");
        private static readonly String conn = "https://stix-test.herokuapp.com/api/Incident/GetAllIncidents.json";
        
 
        public static async Task<JsonResult> Index()
        {
            List<Incident> incidents = new List<Incident>();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(conn))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    incidents = JsonConvert.DeserializeObject<List<Incident>>(apiResponse);
                }
            }

            return new JsonResult(incidents);
        }
    }
}
