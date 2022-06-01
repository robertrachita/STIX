using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Stix_Mongo_API.Models
{
    
    public class Incident
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("Name")] 
        public string? Name { get; set; }

        [BsonExtraElements]
        public BsonDocument? Additional { get; set; }
    }
}
