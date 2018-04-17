using MongoDB.Bson;
using MongoDbAtlasConnector.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test.UserTests
{
    [TestFixture]
    public class FindSpecificUserDetailsTests: BaseTestClass
    {
        [Test]
        public void Check_Response_is_Bool_When_I_Check_for_EmailAddress()
        {            
            var response = FindUserEmail.EmailExists("jj@email.com", "users" );
            Assert.That(response, Is.False);
        }
    }
}
