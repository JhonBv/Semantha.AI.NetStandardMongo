using System;
using System.Collections.Generic;
using System.Text;

namespace Semantha.AI.BCL.MongoDB.Models.DomainModels
{
    public class Product:BaseModel
    {
        public string productName { get; set; }
        public string description { get; set; }

        public decimal price { get; set; }

        public string soldBy { get; set; }

        public string dateAdded { get; set; }

    }
}
