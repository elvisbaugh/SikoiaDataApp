using SikoiaDataApp.Domain.Enums;
using SikoiaDataApp.Domain.ServiceClients.Abstraction;
using Flurl;
using Flurl.Http;
using System.Net;
using SikoiaDataApp.Domain.Models.Response;
using Flurl.Http.Configuration;
using System.Web.Http;

namespace SikoiaDataApp.Domain.ServiceClients.Implementation
{
    /// <summary>
    /// The default implementation of <see cref="IThirdPartyACommunicationClient" />
    /// </summary>
    public class ThirdPartyACommunicationClient : IThirdPartyACommunicationClient
    { 
        /// <inheritdoc />
        public async Task<ThirdPartyARegionData> GetDataAsync(Jurisdiction jurisdiction, int companyNumber)
        {

            var response = await "https://interview-df854r23.sikoia.com"
                .AppendPathSegment($"v1/company/{jurisdiction.ToString().ToLower()}/{companyNumber}")
                .AllowAnyHttpStatus()
                .GetAsync();

            if (!response.ResponseMessage.IsSuccessStatusCode)
            {
                throw new HttpResponseException((HttpStatusCode)response.StatusCode);
            }

            return await response.GetJsonAsync<ThirdPartyARegionData>();
        }
    }
}
