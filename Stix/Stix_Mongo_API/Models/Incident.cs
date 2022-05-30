using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Stix_Mongo_API.Models
{
    [BsonIgnoreExtraElements]
    public class Incident
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
    }
}
