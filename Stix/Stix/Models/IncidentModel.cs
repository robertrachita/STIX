using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stix.Models
{
    public class IncidentModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public List<string> Sources { get; set; }
       
    }
}
