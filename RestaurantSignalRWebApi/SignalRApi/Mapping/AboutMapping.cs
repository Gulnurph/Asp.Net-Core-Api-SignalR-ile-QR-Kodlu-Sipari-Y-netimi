using AutoMapper;
using DtoLayer.AboutDto;
using EntiyLayer.Entities;

namespace SignalRApi.Mapping
{
    public class AboutMapping:Profile
    {
        public AboutMapping()
        {
            CreateMap<ResultAboutDto, About>().ReverseMap();//iki taraflı eşleştirme 
            CreateMap<About,CreateAboutDto>().ReverseMap();
            CreateMap<About,GetAboutDto>().ReverseMap();
            CreateMap<About,UpdateAboutDto>().ReverseMap();
        }
    }
}
