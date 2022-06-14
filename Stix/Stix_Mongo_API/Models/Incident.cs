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

        [BsonIgnoreIfNull]
        [BsonElement("ReferenceID")]
        public string? ReferenceID { get; set; }

        [BsonElement("Month")]
        public string? Month { get; set; }

        [BsonElement("Pending")]
        public bool? Pending { get; set; }

        [BsonElement("Year")]
        public string? Year { get; set; }

        [BsonElement("Title")]
        public String Title { get; set; }

        [BsonElement("Impact area")]
        public string? ImpactArea { get; set; }

        //city or region (al) area
        [BsonElement("Victim Location")]
        public string? VictimLocation { get; set; }

        [BsonElement("Victim Country")]
        public string? VictimCountry { get; set; }

        [BsonElement("Identity")]
        public string? Identity { get; set; }

        [BsonElement("Victim type")]
        public string? VictimType { get; set; }

        [BsonElement("Affected system")]
        public string? AffectedSystem { get; set; }

        [BsonElement("Method")]
        public string? Method { get; set; }

        [BsonElement("Malware type")]
        public string? MalwareType { get; set; }

        [BsonElement("Ransomware type")]
        public string? RansomwareType { get; set; }

        [BsonElement("Attack Pattern")]
        public string? AttackPattern { get; set; }

        [BsonElement("Campaign")]
        public string? Campaign { get; set; }

        [BsonElement("Impact")]
        public string? Impact { get; set; }

        [BsonElement("Threat Actor country")]
        public string? ThreatActorCountry { get; set; }

        [BsonElement("Threat Actor")]
        public string? ThreatActor { get; set; }

        [BsonIgnoreIfNull]
        [BsonElement("Additional info")]
        public string? AdditionalInfo { get; set; }

        [BsonElement("Summary")]
        public string? Summary { get; set; }

        [BsonIgnoreIfNull]
        [BsonElement("Reference(short)")]
        public List<string>? ReferenceShort { get; set; }

        [BsonElement("References")]
        public List<string>? References { get; set; }

        [BsonElement("AdditionalInfo")]
        public List<string>? AdditionalInfoList { get; set; }

        //[BsonExtraElements]
        //public BsonDocument? ExtraElements { get; set; }


    }

    //public class Incident
    //{
    //    [BsonId]
    //    [BsonRepresentation(BsonType.ObjectId)]
    //    public string? Id { get; set; }

    //    [BsonIgnoreIfNull]
    //    [BsonElement("name")]
    //    public string? Name { get; set; }
    //}

    //this doesnt break the api, but it doesn't send the correct data to the database and GET will crash

    //[BsonElement("Additional")]
    //public dynamic? Additional { get; set; }


    //this freezes the api
    //TODO: figure out how to get this to work
    //https://mongodb.github.io/mongo-csharp-driver/2.8/examples/mixing_static_and_dynamic/

    //[BsonExtraElements]
    //public BsonDocument? ExtraElements { get; set; }
}
