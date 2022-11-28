using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SikoiaDataApp.Domain.Models.ThirdPartyBResponse
{
    public class Activity
    {
        [JsonProperty("activityCode")]
        public int? ActivityCode { get; set; }

        [JsonProperty("activityDescription")]
        public string? ActivityDescription { get; set; }
    }
}
