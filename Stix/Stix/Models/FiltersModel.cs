using MongoDB.Bson.Serialization.Attributes;
namespace Stix.Models
{
    public class FiltersModel
    {

        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string id { get; set; }

        [BsonElement("title")]
        public bool Title { get; set; }

        [BsonElement("description")]
        public bool Description { get; set; }

        [BsonElement("date")]
        public bool Date { get; set; }

        [BsonElement("summary")]
        public bool Summary { get; set; }

        [BsonElement("affected_system")]
        public bool Affected_system { get; set; }

        [BsonElement("impact_area")]
        public bool Impacted_area { get; set; }

        [BsonElement("victim_identity")]
        public bool Victim_identity { get; set; }

        [BsonElement("method")]
        public bool Method { get; set; }

        [BsonElement("location")]
        public bool Location { get; set; }
    }
}
