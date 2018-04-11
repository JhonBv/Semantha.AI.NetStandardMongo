using System;
using System.Collections.Generic;
using System.Text;

namespace Semantha.AI.BCL.MongoDB.Models.BindingModels
{
    public class CreateUserBindingModel
    {
        public string userName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string BirthDate { get; set; }
        public string AgeRange { get; set; }
        public string email { get; set; }
        public string dateAdded { get; set; }

        public CreateAddressBindingModel address { get; set; }
    }
}
