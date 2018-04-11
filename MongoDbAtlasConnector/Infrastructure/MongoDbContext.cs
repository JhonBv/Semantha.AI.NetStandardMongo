using MongoDB.Driver;
using MongoDB.Driver.Core.Servers;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoDbAtlasConnector.Infrastructure
{
    /// <summary>
    /// 
    /// </summary>
    public class MongoDbContext:BaseContext
    {
        
        /// <summary>
        /// 
        /// </summary>
        public IMongoDatabase mDatabase;

        

        /// <summary>
        /// Constructor
        /// </summary>
        public MongoDbContext(string dbName) 
            :base(Configuration._connectionString,Configuration._databasename)
        {
            
            mDatabase = _client.GetDatabase(dbName);
        }
    }
}
