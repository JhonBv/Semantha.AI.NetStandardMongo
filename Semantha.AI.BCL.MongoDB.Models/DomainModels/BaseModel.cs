using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace Semantha.AI.BCL.MongoDB.Models.DomainModels
{
    public class BaseModel
    {
        public ObjectId _id { get; set; }
    }
}
