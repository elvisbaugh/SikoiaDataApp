using SikoiaDataApp.Domain.Models;
using SikoiaDataApp.Domain.Models.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SikoiaDataApp.Domain.Services.Abstraction
{
    /// <summary>
    /// The type of strategy that is returned.
    /// </summary>
    public interface IDataServiceStrategy
    {
        /// <summary>
        /// Gets data from a third party request call.
        /// </summary>
        /// <param name="request">Object with the request data</param>
        /// <returns>Returns data from a third party request.</returns>
        Task<IBaseRegionData> GetRequestedData(Request request);
    }
}
