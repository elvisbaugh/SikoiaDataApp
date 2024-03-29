﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SikoiaDataApp.Domain.Models.ThirdPartyBResponse
{
    public class RelatedPerson
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("dateFrom")]
        public string? DateFrom { get; set; }

        [JsonProperty("dateTo")]
        public string? DateTo { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("birthDate")]
        public string? BirthDate { get; set; }

        [JsonProperty("nationality")]
        public string? Nationality { get; set; }

        [JsonProperty("ownership")]
        public string? Ownership { get; set; }
    }
}
