using SikoiaDataApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SikoiaDataApp.Domain.Models
{
    /// <summary>
    /// Request object.
    /// </summary>
    public class Request
    {
        public Jurisdiction Jurisdiction { get; set; }
        public int CompanyNumber { get; set; }
    }
}
