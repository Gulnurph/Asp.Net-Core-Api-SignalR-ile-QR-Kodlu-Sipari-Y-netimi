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
    public class DiscountManager : IDiscountServices
    {
        private readonly IDiscountDal _discountDal;

        public DiscountManager(IDiscountDal discountDal)
        {
            _discountDal = discountDal;
        }

        public void Add(Discount entity)
        {
           _discountDal.AddAsync(entity);
        }

        public void Delete(Discount entity)
        {
            _discountDal.DeleteAsync(entity);
        }

        public List<Discount> GetAll()
        {
            var result = _discountDal.GetAllAsync();
            return result.ToList();
        }

        public Discount GetById(int id)
        {
          return _discountDal.GetById(id);
        }

        public void Update(Discount entity)
        {
            _discountDal.UpdateAsync(entity);
        }
    }
}
