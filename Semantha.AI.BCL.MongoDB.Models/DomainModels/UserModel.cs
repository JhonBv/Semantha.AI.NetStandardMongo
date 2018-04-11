using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace Semantha.AI.BCL.MongoDB.Models.DomainModels
{
    public class UserModel:BaseModel
    {        
        public string userName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string BirthDate { get; set; }
        public string AgeRange { get; set; }
        public string email { get; set; }
        public string dateAdded { get; set; }

        public Address address { get; set; }
    }
}
