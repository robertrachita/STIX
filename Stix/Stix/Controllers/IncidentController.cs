using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Stix.Models;

namespace Stix.Controllers
{
    public class IncidentController : Controller
    {
        private static readonly String conn = "https://localhost:60383/api/incident/";
 
        public static async Task<JsonResult> Index()
        {
            List<IncidentModel> incidents = new List<IncidentModel>();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(conn))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    incidents = JsonConvert.DeserializeObject<List<IncidentModel>>(apiResponse);
                }
            }

            return new JsonResult(incidents);
        }
    }
}
