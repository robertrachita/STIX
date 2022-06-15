using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stix.Models
{
    public class IncidentModel
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public string id { get; set; }
        public string referenceID { get; set; }
        public string month { get; set; }
        public bool pending { get; set; }
        public string year { get; set; }
        public string title { get; set; }
        public string impactArea { get; set; }
        public string victimLocation { get; set; }
        public string victimCountry { get; set; }
        public string identity { get; set; }
        public string victimType { get; set; }
        public string affectedSystem { get; set; }
        public string method { get; set; }
        public string malwareType { get; set; }
        public string ransomwareType { get; set; }
        public string attackPattern { get; set; }
        public string campaign { get; set; }
        public string impact { get; set; }
        public string threatActorCountry { get; set; }
        public string threatActor { get; set; }
        public string additionalInfo { get; set; }
        public string summary { get; set; }
        public List<string> referenceShort { get; set; }
        public List<string> references { get; set; }
        public List<string> AdditionalInfoList { get; set; }

    }
}
