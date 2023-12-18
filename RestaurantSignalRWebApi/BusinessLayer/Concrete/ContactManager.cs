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
    public class ContactManager : IContactServices
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void Add(Contact entity)
        {
           _contactDal.AddAsync(entity);
        }

        public void Delete(Contact entity)
        {
           _contactDal.DeleteAsync(entity);
        }

        public List<Contact> GetAll()
        {
            var result=_contactDal.GetAllAsync();
            return result.ToList();
        }

        public Contact GetById(int id)
        {
           return _contactDal.GetById(id);
        }

        public void Update(Contact entity)
        {
           _contactDal.UpdateAsync(entity);
        }
    }
}
