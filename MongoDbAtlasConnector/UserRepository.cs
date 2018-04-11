using MongoDB.Bson;
using MongoDB.Driver;

using MongoDbAtlasConnector.Infrastructure;
using System.Linq;
using System.Collections.Generic;
using Semantha.AI.BCL.MongoDB.Models.DomainModels;

namespace MongoDbAtlasConnector
{
    /// <summary>
    /// 
    /// </summary>
    public class UserRepository
    {
        /// <summary>
        /// 
        /// </summary>
        public MongoDbContext _ctx;

        /// <summary>
        /// 
        /// </summary>
        public UserRepository(string connString, string dbname)
        {
            Configuration._connectionString = connString;
            Configuration._databasename = dbname;
            _ctx = new MongoDbContext(Configuration._databasename);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<UserModel> GetAllUsers()
        {
            
            var userCollection = _ctx.mDatabase.GetCollection<UserModel>("users");
            var filter = Builders<BsonDocument>.Filter.Empty;

            var result = userCollection.Find(new BsonDocument()).ToList();
            return result;
        }

        public void AddUSer(BsonDocument user)
        {
            //JB. Specify the collection in which to store documents (data ;P)
            var userCollection = _ctx.mDatabase.GetCollection<BsonDocument>("users");

            userCollection.InsertOne(user);

        }


    }
}
