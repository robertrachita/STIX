using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Stix_Mongo_API.Models;

namespace Stix_Mongo_API.Services
{
    public class UserService
    {
        public readonly IMongoCollection<User> _usersCollection;

        public UserService(
            IOptions<StixDatabaseSettings> stixDatabaseSettings)
        {
            var mongoClient = new MongoClient(stixDatabaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(stixDatabaseSettings.Value.DatabaseName);

            _usersCollection = mongoDatabase.GetCollection<User>(stixDatabaseSettings.Value.CollectionName);
        }

        public async Task<List<User>> GetAllUsersAsync() =>
            await _usersCollection.Find(user => true).ToListAsync();

        public async Task<User?> GetUserAsync(string id) =>
            await _usersCollection.Find(user => user.Id == id).FirstOrDefaultAsync();

        // public async Task<User?> GetUserAsync(string email, string password) => 
        //await _usersCollection.Find(user => user.Email == email && user.Password == password).FirstOrDefaultAsync();

        public async Task CreateUserAsync(User user) =>
            await _usersCollection.InsertOneAsync(user);

        public async Task UpdateUserAsync(string id, User userIn) =>
            await _usersCollection.ReplaceOneAsync(user => user.Id == id, userIn);

        public async Task DeleteUserAsync(string id) =>
            await _usersCollection.DeleteOneAsync(user => user.Id == id);

        public async Task<bool> UserExistsAsync(string id) =>
            await _usersCollection.Find(user => user.Id == id).AnyAsync();

       // public async Task<bool> UserExistsAsync(string email, string password) =>
            //await _usersCollection.Find(user => user.Email == email && user.Password == password).AnyAsync();
            
        

    }        
}
