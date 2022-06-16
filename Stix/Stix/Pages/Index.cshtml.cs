using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Stix.Controllers;
using System.Text.Json;
using Newtonsoft.Json;
using Stix.Models;

namespace Stix.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private IncidentController incidentController;
        [BindProperty]
        public dynamic incidentList { get; set; }

        public IndexModel(ILogger<IndexModel> logger)   
        {
            _logger = logger;
            incidentController = new IncidentController();
            //GetIncidents();
            //OnGetIncidentsAsync();
            Test();
        }
        
        [BindProperty]
        public string incidentName { get; set; } = "Default name";
        [BindProperty]
        public string description { get; set; } = "This section describes the incident";
        [BindProperty]
        public string addedOn { get; set; } = "2022-02-22\n" +
            "T69:42:00";
        

        public void OnGet()
        {
        }

        public void OnPost() 
        { 
            
        }

        public async Task<JsonResult> OnGetIncidentsAsync()
        {
            List<IncidentModel> incidents = new List<IncidentModel>();
            using (var httpClient = new HttpClient())
            {
                using (HttpResponseMessage response = await httpClient.GetAsync("https://stix-test.herokuapp.com/api/Incident/GetAllIncidents.json/"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    //incidents = JsonSerializer.Deserialize<List<IncidentModel>>(apiResponse);
                    incidents = JsonConvert.DeserializeObject<List<IncidentModel>>(apiResponse);
                }
            }
            return new JsonResult(incidents);
        }
        
        public void Test()
        {
            //string json = "[{\"id\":\"62a9f8f90346133662624bd3\",\"referenceID\":\"test1\",\"month\":\"string\",\"pending\":true,\"year\":\"string\",\"title\":\"string\",\"impactArea\":\"string\",\"victimLocation\":\"string\",\"victimCountry\":\"string\",\"identity\":\"string\",\"victimType\":\"string\",\"affectedSystem\":\"string\",\"method\":\"string\",\"malwareType\":\"string\",\"ransomwareType\":\"string\",\"attackPattern\":\"string\",\"campaign\":\"string\",\"impact\":\"string\",\"threatActorCountry\":\"string\",\"threatActor\":\"string\",\"additionalInfo\":\"string\",\"summary\":\"string\",\"referenceShort\":[\"string\"],\"references\":[\"string\"],\"additionalInfoList\":[\"string\"]},{\"id\":\"62a9fba50346133662624bd4\",\"referenceID\":\"111\",\"month\":\"string\",\"pending\":true,\"year\":\"string\",\"title\":\"test2\",\"impactArea\":\"string\",\"victimLocation\":\"string\",\"victimCountry\":\"string\",\"identity\":\"string\",\"victimType\":\"string\",\"affectedSystem\":\"string\",\"method\":\"string\",\"malwareType\":\"string\",\"ransomwareType\":\"string\",\"attackPattern\":\"string\",\"campaign\":\"string\",\"impact\":\"string\",\"threatActorCountry\":\"string\",\"threatActor\":\"string\",\"additionalInfo\":\"string\",\"summary\":\"string\",\"referenceShort\":[\"string\"],\"references\":[\"string\"],\"additionalInfoList\":[\"string\"]}]";
            //tring json = "[{'id':'62a9f8f90346133662624bd3','referenceID':'test1','month':'string','pending':true,'year':'string','title':'string','impactArea':'string','victimLocation':'string','victimCountry':'string','identity':'string','victimType':'string','affectedSystem':'string','method':'string','malwareType':'string','ransomwareType':'string','attackPattern':'string','campaign':'string','impact':'string','threatActorCountry':'string','threatActor':'string','additionalInfo':'string','summary':'string','referenceShort':['string'],'references':['string'],'additionalInfoList':['string']},{'id':'62a9fba50346133662624bd4','referenceID':'111','month':'string','pending':true,'year':'string','title':'test2','impactArea':'string','victimLocation':'string','victimCountry':'string','identity':'string','victimType':'string','affectedSystem':'string','method':'string','malwareType':'string','ransomwareType':'string','attackPattern':'string','campaign':'string','impact':'string','threatActorCountry':'string','threatActor':'string','additionalInfo':'string','summary':'string','referenceShort':['string'],'references':['string'],'additionalInfoList':['string']}]";
            //string json = "[{\"id\":\"62a9f8f90346133662624bd3\",\"referenceID\":\"test1\",\"additionalInfoList\":[\"string\"]},{\"id\":\"62a9fba50346133662624bd4\",\"referenceID\":\"111\",\"additionalInfoList\":[\"string\"]}]";
            //List<IncidentModel> incidents = new List<IncidentModel>();
            //incidents = JsonConvert.DeserializeObject<List<IncidentModel>>(json);

            string json = @"[{
                    'Email': 'james@example.com',
                    'Active': true,
                    'CreatedDate': '2013-01-20T00:00:00Z',
                    'Roles': [
                        'User',
                        'Admin'
                            ]       
                    },
                    {
                    'Email': 'test@test2.com',
                    'Active': true,
                    'CreatedDate': '2013-01-20T00:00:00Z',
                    'Roles': [
                    'User',
                    'Admin'
                    ]       
                    }]";
            List<Account> accounts = new List<Account>();
            accounts = JsonConvert.DeserializeObject<List<Account>>(json);
        }

    }
}