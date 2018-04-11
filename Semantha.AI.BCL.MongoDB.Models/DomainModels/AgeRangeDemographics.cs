using System;
using System.Collections.Generic;
using System.Text;

namespace Semantha.AI.BCL.MongoDB.Models.DomainModels
{
    public class AgeRangeDemographics:BaseModel
    {
        public string title { get; set; }
        public string ageRange { get; set; }

        public string description { get; set; }
    }
}
