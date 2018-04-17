using System;
using System.Collections.Generic;
using System.Text;

namespace MongoDbAtlasConnector
{
    /// <summary>
    /// Configuration for the Server and Database
    /// </summary>
    public static class Configuration
    {
        /// <summary>
        /// Connection string
        /// </summary>
        public static string _connectionString { get; set; }

        /// <summary>
        /// Mongo db name
        /// </summary>        
        public static string _databasename{ get; set; }
    }
}
