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
                var errorMessage = new HttpResponseMessage((HttpStatusCode)response.StatusCode)
                {
                    Content = new StringContent("Failed"),

                    ReasonPhrase = "Unable to processs request!",
                };

                throw new HttpResponseException(errorMessage);
            }

            return await response.GetJsonAsync<ThirdPartyARegionData>();
        }
    }
}
