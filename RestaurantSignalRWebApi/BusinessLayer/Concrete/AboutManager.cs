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
    public class AboutManager : IAboutServices
    {
        //dependency injection
        private readonly IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void Add(About entity)
        {
            _aboutDal.AddAsync(entity);
        }

        public void Delete(About entity)
        {
            _aboutDal.DeleteAsync(entity);
        }

        public List<About> GetAll()
         {
           var result= _aboutDal.GetAllAsync();
            return result.ToList();
         }

        public  About? GetById(int id)
        {
            return _aboutDal.GetById(id);
        }

        public void Update(About entity)
        {
            _aboutDal.UpdateAsync(entity);
        }
    }
}
