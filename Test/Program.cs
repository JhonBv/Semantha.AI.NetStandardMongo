using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Your DB Connection string
            string connString = myConfig.conn;

            //your Mongo Database
            string database = myConfig.dbName;

            MongoDbAtlasConnector.GetUSerCollection col = new MongoDbAtlasConnector.GetUSerCollection(connString,database);

            foreach (var i in col.GetAllUsers())
            {
                Console.WriteLine(i.userName +" | " + i.email + " | " + i.dateAdded);
            }
            

            Console.ReadKey();
        }
    }
}
