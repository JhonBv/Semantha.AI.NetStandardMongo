using MongoDB.Driver;

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
        /// Initialise the Context class passing the Mongo Database name you wish to use. 
        /// </summary>
        public MongoDbContext() 
            :base(Configuration._connectionString,Configuration._databasename)
        {
            
            mDatabase = _client.GetDatabase(Configuration._databasename);
        }
    }
}
