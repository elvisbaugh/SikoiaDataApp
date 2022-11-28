using Flurl.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SikoiaDataApp.Domain.Enums;
using SikoiaDataApp.Domain.Services.Abstraction;
using System.Net;
using System.Net.Http;

namespace SikoiaDataApp.WebService.Endpoints
{
    [Route("api/[controller]/v1")]
    [ApiController]
    public class RegionController : ControllerBase
    {
        private readonly IRegionService _regionService;
        public RegionController(IRegionService regionService)
        {
            _regionService = regionService;
        }

        [HttpGet("company/{regionCode}/{companyNumber}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetDataView(Jurisdiction regionCode, int companyNumber)
        {
            try
            {
                var response = await _regionService.Handle(regionCode, companyNumber);

                if (response == null)
                {
                    return NotFound();
                }
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}