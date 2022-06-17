using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Stix_Mongo_API.Models

{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [MaxLength(100)]
        [BsonElement("Name")]
        public string? Name { get; set; } = null!;

        [Required]
        [BsonElement("Email")]
        public string Email { get; set; }

        [Required]
        [MinLength(8)]
        [BsonElement("Password")]
        public string password { get; set; }



    }
}
