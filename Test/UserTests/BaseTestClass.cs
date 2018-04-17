using MongoDbAtlasConnector;
using MongoDbAtlasConnector.Infrastructure;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test.UserTests
{
    public class BaseTestClass
    {
        public string[] dbcons;
        public string conn;
        public string db;
        public MongoDbContext _ctx;

        [SetUp]
        public void SetUp()
        {
            dbcons = System.IO.File.ReadAllLines(@"amb.txt");
            conn = myConfig.conn = dbcons[0].ToString();
            db = myConfig.dbName = dbcons[1].ToString();

            //JB. Set the context and Db name in the Congif file.
            myConfig.conn = dbcons[0].ToString();
            myConfig.dbName = dbcons[1].ToString();

            //JB. This is the MongoDbConnector's BaseClass.
            BaseClass baseClass = new BaseClass(conn, db);
            _ctx = new MongoDbContext();

        }

        [TearDown]
        public void tearDown()
        {
            myConfig.conn = "";
            myConfig.dbName = "";
            _ctx = null;
        }
    }
}
