using MongoDB.Bson;
using MongoDB.Driver;
using MongoDbAtlasConnector.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoDbAtlasConnector.Services
{
    /// <summary>
    /// Check if an email address already exist
    /// </summary>
    public static class FindUserEmail
    {
        static MongoDbContext _ctx = new MongoDbContext();

        /// <summary>
        /// Query the collection to check whether an Email address exist.
        /// </summary>
        /// <param name="email">email address to be checked</param>
        /// <param name="collection">the collection where the query is to be performed</param>
        /// <returns></returns>
        public static bool EmailExists(string email, string collection)
        {

            var myCollection = _ctx.mDatabase.GetCollection<BsonDocument>(collection);
            string returnedEmail = "";
            BsonDocument myDoc;

            var filter = Builders<BsonDocument>.Filter.Eq("email", email);
            var projection = Builders<BsonDocument>.Projection.Include("email").Exclude("_id");
            var result = myCollection.Find(filter).Project(projection).ToList();
            
            foreach (var i in result)
            {

                myDoc = i;
                returnedEmail = myDoc["email"].AsString;
            }

            bool exists = String.IsNullOrEmpty(returnedEmail) ? false : true;

            return exists; 
        }
    }
}
