using SikoiaDataApp.Domain.Models;
using SikoiaDataApp.Domain.Models.Abstraction;
using SikoiaDataApp.Domain.ServiceClients.Abstraction;
using SikoiaDataApp.Domain.Services.Abstraction;

namespace SikoiaDataApp.Domain.Services
{
    /// <summary>
    /// The default implementation of <see cref="IDataServiceStrategy" />
    /// </summary>
    public class UKDataService : IDataServiceStrategy
    {
        private readonly IThirdPartyACommunicationClient _serviceClientACommunication;

        /// <summary>
        /// Initializes a new instance of the <see cref="IThirdPartyACommunicationClient"
        /// </summary>
        /// <param name="serviceClientACommunication">Client to communicate with third party A service.</param>
        public UKDataService(IThirdPartyACommunicationClient serviceClientACommunication)
        {
            _serviceClientACommunication = serviceClientACommunication;
        }

        /// <inheritdoc />
        public async Task<IBaseRegionData> GetRequestedData(Request request)
        {
            return await _serviceClientACommunication.GetDataAsync(request.Jurisdiction, request.CompanyNumber);
        }
    }
}
