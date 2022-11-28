using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SikoiaDataApp.Domain.Models.Response
{
    public class DateOfBirth
    {
        [JsonProperty("year")]
        public int Year { get; set; }
        [JsonProperty("month")]
        public int Month { get; set; }
    }
}
