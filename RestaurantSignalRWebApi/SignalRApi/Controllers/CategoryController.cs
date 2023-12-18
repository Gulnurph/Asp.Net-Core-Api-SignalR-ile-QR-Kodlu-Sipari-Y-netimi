using AutoMapper;
using BusinessLayer.Abstract;
using DtoLayer.CategoryDto;
using EntiyLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryServices _category;
        //private readonly IMapper _mapper;

        public CategoryController(ICategoryServices category/*, IMapper mapper*/)
         {
            _category = category;
            //_mapper = mapper;
         }
        [HttpGet]
        public IActionResult CategoryList()
        {
            _category.GetAll();
            return Ok();
        }
        [HttpPost]
        public IActionResult CategoryAdd(CreateCategoryDto createCategoryDto)
        {
            Category category = new Category()
            {
                CategoryName = createCategoryDto.CategoryName,
              
            };
            _category.Add(category);
            return Ok("Eklendi");

        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var value=_category.GetById(id);
            _category.Delete(value);
            return Ok("Silindi");
        }
        [HttpGet("CategoryGet")]
        public IActionResult CategoryGet(int id) { 
            var value=_category.GetById(id);
            return Ok(value);
        }
    }
}
