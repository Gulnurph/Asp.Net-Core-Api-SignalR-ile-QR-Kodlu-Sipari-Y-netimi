using DataAccess.Abstract;
using DataAccess.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccess.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly Context _context;

        public GenericRepository(Context context)
        {
            this._context = context;
        }

        public void AddAsync(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void DeleteAsync(T entity)
        {
           _context.Remove(entity);
            _context.SaveChanges();
        }

        public IList<T> GetAllAsync()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public IQueryable<T> QueryGetList(Expression<Func<T, bool>> filter = null)
        {
            return filter == null
              ? _context.Set<T>()
              : _context.Set<T>().Where(filter);
        }

        public void UpdateAsync(T entity)
        {
           _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
