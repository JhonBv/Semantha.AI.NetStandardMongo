using MongoDB.Bson;
using MongoDB.Driver;

using MongoDbAtlasConnector.Infrastructure;
using Semantha.AI.BCL.Models.Models;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MongoDbAtlasConnector
{
    /// <summary>
    /// 
    /// </summary>
    public class GetUSerCollection
    {
        /// <summary>
        /// 
        /// </summary>
        public MongoDbContext _ctx;

        /// <summary>
        /// 
        /// </summary>
        public GetUSerCollection(string connString, string dbname)
        {
            Configuration._connectionString = connString;
            Configuration._databasename = dbname;
            _ctx = new MongoDbContext(Configuration._databasename);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<User> GetAllUsers()
        {
            
            var userCollection = _ctx.mDatabase.GetCollection<User>("userlogins");
            var filter = Builders<BsonDocument>.Filter.Empty;

            var result = userCollection.Find(new BsonDocument()).ToList();
            return result;

            

            

            
        }


    }
}
