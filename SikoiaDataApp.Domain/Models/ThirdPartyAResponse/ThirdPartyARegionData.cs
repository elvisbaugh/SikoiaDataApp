using Newtonsoft.Json;
using SikoiaDataApp.Domain.Models.Abstraction;
using SikoiaDataApp.Domain.Models.ThirdPartyAResponse;

namespace SikoiaDataApp.Domain.Models.Response
{
    /// <inheritdoc />
    public class ThirdPartyARegionData : IBaseRegionData
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

        [JsonProperty("officers")]
        public List<Officer>? Officers { get; set; }

        [JsonProperty("owners")]
        public List<Owner>? Owners { get; set; }
    }
}
