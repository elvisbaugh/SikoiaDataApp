using AutoMapper;
using SikoiaDataApp.Domain.Models;
using SikoiaDataApp.Domain.Models.Response;
using SikoiaDataApp.Domain.Models.ThirdPartyAAndBResponse;
using SikoiaDataApp.Domain.Models.ThirdPartyBResponse;

namespace SikoiaDataApp.WebServices.Mapping
{
    public class DataProviderProfile : Profile
    {
        public DataProviderProfile()
        {

            CreateMap<ThirdPartyARegionData, AggregateData>()
                .ForPath(dest => dest.PartialPartyAData.CompanyName, opt => opt.MapFrom(src => src.CompanyNumber))
                .ForPath(dest => dest.PartialPartyAData.CompanyNumber, opt => opt.MapFrom(src => src.CompanyName))
                .ForPath(dest => dest.PartialPartyAData.DateDissolved, opt => opt.MapFrom(src => src.DateDissolved))
                .ForPath(dest => dest.PartialPartyAData.OfficialAddress, opt => opt.MapFrom(src => src.OfficialAddress))
                .ForPath(dest => dest.PartialPartyAData.JurisdictionCode, opt => opt.MapFrom(src => src.JurisdictionCode))
                .ForPath(dest => dest.PartialPartyAData.DateEstablished, opt => opt.MapFrom(src => src.DateEstablished))
                .ForPath(dest => dest.PartialPartyAData.Status, opt => opt.MapFrom(src => src.Status))
                .ForPath(dest => dest.PartialPartyAData.CompanyType, opt => opt.MapFrom(src => src.CompanyType));

            CreateMap<ThirdPartyBRegionData, AggregateData>()
                .ForPath(dest => dest.PartialPartyBData.RelatedCompanies, opt => opt.MapFrom(src => src.RelatedCompanies))
                .ForPath(dest => dest.PartialPartyBData.RelatedPersons, opt => opt.MapFrom(src => src.RelatedPersons))
                .ForPath(dest => dest.PartialPartyBData.Activities, opt => opt.MapFrom(src => src.Activities));
        }
    }
}
