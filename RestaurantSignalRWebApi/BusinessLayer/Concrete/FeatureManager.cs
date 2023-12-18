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
    public class FeatureManager : IFeatureServices
    {
        private readonly IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void Add(Feature entity)
        {
            _featureDal.AddAsync(entity);
        }

        public void Delete(Feature entity)
        {
            _featureDal.DeleteAsync(entity);
        }

        public List<Feature> GetAll()
        {
           var result=_featureDal.GetAllAsync();
            return result.ToList();
        }

        public Feature GetById(int id)
        {
           return _featureDal.GetById(id);
        }

        public void Update(Feature entity)
        {
            _featureDal.UpdateAsync(entity);
        }
    }
}
