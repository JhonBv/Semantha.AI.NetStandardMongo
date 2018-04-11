using System;
using System.Collections.Generic;
using System.Text;

namespace Semantha.AI.BCL.MongoDB.Models.BindingModels
{
    public class CreateAddressBindingModel
    {
        public string userId { get; set; }

        public string lineOne { get; set; }
        public string lineTwo { get; set; }
        public string lineThree { get; set; }
        public string city { get; set; }

        public string postCode { get; set; }

        public string country { get; set; }

        public bool isbilling { get; set; }

        public bool isshipping { get; set; }
    }
}
