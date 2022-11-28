using Newtonsoft.Json;
using SikoiaDataApp.Domain.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SikoiaDataApp.Domain.Models.ThirdPartyAResponse
{
    public class Owner
    {
        [JsonProperty("first_name")]
        public string? Firstname { get; set; }

        [JsonProperty("last_name")]
        public string? Lastname { get; set; }

        [JsonProperty("date_from")]
        public DateFrom? Datefrom { get; set; }

        [JsonProperty("date_to")]
        public object? Dateto { get; set; }

        [JsonProperty("ownership_type")]
        public string? Ownershiptype { get; set; }

        [JsonProperty("shares_held")]
        public double? Sharesheld { get; set; }

        [JsonProperty("date_of_birth")]
        public DateOfBirth? DateOfBirth { get; set; }
    }
}
