using MongoDB.Bson;
using MongoDbAtlasConnector.Factories;
using Semantha.AI.BCL.MongoDB.Models.BindingModels;
using Semantha.AI.BCL.MongoDB.Models.DomainModels;
using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Loading vals from text files (ignored by Git)
            string[] dbcons = System.IO.File.ReadAllLines(@"amb.txt");
            

            myConfig.conn = dbcons[0].ToString();
            myConfig.dbName = dbcons[1].ToString();


            //Your DB Connection string
            string connString = myConfig.conn;

            //your Mongo Database
            string database = myConfig.dbName;
            
            MongoDbAtlasConnector.UserRepository col = new MongoDbAtlasConnector.UserRepository(connString,database);

            foreach (var i in col.GetAllUsers())
            {
                Console.WriteLine(i.userName + " | " + i.email + " | " + i.dateAdded);
            }

            BsonDocument userDoc = UserFactory.CreateMongoUser(newUser());
            //col.AddUSer(userDoc);

            Console.ReadKey();
        }

        public static CreateUserBindingModel newUser()
        {
            var model = new CreateUserBindingModel {
                
                FirstName = "Jhon",
                LastName = "Barreiro",
                BirthDate = "06/09/1986",
                email = "jhonb@gmail.com",
                userName = "jjbarr",
                PhoneNumber = "07376095123",
                AgeRange = "25-35",
                dateAdded = DateTime.Today.ToShortDateString(),
                address = new CreateAddressBindingModel {
                    lineOne="78 Overstone Road",
                    lineTwo="",
                    city ="London",
                    lineThree="",
                    postCode ="W6 0AB",
                    country="UK",
                    isbilling=true,
                    isshipping=true,
                    
                }
            };

            return model;
        }
    }
}
