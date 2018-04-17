using MongoDbAtlasConnector.Infrastructure;
using System;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using Semantha.AI.BCL.MongoDB.Models.DomainModels;

namespace MongoDbAtlasConnector.Services
{
    /// <summary>
    /// Service module to find out if a username has been used already.
    /// </summary>
    public static class FindUserName
    {
        static MongoDbContext _ctx = new MongoDbContext();

        /// <summary>
        /// Returns whetehr the user exist or not.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="collection"></param>
        /// <returns></returns>
        public static bool UsernameExists(string username, string collection)
        {
            var coool = _ctx.mDatabase.GetCollection<BsonDocument>(collection);
            var filter = Builders<BsonDocument>.Filter.Eq("userName", username);
            

            var projection = Builders<BsonDocument>.Projection.Include("userName").Exclude("_id");
            
            var result = coool.Find(filter).Project(projection).ToList();
            string returneduserName = "";

            BsonDocument myDoc;

            foreach (var i in result) {

                myDoc = i;
                returneduserName = myDoc["userName"].AsString;
            }

            bool exists = String.IsNullOrEmpty(returneduserName) ? false : true;

            return exists;
        }
    }
}
