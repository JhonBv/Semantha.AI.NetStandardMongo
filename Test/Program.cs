using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Loading vals from text files (ignored by Git)
            string[] dbcons = System.IO.File.ReadAllLines(@"amb.txt");
            string[] dbnames = System.IO.File.ReadAllLines(@"C:\Users\Jhon Barreiro\source\repos\MongoDbAtlasConnector\Test\dbname.txt");
            

            myConfig.conn = dbcons[0].ToString();
            myConfig.dbName = dbnames[0].ToString();


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
