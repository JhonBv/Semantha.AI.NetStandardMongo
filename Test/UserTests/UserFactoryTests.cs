using MongoDB.Bson;
using MongoDbAtlasConnector.Factories;
using NUnit.Framework;
using Semantha.AI.BCL.MongoDB.Models.BindingModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test.UserTests
{
    [TestFixture]
    public class UserFactoryTests:BaseTestClass
    {
        [Test]
        public void Takes_a_UserBindingModel_Returns_A_BsonDocument()
        {
            //Arrange
            var user1 = newUsersMock.AddMayra();
            
            //Act
            var returnedUser = UserFactory.CreateMongoUser(user1);

            //Assert
            Assert.That(user1, Is.Not.Null);
            Assert.That(returnedUser, Is.Not.Null);
            Assert.That(returnedUser.IsBsonDocument);
        }        
    }
}
