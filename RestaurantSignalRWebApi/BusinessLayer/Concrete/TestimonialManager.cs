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
    public class TestimonialManager : ITestimonialServices
    {
        private readonly ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void Add(Testimonial entity)
        {
           _testimonialDal.AddAsync(entity);
        }

        public void Delete(Testimonial entity)
        {
            _testimonialDal.DeleteAsync(entity);
        }

        public List<Testimonial> GetAll()
        {
            var result = _testimonialDal.GetAllAsync();
            return result.ToList();
        }

        public Testimonial GetById(int id)
        {
            return _testimonialDal.GetById(id);
        }

        public void Update(Testimonial entity)
        {
           _testimonialDal.UpdateAsync(entity);
        }
    }
}
