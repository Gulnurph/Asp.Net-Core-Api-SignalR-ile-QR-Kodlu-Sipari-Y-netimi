using BusinessLayer.Abstract;
using DataAccess.Abstract;
using EntiyLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductServices
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product entity)
        {
            _productDal.AddAsync(entity);
        }

        public void Delete(Product entity)
        {
            _productDal.DeleteAsync(entity);
        }

        public List<Product> GetAll()
        {
           var result=_productDal.GetAllAsync();
            return result.ToList();
        }

        public Product GetById(int id)
        {
            return _productDal.GetById(id);
        }

        public List<Product> TGetProductWithCategory()
        {
            return _productDal.GetProductWithCategory();
        }

        public void Update(Product entity)
        {
           _productDal.UpdateAsync(entity);
        }
    }
}
