using MongoDB.Bson.Serialization.Attributes;
namespace Stix.Models
{
    public class IncidentsModel
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }

        [BsonElement("month")]
        public int Month { get; set; }
        
        [BsonElement("year")]
        public int Year { get; set; }
    }
}
