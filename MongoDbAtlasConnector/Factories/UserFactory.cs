using MongoDB.Bson;
using MongoDbAtlasConnector.Infrastructure;
using MongoDbAtlasConnector.Services;
using Semantha.AI.BCL.MongoDB.Models.BindingModels;
using Semantha.AI.BCL.MongoDB.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoDbAtlasConnector.Factories
{
    public static class UserFactory
    {

        public static BsonDocument CreateMongoUser(CreateUserBindingModel user)
        {
            
            var document = new BsonDocument
            {
                { "_id", ObjectId.GenerateNewId()},
                { "userName", user.userName },
                { "FirstName", user.FirstName },
                { "LastName", user.LastName },
                { "PhoneNumber", user.PhoneNumber },
                { "BirthDate", user.BirthDate},
                { "AgeRange", user.AgeRange },
                { "email", user.email },

                { "dateAdded", DateTime.Today.ToLongDateString() },

                { "address", new BsonDocument{
                    { "_id", ObjectId.GenerateNewId() },
                    { "lineOne", user.address.lineOne },
                    { "lineTwo", user.address.lineTwo},
                    { "lineThree", user.address.lineThree},
                    { "city", user.address.city},
                    { "postCode", user.address.postCode}
                }
                }
            };


            return document;
        }
    }
}
