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
    public class CategoryManager : ICategoryServices
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category entity)
        {
            _categoryDal.AddAsync(entity);
        }

        public void Delete(Category entity)
        {
            _categoryDal?.DeleteAsync(entity);
        }

        public List<Category> GetAll()
        {
           var result=_categoryDal.GetAllAsync();
            return result.ToList();
        }

        public Category GetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public void Update(Category entity)
        {
           _categoryDal.UpdateAsync(entity);
        }
    }
}
