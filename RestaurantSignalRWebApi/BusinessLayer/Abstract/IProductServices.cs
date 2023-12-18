using EntiyLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProductServices:IGenericService<Product>
    {
        public List<Product> TGetProductWithCategory();
    }
}
