using SikoiaDataApp.Domain.Models;
using SikoiaDataApp.Domain.Models.Abstraction;
using SikoiaDataApp.Domain.ServiceClients.Abstraction;
using SikoiaDataApp.Domain.Services.Abstraction;

namespace SikoiaDataApp.Domain.Services
{
    /// <summary>
    /// The default implementation of <see cref="IDataServiceStrategy" />
    /// </summary>
    public class NetherlandDataService : IDataServiceStrategy
    {
        private readonly IThirdPartyBCommunicationClient _thirdPartyBCommunicationClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="_thirdPartyBCommunicationClient"/> class.
        /// </summary>
        /// <param name="_thirdPartyBCommunicationClient">Client to communicate with third party B service.</param>
        public NetherlandDataService(IThirdPartyBCommunicationClient thirdPartyBCommunicationClient)
        {
            _thirdPartyBCommunicationClient = thirdPartyBCommunicationClient;
        }

        /// <inheritdoc />
        public async Task<IBaseRegionData> GetRequestedData(Request request)
        {
            var providerResponse = await _thirdPartyBCommunicationClient.GetDataAsync(request.Jurisdiction, request.CompanyNumber);
           
            return providerResponse;
        }
    }
}
