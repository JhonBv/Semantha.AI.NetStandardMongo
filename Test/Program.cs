using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string connString = "mongodb://jhonb:P1pt1cl3@clysmacluster-shard-00-00-sldiv.mongodb.net:27017,clysma" +
            "cluster-shard-00-01-sldiv.mongodb.net:27017,clysmacluster-shard-00-02-sldiv.mong" +
            "odb.net:27017/admin?replicaSet=clysmacluster-shard-0&ssl=true";

            MongoDbAtlasConnector.GetUSerCollection col = new MongoDbAtlasConnector.GetUSerCollection(connString,"epimarketdb");

            foreach (var i in col.GetAllUsers())
            {
                Console.WriteLine(i.userName +" | " + i.email + " | " + i.dateAdded);
            }
            

            Console.ReadKey();
        }
    }
}
