using AutoMapper;
using DtoLayer.SocialMedyaDto;
using EntiyLayer.Entities;

namespace SignalRApi.Mapping
{
    public class SocialMedyaMapping : Profile
    {
        protected SocialMedyaMapping()
        {
            CreateMap<SocialMedya,ResultSocialMedyaDto>().ReverseMap();
            CreateMap<SocialMedya,CreateSocialMedyaDto>().ReverseMap();
            CreateMap<SocialMedya, GetSocialMedyaDto>().ReverseMap();
            CreateMap<SocialMedya, UpdateSocialMedyaDto>().ReverseMap();

        }
    }
}
