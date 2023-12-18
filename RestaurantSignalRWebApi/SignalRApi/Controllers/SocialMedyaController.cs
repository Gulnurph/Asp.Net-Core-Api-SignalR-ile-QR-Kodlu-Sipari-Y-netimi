using BusinessLayer.Abstract;
using DtoLayer.SocialMedyaDto;
using EntiyLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMedyaController : ControllerBase
    {
        private readonly ISocialMedyaServices _socialMedya;

        public SocialMedyaController(ISocialMedyaServices socialMedya)
        {
            _socialMedya = socialMedya;
        }
        [HttpGet]
        public IActionResult SoacialMedyaList()
        {
            _socialMedya.GetAll();
            return Ok();


        }
        [HttpPost]
        public IActionResult SocialMedyaAdd(CreateSocialMedyaDto socialMedyaDto)
        {
            SocialMedya socialMedya = new SocialMedya()
            {
                Title = socialMedyaDto.Title,
               
               
            };
            _socialMedya.Add(socialMedya);
            return Ok("Ürün Ekle");
        }
        [HttpGet("GetSocialMedya")]
        public IActionResult SocailGet(int id)
        {
            _socialMedya.GetById(id);
            return Ok();
        }
    }
}
