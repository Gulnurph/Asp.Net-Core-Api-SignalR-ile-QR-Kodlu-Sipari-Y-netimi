using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Repository;
using EntiyLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(Context context) : base(context)
        {
        }

        public List<Product> GetProductWithCategory()
        {
            var db = new Context();
            var values=db.Product.Include(x=> x.Category).ToList();
            return values;
        }
    }
}
