using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoDbAtlasConnector
{
    public class User
    {

        public ObjectId _id { get; set; }
        public string userName { get; set; }

        public string password { get; set; }
        public string email { get; set; }
        public string dateAdded { get; set; }

        public Address address { get; set; }
    }
}
