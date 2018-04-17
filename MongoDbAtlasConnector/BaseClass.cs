using MongoDbAtlasConnector.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoDbAtlasConnector
{
    /// <summary>
    /// base class representing base conn
    /// </summary>
    public class BaseClass
    {
        /// <summary>
        /// 
        /// </summary>
        public MongoDbContext _ctx;

        /// <summary>
        /// Initialise the DB Connector
        /// </summary>
        /// <param name="connString"></param>
        /// <param name="dbname"></param>
        public BaseClass(string connString, string dbname)
        {
            Configuration._connectionString = connString;
            Configuration._databasename = dbname;
            _ctx = new MongoDbContext();
        }
    }
}
