using AutoMapper;
using DtoLayer.ContactDto;
using EntiyLayer.Entities;

namespace SignalRApi.Mapping
{
    public class ContactMapping:Profile
    {
        public ContactMapping() 
        {
            CreateMap<Contact, ResultContactDto>().ReverseMap();
            CreateMap<Contact, CreateContactDto>().ReverseMap();
            CreateMap<Contact,GetContactDto>().ReverseMap();
            CreateMap<Contact,UpdateContactDto>().ReverseMap();
        }
    }
}
