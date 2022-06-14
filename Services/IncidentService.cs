using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using Stix_Mongo_API.Models;

namespace Stix_Mongo_API.Services
{
    public class IncidentService
    {
        public readonly IMongoCollection<Incident> _incidents;

        public IncidentService(IOptions<StixDatabaseSettings> stixDatabaseSettings)
        {
            var mongoClient = new MongoClient(stixDatabaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(stixDatabaseSettings.Value.DatabaseName);

            _incidents = mongoDatabase.GetCollection<Incident>(stixDatabaseSettings.Value.IncidentsCollectionName);
        }

        public async Task<List<Incident>> GetAllIncidents() =>
            await _incidents.Find(new BsonDocument()).ToListAsync();

        public async Task<Incident> GetIncident(string id) =>
            await _incidents.Find(incident => incident.Id == id).FirstOrDefaultAsync();

        public async Task CreateIncident(Incident incident) =>
            await _incidents.InsertOneAsync(incident);

        public async Task UpdateIncident(string id, Incident incidentIn) =>
            await _incidents.ReplaceOneAsync(incident => incident.Id == id, incidentIn);

        public async Task RemoveIncident(string id) =>
            await _incidents.DeleteOneAsync(incident => incident.Id == id);
    }

 

}
