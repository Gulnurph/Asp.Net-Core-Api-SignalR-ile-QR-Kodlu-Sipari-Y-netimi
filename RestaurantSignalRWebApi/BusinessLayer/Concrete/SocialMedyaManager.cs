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
    public class SocialMedyaManager : ISocialMedyaServices
    {
        private readonly ISocialMedyaDal _socialMedyaDal;

        public SocialMedyaManager(ISocialMedyaDal socialMedyaDal)
        {
            _socialMedyaDal = socialMedyaDal;
        }

        public void Add(SocialMedya entity)
        {
            _socialMedyaDal.AddAsync(entity);
        }

        public void Delete(SocialMedya entity)
        {
            _socialMedyaDal.DeleteAsync(entity);
        }

        public List<SocialMedya> GetAll()
        {
            var result = _socialMedyaDal.GetAllAsync();
            return result.ToList();
        }

        public SocialMedya GetById(int id)
        {
            return _socialMedyaDal.GetById(id);
        }

        public void Update(SocialMedya entity)
        {
            _socialMedyaDal.UpdateAsync(entity);
        }
    }
}
