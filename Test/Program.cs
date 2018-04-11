using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string connString = "";

            MongoDbAtlasConnector.GetUSerCollection col = new MongoDbAtlasConnector.GetUSerCollection(connString,"epimarketdb");

            foreach (var i in col.GetAllUsers())
            {
                Console.WriteLine(i.userName +" | " + i.email + " | " + i.dateAdded);
            }
            

            Console.ReadKey();
        }
    }
}
