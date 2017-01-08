using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using DataAccessLayer;
using System.Linq.Expressions;

namespace DataAccessLayer.Repositories.Core
{
    public class RepositoryBase<T> : IRepository<T> where T :  class
    {
        protected ApplicationContext dbContext = new ApplicationContext();
        protected DbSet<T> entityContext;

        protected RepositoryBase()
        {
            entityContext = dbContext.Set<T>();
        }
  
        public T Get(int id)
        {
            return entityContext.Find(id);
        }
        public T Get(Expression<Func<T, bool>> expression)
        {
            return entityContext.Where(expression).FirstOrDefault();
        }

  
        IEnumerable<T> GetList()
        {
            return entityContext.AsEnumerable();
        }

  
        IEnumerable<T> GetList(Expression<Func<T, bool>> predicate)
        {
            return entityContext.Where(predicate).AsEnumerable();
        }
        public void Add(T entity)
        {
            entityContext.Add(entity);
        }
        public void Update(T entity)
        {
            dbContext.Entry(entity).State = EntityState.Modified;
        }
        public void Delete(T entity)
        {
            dbContext.Entry(entity).State = EntityState.Deleted;
        }

 

    }
}
