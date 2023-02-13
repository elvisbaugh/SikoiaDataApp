using Flurl;
using Flurl.Http;
using SikoiaDataApp.Domain.Enums;
using SikoiaDataApp.Domain.Models.ThirdPartyBResponse;
using SikoiaDataApp.Domain.ServiceClients.Abstraction;
using System.Net;
using System.Web.Http;

namespace SikoiaDataApp.Domain.ServiceClients.Implementation
{
    /// <summary>
    /// The default implementation of <see cref="IThirdPartyBCommunicationClient" />
    /// </summary>
    public class ThirdPartyBCommunicationClient : IThirdPartyBCommunicationClient
    {
        /// <inheritdoc />
        public async Task<ThirdPartyBRegionData> GetDataAsync(Jurisdiction jurisdiction, int companyNumber)
        {
            var response = await "https://interview-df854r23.sikoia.com"
               .AppendPathSegment($"v1/company-data")
               .SetQueryParam("jurisdictionCode", jurisdiction.ToString().ToLower())
               .SetQueryParam("companyNumber", companyNumber)
               .AllowAnyHttpStatus()
               .GetAsync();


            if (!response.ResponseMessage.IsSuccessStatusCode)
            {
                throw new HttpResponseException((HttpStatusCode)response.StatusCode);
            }

            return await response.GetJsonAsync<ThirdPartyBRegionData>();
        }
    }
}
