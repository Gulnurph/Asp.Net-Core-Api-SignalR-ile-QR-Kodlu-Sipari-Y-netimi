using AutoMapper;
using DtoLayer.TestimonialDto;
using EntiyLayer.Entities;

namespace SignalRApi.Mapping
{
    public class TestimonialMapping:Profile
    {
        public TestimonialMapping()
        {
            CreateMap<Testimonial, CreateTestimonialDto>().ReverseMap();
            CreateMap<Testimonial,ResultTestimonialDto>().ReverseMap();
            CreateMap<Testimonial,GetTetimonialDto>().ReverseMap();
            CreateMap<Testimonial, UpdateTetimonialDto>().ReverseMap();
        }
     
    }
}
