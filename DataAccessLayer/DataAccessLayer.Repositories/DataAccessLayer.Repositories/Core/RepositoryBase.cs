using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using DataAccessLayer;
using System.Linq.Expressions;

namespace DataAccessLayer.Repositories.Core
{
    public class RepositoryBase<T> where T :  class
    {
        protected ApplicationContext dbContext = new ApplicationContext();
        protected DbSet<T> entityContext;

        protected RepositoryBase()
        {
            entityContext = dbContext.Set<T>();
        }
        public IEnumerable<T> Get()
        {
            return entityContext.AsEnumerable();
        }
        public IEnumerable<T> Get(Expression<Func<T, bool>> expression)
        {
            return entityContext.Where(expression).AsEnumerable();
        }
        public T Get(int id)
        {
            return entityContext.Find(id);
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
