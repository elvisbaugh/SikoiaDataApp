using AutoMapper;
using SikoiaDataApp.Domain.Models;
using SikoiaDataApp.Domain.Models.Abstraction;
using SikoiaDataApp.Domain.Models.Response;
using SikoiaDataApp.Domain.Models.ThirdPartyAAndBResponse;
using SikoiaDataApp.Domain.ServiceClients.Abstraction;
using SikoiaDataApp.Domain.Services.Abstraction;

namespace SikoiaDataApp.Domain.Services
{
    /// <summary>
    /// The default implementation of <see cref="IDataServiceStrategy" />
    /// </summary>
    public class GermanyDataService : IDataServiceStrategy
    {
        private readonly IThirdPartyBCommunicationClient _thirdPartyBCommunicationClient;
        private readonly IThirdPartyACommunicationClient _thirdPartyACommunicationClient;

        private readonly IMapper _mapper;

        /// <summary>
        ///  Initializes a new instance of the <see cref="_thirdPartyBCommunicationClient"/> class.
        ///  Initializes a new instance of the <see cref="_thirdPartyACommunicationClient"/> class.
        /// </summary>
        /// <param name="thirdPartyBCommunicationClient">Client to communicate with third party B service.</param>
        /// <param name="thirdPartyACommunicationClient">Client to communicate with third party A service.</param>
        /// <param name="mapper">mapping the response object to select the best data properties.</param>
        public GermanyDataService(
            IThirdPartyBCommunicationClient thirdPartyBCommunicationClient,
            IThirdPartyACommunicationClient thirdPartyACommunicationClient,
            IMapper mapper)
        {
            _thirdPartyACommunicationClient = thirdPartyACommunicationClient;
            _thirdPartyBCommunicationClient = thirdPartyBCommunicationClient;
            _mapper = mapper;
        }

        /// <inheritdoc />
        public async Task<IBaseRegionData> GetRequestedData(Request request)
        {
            var providerResponseATask =  _thirdPartyACommunicationClient.GetDataAsync(request.Jurisdiction, request.CompanyNumber);
            var providerResponseBTask =  _thirdPartyBCommunicationClient.GetDataAsync(request.Jurisdiction, request.CompanyNumber);

             await Task.WhenAll(providerResponseATask, providerResponseBTask);

            var providerResponseA = await providerResponseATask;
            var providerResponseB = await providerResponseBTask;

            var aggregatedData  = _mapper.Map<ThirdPartyARegionData, AggregateData>(providerResponseA);
            var aggregatedResult = _mapper.Map(providerResponseB, aggregatedData);

            return aggregatedResult;

        }
    }
}
