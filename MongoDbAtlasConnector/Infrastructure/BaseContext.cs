using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;

namespace MongoDbAtlasConnector.Infrastructure
{
    /// <summary>
    /// Base context class
    /// </summary>
    public class BaseContext
    {
        /// <summary>
        /// Set the MongoDB Client
        /// </summary>
        public IMongoClient _client;

        /// <summary>
        /// Sets MongoDb database to be used
        /// </summary>
        public IMongoDatabase _mDatabase;

        /// <summary>
        /// Pass on the connection String and DB name targeted.
        /// </summary>
        /// <param name="context">connection string including server name and any network credentials</param>
        /// <param name="dbname">name of the Mongo database to be used</param>
        public BaseContext(string context, string dbname)
        {
            _client = new MongoClient(context);
            _mDatabase = _client.GetDatabase(dbname);            
        }
    }
}
