using Newtonsoft.Json;
using SikoiaDataApp.Domain.Models.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SikoiaDataApp.Domain.Models.ThirdPartyBResponse
{
    /// <inheritdoc />
    public class ThirdPartyBRegionData : IBaseRegionData
    {
        [JsonProperty("companyNumber")]
        public string? CompanyNumber { get; set; }

        [JsonProperty("companyName")]
        public string? CompanyName { get; set; }

        [JsonProperty("country")]
        public string? Country { get; set; }

        [JsonProperty("dateFrom")]
        public string? DateFrom { get; set; }

        [JsonProperty("dateTo")]
        public string? DateTo { get; set; }

        [JsonProperty("address")]
        public string? Address { get; set; }

        [JsonProperty("activities")]
        public List<Activity>? Activities { get; set; }

        [JsonProperty("relatedPersons")]
        public List<RelatedPerson>? RelatedPersons { get; set; }

        [JsonProperty("relatedCompanies")]
        public List<RelatedCompany>? RelatedCompanies { get; set; }
    }
}
