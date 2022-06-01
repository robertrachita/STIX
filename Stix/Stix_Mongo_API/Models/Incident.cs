using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Stix_Mongo_API.Models
{
    //[BsonIgnoreExtraElements]
    public class Incident
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("Name")] 
        public string? Name { get; set; }

        [BsonElement("Sources")]
        public List<string>? Sources { get; set; }

        //this doesnt break the api, but it doesn't send the correct data to the database and GET will crash

        //[BsonElement("Additional")]
        //public dynamic? Additional { get; set; }


        //this freezes the api
        //TODO: figure out how to get this to work
        //https://mongodb.github.io/mongo-csharp-driver/2.8/examples/mixing_static_and_dynamic/

        [BsonExtraElements]
        public BsonDocument? ExtraElements { get; set; }
    }
}
