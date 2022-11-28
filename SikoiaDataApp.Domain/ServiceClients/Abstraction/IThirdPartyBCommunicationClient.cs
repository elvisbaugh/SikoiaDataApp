using SikoiaDataApp.Domain.Enums;
using SikoiaDataApp.Domain.Models.ThirdPartyBResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SikoiaDataApp.Domain.ServiceClients.Abstraction
{
    /// <summary>
    /// Communication client for third party B.
    /// </summary>
    public interface IThirdPartyBCommunicationClient
    {

        /// <summary>
        /// Retrives response data from third party B client service.
        /// </summary>
        /// <param name="jurisdiction">specifies the region code.</param>
        /// <param name="companyNumber">specifies the company number.</param>
        /// <returns>Returns third party B specific data.</returns>
        Task<ThirdPartyBRegionData> GetDataAsync(Jurisdiction jurisdiction, int companyNumber);
    }
}
