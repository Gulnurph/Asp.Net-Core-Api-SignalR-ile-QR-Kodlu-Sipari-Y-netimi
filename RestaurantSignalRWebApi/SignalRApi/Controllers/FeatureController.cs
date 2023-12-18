using BusinessLayer.Abstract;
using DtoLayer.FeatureDto;
using EntiyLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureController : ControllerBase
    {
        private readonly IFeatureServices _featureServices;

        public FeatureController(IFeatureServices featureServices)
        {
            _featureServices = featureServices;
        }
        [HttpGet]
        public IActionResult FeatureList()
        {
            _featureServices.GetAll();
            return Ok();

        }
        [HttpPost]
        public IActionResult FeatureAdd(CreateFeatureDto createFeatureDto)
        {
            Feature feature = new Feature()
            {
                Description1 = createFeatureDto.Description1,
                Description2 = createFeatureDto.Description2,
                Description3 = createFeatureDto.Description3,
                Title1 = createFeatureDto.Title1,
                Title2 = createFeatureDto.Title2,
                Title3 = createFeatureDto.Title3,

            };
            _featureServices.Add(feature);
            return Ok();
        }
        [HttpDelete]
        public IActionResult FeatureDelete(int id)
        {

          var value=  _featureServices.GetById(id);
            _featureServices.Delete(value);
            return Ok();
        }
        [HttpPut]
        public IActionResult FeatureUpdate(UpdateFeatureDto updateFeatureDto) {
            Feature feature = new Feature()
            {
                Description1 = updateFeatureDto.Description1,
                Description2 = updateFeatureDto.Description2,
                Description3 = updateFeatureDto.Description3,
                Title1 = updateFeatureDto.Title1,
                Title2 = updateFeatureDto.Title2,
                Title3 = updateFeatureDto.Title3,
            };
            _featureServices.Update(feature);
            return Ok();
         }
    }
}
