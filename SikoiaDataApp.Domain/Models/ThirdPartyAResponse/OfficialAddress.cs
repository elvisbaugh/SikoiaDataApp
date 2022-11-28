using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SikoiaDataApp.Domain.Models.Response
{
    public class OfficialAddress
    {
        [JsonProperty("street")]
        public string? Street { get; set; }

        [JsonProperty("city")]
        public string? City { get; set; }

        [JsonProperty("country")]
        public string? Country { get; set; }

        [JsonProperty("postcode")]
        public string? Postcode { get; set; }
    }

}
