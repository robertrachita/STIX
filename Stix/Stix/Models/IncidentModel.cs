using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stix.Models
{
    public class IncidentModel
    {
        public string id { get; set; }

        public string referenceID { get; set; }

        public string Month { get; set; }

        public bool Pending { get; set; }

        public string Year { get; set; }

        public String Title { get; set; }

        public string ImpactArea { get; set; }

        public string VictimLocation { get; set; }

        public string VictimCountry { get; set; }

        public string Identity { get; set; }

        public string VictimType { get; set; }

        public string AffectedSystem { get; set; }

        public string Method { get; set; }

        public string MalwareType { get; set; }

        public string RansomwareType { get; set; }

        public string AttackPattern { get; set; }

        public string Campaign { get; set; }

        public string Impact { get; set; }

        public string ThreatActorCountry { get; set; }

        public string ThreatActor { get; set; }

        public string AdditionalInfo { get; set; }

        public string Summary { get; set; }

        public List<string> ReferenceShort { get; set; }

        public List<string> References { get; set; }

        public List<string> AdditionalInfoList { get; set; }

    }
}
