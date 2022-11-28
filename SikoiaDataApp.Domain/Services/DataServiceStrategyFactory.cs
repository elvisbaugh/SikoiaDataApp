using AutoMapper;
using SikoiaDataApp.Domain.Enums;
using SikoiaDataApp.Domain.ServiceClients.Abstraction;
using SikoiaDataApp.Domain.Services.Abstraction;

namespace SikoiaDataApp.Domain.Services
{
    /// <summary>
    /// The default implementation of <see cref="IDataServiceStrategyFactory"/>
    /// </summary>
    public class DataServiceStrategyFactory : IDataServiceStrategyFactory
    {
        private readonly IThirdPartyACommunicationClient _thirdPartyACommunicationClient; 
        private readonly IThirdPartyBCommunicationClient _thirdPartyBCommunicationClient;

        private readonly IMapper _mapper;

        private readonly Dictionary<Jurisdiction, IDataServiceStrategy> _regionStrategyContext = new();

        /// <summary>
        /// Initilizes a new instance of the <see cref="DataServiceStrategyFactory"/>
        /// </summary>
        /// <param name="thirdPartyACommunicationClient">Thirdpaty A communication client</param>
        /// <param name="thirdPartyBCommunicationClient">Thirdparty B communication client</param>
        /// <param name="mapper">Mapper.</param>
        public DataServiceStrategyFactory(
            IThirdPartyACommunicationClient thirdPartyACommunicationClient,
            IThirdPartyBCommunicationClient thirdPartyBCommunicationClient,
            IMapper mapper)
        {
            _thirdPartyACommunicationClient = thirdPartyACommunicationClient;
            _thirdPartyBCommunicationClient = thirdPartyBCommunicationClient;
            _mapper = mapper;

            _regionStrategyContext.Add(Jurisdiction.UK, new UKDataService(_thirdPartyACommunicationClient)); 
            _regionStrategyContext.Add(Jurisdiction.NL, new NetherlandDataService(_thirdPartyBCommunicationClient));
            _regionStrategyContext.Add(Jurisdiction.DE, new GermanyDataService(_thirdPartyBCommunicationClient, _thirdPartyACommunicationClient, _mapper));
        }

        /// <inheritdoc />
        public IDataServiceStrategy GetProviderStrategyAsync(Jurisdiction jurisdiction)
        {
            var strategy = _regionStrategyContext[jurisdiction];

            return strategy;
        }
    }
}
