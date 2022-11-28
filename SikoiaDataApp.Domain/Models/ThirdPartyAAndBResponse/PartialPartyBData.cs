using Newtonsoft.Json;
using SikoiaDataApp.Domain.Models.ThirdPartyBResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SikoiaDataApp.Domain.Models.ThirdPartyAAndBResponse
{
    /// <summary>
    /// Extract specific properties from third party B response
    /// </summary>
    public class PartialPartyBData
    {
        [JsonProperty("activities")]
        public List<Activity>? Activities { get; set; }

        [JsonProperty("relatedPersons")]
        public List<RelatedPerson>? RelatedPersons { get; set; }

        [JsonProperty("relatedCompanies")]
        public List<RelatedCompany>? RelatedCompanies { get; set; }
    }
}
