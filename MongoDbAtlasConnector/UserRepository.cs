using MongoDB.Bson;
using MongoDB.Driver;

using MongoDbAtlasConnector.Infrastructure;
using System.Linq;
using System.Collections.Generic;
using Semantha.AI.BCL.MongoDB.Models.DomainModels;
using MongoDbAtlasConnector.Services;

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
        /// Initialise UserRepository
        /// </summary>
        public UserRepository()
        {
            _ctx = new MongoDbContext();
        }
       

        /// <summary>
        /// Returns a list of documents in the collection (users)
        /// </summary>
        /// <returns></returns>
        public List<UserModel> GetAllUsers(string collectionName)
        {
            
            var userCollection = _ctx.mDatabase.GetCollection<UserModel>(collectionName);
            var filter = Builders<BsonDocument>.Filter.Empty;

            var result = userCollection.Find(new BsonDocument()).ToList();
            return result;
        }

        /// <summary>
        /// Inserts a new user into the Mongo Collection (users)
        /// </summary>
        /// <param name="user">A BSonDocument with user details.</param>
        /// <param name="collectionName">The name of the collection in which to add the new document</param>
        /// <returns></returns>
        public string AddUSer(BsonDocument user, string collectionName)
        {
            
            //JB. Specify the collection in which to store documents (data ;P)
            var userCollection = _ctx.mDatabase.GetCollection<BsonDocument>(collectionName);

            userCollection.InsertOne(user);

            return "Success";
        }


    }
}
