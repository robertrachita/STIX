using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace Stix.Models
{

    [BsonIgnoreExtraElements]
    public class Incident
    {

        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string id { get; set; }

        [BsonElement("referenceID")]

        [JsonProperty("referenceID")]
        public string referenceID { get; set; }
        [BsonElement("month")]
        public string month { get; set; }
        [BsonElement("pending")]
        public bool pending { get; set; }
        [BsonElement("year")]
        public string year { get; set; }
        [BsonElement("title")]
        public string title { get; set; }
        [BsonElement("impactArea")]
        public string impactArea { get; set; }
        [BsonElement("victimLocation")]
        public string victimLocation { get; set; }
        [BsonElement("victimCountry")]
        public string victimCountry { get; set; }
        [BsonElement("identity")]
        public string identity { get; set; }
        [BsonElement("victimType")]
        public string victimType { get; set; }

        [BsonElement("affectedSystem")]
        public string affectedSystem { get; set; }
        [BsonElement("method")]
        public string method { get; set; }
        [BsonElement("malwareType")]
        public string malwareType { get; set; }
        [BsonElement("ransomwareType")]
        public string ransomwareType { get; set; }
        [BsonElement("attackPattern")]
        public string attackPattern { get; set; }
        [BsonElement("campaign")]
        public string campaign { get; set; }
        [BsonElement("impact")]
        public string impact { get; set; }
        [BsonElement("threatActorCountry")]
        public string threatActorCountry { get; set; }
        [BsonElement("threatActor")]
        public string threatActor { get; set; }

        [BsonElement("additionalInfo")]
        public string additionalInfo { get; set; }
        [BsonElement("summary")]
        public string summary { get; set; }

        [BsonElement("referenceShort")]
        public List<string> referenceShort { get; set; }
        [BsonElement("references")]
        public List<string> references { get; set; }
        [BsonElement("additionalInfoList")]
        public List<string> AdditionalInfoList { get; set; }

    }
}
