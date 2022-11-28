using SikoiaDataApp.Domain.Enums;
using SikoiaDataApp.Domain.Models;
using SikoiaDataApp.Domain.Models.Abstraction;
using SikoiaDataApp.Domain.Services.Abstraction;

namespace SikoiaDataApp.Domain.Services.Implementation
{
    /// <summary>
    ///  The default implementation of <see cref="IRegionService" />
    /// </summary>
    public class RegionService : IRegionService
    {
        private readonly IDataServiceStrategyFactory _thirdPartyStrategyFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="_thirdPartyStrategyFactory"/> class.
        /// </summary>
        /// <param name="thirdPartyStrategyFactory"></param>
        public RegionService(IDataServiceStrategyFactory thirdPartyStrategyFactory)
        {
            _thirdPartyStrategyFactory = thirdPartyStrategyFactory;
        }

        /// <inheritdoc />
        public async Task<IBaseRegionData> Handle(Jurisdiction regionCode, int companyNumber)
        {
            var request = new Request() { Jurisdiction = regionCode, CompanyNumber = companyNumber };

            var dataProvider = _thirdPartyStrategyFactory.GetProviderStrategyAsync(request.Jurisdiction);
            var result = await dataProvider.GetRequestedData(request);

            return result;
        }
    }
}
