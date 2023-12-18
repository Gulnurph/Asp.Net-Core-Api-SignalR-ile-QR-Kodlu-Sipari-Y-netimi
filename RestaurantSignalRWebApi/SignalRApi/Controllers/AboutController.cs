using BusinessLayer.Abstract;
using DtoLayer.AboutDto;
using EntiyLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutServices _aboutServices;

        public AboutController(IAboutServices aboutServices)
        {
            _aboutServices = aboutServices;
        }
        [HttpGet]
        public IActionResult AboutList()
        {
            var value = _aboutServices.GetAll();
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> AddAbout(CreateAboutDto createAboutDto)
        {
            About about = new About()
            {
                Title = createAboutDto.Title,
                Description = createAboutDto.Description,
                ImgUrl = createAboutDto.ImgUrl,
            };
            _aboutServices.Add(about);
            return Ok("Başarılı bir şekilde eklendi");

        }
        [HttpDelete]
        public IActionResult DeleteAbout(int id)
        {
            var value=_aboutServices.GetById(id);
            _aboutServices.Delete(value);
            return Ok("Silindi");
        }
        [HttpPut]
        public IActionResult AboutUpdate(UpdateAboutDto updateAboutDto)
        {
            About about = new About()
            {
                Title = updateAboutDto.Title,
                Description = updateAboutDto.Description,
                Id = updateAboutDto.Id,
                ImgUrl = updateAboutDto.ImgUrl
            };
            _aboutServices.Update(about);

            return Ok("Güncellendi");
        }
        [HttpGet("GetAbout")]
        public IActionResult GetAbout(int id)
        {
            var value=_aboutServices.GetById(id);
            return Ok(value);
        }


    }
}
