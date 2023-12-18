using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Repository;
using EntiyLayer.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{ 
    public class EfSocialMedyaDal : GenericRepository<SocialMedya>, ISocialMedyaDal
    {
        public EfSocialMedyaDal(Context context) : base(context)
        {
        }
    }
}
