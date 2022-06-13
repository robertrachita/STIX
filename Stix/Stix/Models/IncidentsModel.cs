using MongoDB.Bson.Serialization.Attributes;
namespace Stix.Models
{
    public class IncidentsModel
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("name")]
        public string? Name { get; set; }

        [BsonElement("description")]
        public string? Description { get; set; }

        [BsonElement("month")]
        public int Month { get; set; }
        
        [BsonElement("year")]
        public int Year { get; set; }

        [BsonElement("summary")]
        public string? Summary { get; set; }

        [BsonElement("affected_system")]
        public string? AffectedSystem { get; set; }

        [BsonElement("impact_area")]
        public string? ImpactArea { get; set; }

        [BsonElement("location")]
        public string? Location { get; set; }

        [BsonElement("victim_identity")]
        public string? Victim_Identity { get; set; }

        [BsonElement("method")]
        public string? Method { get; set; }
    }
}
