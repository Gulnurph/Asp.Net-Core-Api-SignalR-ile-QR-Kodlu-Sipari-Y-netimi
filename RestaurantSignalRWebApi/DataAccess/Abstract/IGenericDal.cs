using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IGenericDal<T> where T : class
    {
      void AddAsync(T entity);

       T GetById(int id);
        IList<T> GetAllAsync();
       
       void UpdateAsync(T entity);
        void DeleteAsync(T entity);
       
        IQueryable<T> QueryGetList(Expression<Func<T, bool>> filter = null);
    }
}
