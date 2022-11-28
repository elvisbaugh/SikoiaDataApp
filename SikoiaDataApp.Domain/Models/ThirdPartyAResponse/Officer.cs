using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SikoiaDataApp.Domain.Models.Response
{
    public class Officer
    {
        [JsonProperty("first_name")]
        public string? FirstName { get; set; }

        [JsonProperty("last_name")]
        public string? LastName { get; set; }

        [JsonProperty("date_from")]
        public DateFrom? DateFrom { get; set; }

        [JsonProperty("date_to")]
        public DateTo? DateTo { get; set; }

        [JsonProperty("role")]
        public string? Role { get; set; }

        [JsonProperty("date_of_birth")]
        public DateOfBirth? DateOfBirth { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }
    }

}
