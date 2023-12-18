using AutoMapper;
using BusinessLayer.Abstract;
using DataAccess.Concrete;
using DtoLayer.ProductDto;
using EntiyLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductServices _services;
    
        public ProductController(IProductServices services)
        {
            _services = services;
         
        }

        [HttpGet]
        public IActionResult ProductList()
        {
            _services.GetAll();
            return Ok();

        }
        [HttpGet("ProductListWithCategory")]
        public IActionResult ProductListWithCatgeory() {
            var db = new Context();
            var values = db.Product.Include(x => x.Category).Select(y => new ResultProductWithCategory()
            {
                ProductDescription = y.ProductDescription,
                ProductName = y.ProductName,
                CatgeoryName = y.Category.CategoryName,
                Status = y.Status,
                ImgUrl = y.ImgUrl,
                Price = y.Price,
                ProductId = y.ProductId,

            });
       
            return Ok(values.ToList());
        }
        [HttpPost]
        public async Task<IActionResult> ProductAdd(CreateProductDto createProduct)
        {
            Product product = new Product()
            {
                ProductDescription = createProduct.ProductDescription,
                ProductName = createProduct.ProductName,
                Price = createProduct.Price,
                ImgUrl = createProduct.ImgUrl,
                Status = createProduct.Status,
            };
           _services.Add(product);
            return Ok("Ürün Eklendi");
        }
        [HttpDelete]
        public IActionResult ProductDelete(int id)
        {
            var value = _services.GetById(id);
            _services.Delete(value);
            return Ok("Ürün Silindi");

        }
        [HttpPut]
        public IActionResult ProductUpdate(Product product) {
            Product product1 = new Product()
            {
                ProductDescription = product.ProductDescription,
                ProductName = product.ProductName,
                Price = product.Price,
                ImgUrl = product.ImgUrl,
                Status = product.Status,

            };
            _services.Update(product1);
            return Ok("Güncellendi");
        }
    }
}
