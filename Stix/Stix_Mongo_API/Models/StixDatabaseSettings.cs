namespace Stix_Mongo_API.Models
{
    public class StixDatabaseSettings
    {
        public string ConnectionString { get; set; }

        public string DatabaseName { get; set; }

        public string UsersCollectionName { get; set; } = null!;
    }
}
