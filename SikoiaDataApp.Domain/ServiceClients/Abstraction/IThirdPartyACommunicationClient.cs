using SikoiaDataApp.Domain.Enums;
using SikoiaDataApp.Domain.Models.Response;

namespace SikoiaDataApp.Domain.ServiceClients.Abstraction
{
    /// <summary>
    /// Communication client for third party A.
    /// </summary>
    public interface IThirdPartyACommunicationClient
    {
        /// <summary>
        /// Retrives response data from third party A client service.
        /// </summary>
        /// <param name="jurisdiction">specifies the region code.</param>
        /// <param name="companyNumber">specifies the company number.</param>
        /// <returns>Returns third party A specific data.</returns>
        Task<ThirdPartyARegionData> GetDataAsync(Jurisdiction jurisdiction, int companyNumber);
    }
}
