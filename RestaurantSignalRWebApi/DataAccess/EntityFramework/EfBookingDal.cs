using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Repository;
using EntiyLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {
        public EfBookingDal(Context context) : base(context)
        {
        }

        public object GetAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
