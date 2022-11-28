using SikoiaDataApp.Domain.Enums;

namespace SikoiaDataApp.Domain.Services.Abstraction
{
    /// <summary>
    /// Factory class that gets the algorithm the needs to be executed.
    /// </summary>
    public interface IDataServiceStrategyFactory
    {
        /// <summary>
        /// Get the strategy that should be excuted.
        /// </summary>
        /// <param name="jurisdiction">enum value of the region</param>
        /// <returns>Returns a class object specific to a region.</returns>
        IDataServiceStrategy GetProviderStrategyAsync(Jurisdiction jurisdiction);
    }
}
