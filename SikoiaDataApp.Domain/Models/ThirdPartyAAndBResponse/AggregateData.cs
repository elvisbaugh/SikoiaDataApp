using SikoiaDataApp.Domain.Models.Abstraction;

namespace SikoiaDataApp.Domain.Models.ThirdPartyAAndBResponse
{
    /// <summary>
    /// Aggregate data reponse from both third party A and third party B.
    /// </summary>
    public class AggregateData : IBaseRegionData
    {
        /// <summary>
        /// Extract specific properties from third party A response
        /// </summary>
        public PartialPartyAData? PartialPartyAData { get; set; }

        /// <summary>
        /// Extract specific properties from third party B response
        /// </summary>
        public PartialPartyBData? PartialPartyBData { get; set; }
    }
}
