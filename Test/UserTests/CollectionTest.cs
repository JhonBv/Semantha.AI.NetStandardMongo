using System;
using System.Collections.Generic;
using System.Text;
namespace Test.UserTests
{
    using NUnit.Framework;
    using MongoDbAtlasConnector;
    using MongoDB.Bson;
    using MongoDbAtlasConnector.Infrastructure;

    [TestFixture]
    class CollectionTest:BaseTestClass
    {       
        [Test]
        public void I_Have_SetUp_Context()
        {

            Assert.IsNotNull(_ctx);
        }

        [Test]
        public void DataBase_Do_Exist()
        {
            Assert.IsNotNull(_ctx._client.GetDatabase(db));
        }

        [Test]
        public void My_Collection_Do_Exist()
        {
            string collection = "users";
            
            var myCollection = _ctx.mDatabase.GetCollection<BsonDocument>(collection);
            Assert.That(myCollection.CollectionNamespace.FullName, Is.Not.Null);
            Assert.That(myCollection.Database.DatabaseNamespace.DatabaseName, Is.EqualTo(db));
            Assert.That(myCollection.CollectionNamespace.CollectionName, Is.EqualTo(collection));
        }
    }
}
