using System;
using System.Collections.Generic;
using System.Text;

namespace Semantha.AI.BCL.MongoDB.Models.DomainModels
{
    public class LocationDemographics:BaseModel
    {
        public string title { get; set; }
        public string coordinates { get; set; }

        public string description { get; set; }
    }
}
