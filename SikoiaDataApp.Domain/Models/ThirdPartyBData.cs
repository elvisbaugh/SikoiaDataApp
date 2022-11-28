using SikoiaDataApp.Domain.Models.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SikoiaDataApp.Domain.Models
{
    public class ThirdPartyBData : IBaseRegionData
    {
        public string Monkey { get; set; }
        public string Name { get; set; }
    }
}
