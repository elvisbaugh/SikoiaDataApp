using SikoiaDataApp.Domain.Enums;
using SikoiaDataApp.Domain.Models.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SikoiaDataApp.Domain.Services.Abstraction
{
    /// <summary>
    /// Provide data from a region that returned a result.
    /// </summary>
    public interface IRegionService
    {
        /// <summary>
        /// Handle the response to return data from the chosen algorithm.
        /// </summary>
        /// <param name="regionCode">Enum code that specifies the region code.</param>
        /// <param name="companyNumber">companyy number.</param>
        /// <returns></returns>
        Task<IBaseRegionData> Handle(Jurisdiction regionCode, int companyNumber);
    }
}
