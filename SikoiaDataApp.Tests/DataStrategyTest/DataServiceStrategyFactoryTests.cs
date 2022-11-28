using AutoFixture.Xunit2;
using AutoMapper;
using FluentAssertions;
using Moq;
using SikoiaDataApp.Domain.Enums;
using SikoiaDataApp.Domain.Models.Response;
using SikoiaDataApp.Domain.Models.ThirdPartyBResponse;
using SikoiaDataApp.Domain.ServiceClients.Abstraction;
using SikoiaDataApp.Domain.Services;
using SikoiaDataApp.Domain.Services.Abstraction;
using Xunit;

namespace SikoiaDataApp.Tests.DataStrategyTest
{   
    public class DataServiceStrategyFactoryTests
    {
        private  Mock<IThirdPartyACommunicationClient> _thirdPartyACommunicationClient;
        private  Mock<IThirdPartyBCommunicationClient> _thirdPartyBCommunicationClient;

        private  Mock<IMapper> _mapper;
        private  IDataServiceStrategyFactory _sut;

        public DataServiceStrategyFactoryTests()
        {
            _thirdPartyACommunicationClient = new Mock<IThirdPartyACommunicationClient>();
            _thirdPartyBCommunicationClient = new Mock<IThirdPartyBCommunicationClient>();
            _mapper = new Mock<IMapper>();

            _sut = new DataServiceStrategyFactory(_thirdPartyACommunicationClient.Object, _thirdPartyBCommunicationClient.Object, _mapper.Object);
        }

        [Theory]
        [AutoData]
        public void DataServiceStrategyFactory_ShouldReturnUKDataRegionDataStrategy(ThirdPartyARegionData thirdPartyARegion)
        {
            _thirdPartyACommunicationClient.Setup(x => x.GetDataAsync(Jurisdiction.UK, It.IsAny<int>())).ReturnsAsync(thirdPartyARegion);

            var result = _sut.GetProviderStrategyAsync(Jurisdiction.UK);

            result.Should().BeOfType<UKDataService>();
        }

        [Theory]
        [AutoData]
        public void DataServiceStrategyFactory_ShouldReturnNLDataRegionDataStrategy(ThirdPartyBRegionData thirdPartyBRegion)
        {
            _thirdPartyBCommunicationClient.Setup(x => x.GetDataAsync(Jurisdiction.NL, It.IsAny<int>())).ReturnsAsync(thirdPartyBRegion);

            var result = _sut.GetProviderStrategyAsync(Jurisdiction.NL);

            result.Should().BeOfType<NetherlandDataService>();
        }

        [Theory]
        [AutoData]
        public void DataServiceStrategyFactory_ShouldReturnDEDataRegionDataStrategy(ThirdPartyBRegionData thirdPartyBRegion, ThirdPartyARegionData thirdPartyARegion)
        {
            _thirdPartyBCommunicationClient.Setup(x => x.GetDataAsync(Jurisdiction.DE, It.IsAny<int>())).ReturnsAsync(thirdPartyBRegion);
            _thirdPartyACommunicationClient.Setup(x => x.GetDataAsync(Jurisdiction.DE, It.IsAny<int>())).ReturnsAsync(thirdPartyARegion);

            var result = _sut.GetProviderStrategyAsync(Jurisdiction.DE);

            result.Should().BeOfType<GermanyDataService>();
        }
    }
}
