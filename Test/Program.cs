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

            MongoDbAtlasConnector.GetUSerCollection col = new MongoDbAtlasConnector.GetUSerCollection(connString,database);

            foreach (var i in col.GetAllUsers())
            {
                Console.WriteLine(i.userName +" | " + i.email + " | " + i.dateAdded);
            }
            

            Console.ReadKey();
        }
    }
}
