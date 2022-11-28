using Newtonsoft.Json;
using SikoiaDataApp.Domain.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SikoiaDataApp.Domain.Models.ThirdPartyAAndBResponse
{
    /// <summary>
    /// Extract specific properties from third party A response
    /// </summary>
    public class PartialPartyAData
    {
        [JsonProperty("company_number")]
        public string? CompanyNumber { get; set; }

        [JsonProperty("company_name")]
        public string? CompanyName { get; set; }

        [JsonProperty("jurisdiction_code")]
        public string? JurisdictionCode { get; set; }

        [JsonProperty("company_type")]
        public string? CompanyType { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("date_established")]
        public DateEstablished? DateEstablished { get; set; }

        [JsonProperty("date_dissolved")]
        public object? DateDissolved { get; set; }

        [JsonProperty("official_address")]
        public OfficialAddress? OfficialAddress { get; set; }
    }
}
