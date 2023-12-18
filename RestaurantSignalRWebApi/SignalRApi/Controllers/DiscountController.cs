using BusinessLayer.Abstract;
using DtoLayer.DiscountDto;
using EntiyLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly IDiscountServices _discountServices;

        public DiscountController(IDiscountServices discountServices)
        {
            _discountServices = discountServices;
        }
        [HttpGet]
        public IActionResult DiscountList()
        {
            _discountServices.GetAll();
            return Ok();


        }
        [HttpPut]
        public IActionResult UpdateDiscount(UpdateDiscountDto updateDiscountDto)
        {
            Discount discount = new Discount()
            {
                Description = updateDiscountDto.Description,
                Amount = updateDiscountDto.Amount,
                ImgUrl = updateDiscountDto.ImgUrl,
                Title = updateDiscountDto.Title,
            };
            _discountServices.Update(discount);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteDiscount(int id)
        {
           var value= _discountServices.GetById(id);
            _discountServices.Delete(value);
            return Ok();
        }
        [HttpPost]
        public IActionResult DiscountCreate(CreateDiscountDto createDiscountDto) {

            Discount discount = new Discount()
            {
                Description = createDiscountDto.Description,
                Amount = createDiscountDto.Amount,
                ImgUrl = createDiscountDto.ImgUrl,
                Title = createDiscountDto.Title,
            };
            _discountServices.Add(discount);
            return Ok();

        }
    }
}
