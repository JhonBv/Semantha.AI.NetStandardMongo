using MongoDbAtlasConnector.Services;
using Semantha.AI.BCL.MongoDB.Models.BindingModels;
using System;

namespace Test
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    //JB. Load DB configuration.
        //    InitializeMongoDb();

        //    MongoDbAtlasConnector.UserRepository col = new MongoDbAtlasConnector.UserRepository();

        //    foreach (var i in col.GetAllUsers("users"))
        //    {
        //        Console.WriteLine(i.userName + " | " + i.email + " | " + i.dateAdded);
        //    }

        //    //now pass the built user to the Repository.
        //    Console.WriteLine(UserService.AddNewUser(newUser(),"users"));

        //    Console.ReadKey();
        //}

        public static CreateUserBindingModel newUser()
        {

            return newUsersMock.AddSam();
        }

        /// <summary>
        /// Put all database details here. This will initialise your context.
        /// </summary>
        static void InitializeMongoDb()
        {
            //JB. Loading vals from text files (ignored by Git)
            string[] dbcons = System.IO.File.ReadAllLines(@"amb.txt");

            //JB. Set the context and Db name in the Congif file.
            myConfig.conn = dbcons[0].ToString();
            myConfig.dbName = dbcons[1].ToString();

            //JB. Then initialise the base class so that the context gets properly initialised with the required parameters.
            MongoDbAtlasConnector.BaseClass init = new MongoDbAtlasConnector.BaseClass(myConfig.conn, myConfig.dbName);
        }
    }
}
