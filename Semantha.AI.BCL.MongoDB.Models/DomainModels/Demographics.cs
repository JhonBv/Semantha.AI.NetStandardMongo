using System;
using System.Collections.Generic;
using System.Text;

namespace Semantha.AI.BCL.MongoDB.Models.DomainModels
{
    public class Demographics
    {
        public ICollection<AgeRangeDemographics> ageDemographics { get; set; }
        public ICollection<LocationDemographics> locationDemographics { get; set; }

    }
}
