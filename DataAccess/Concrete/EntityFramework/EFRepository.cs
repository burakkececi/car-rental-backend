using Core;
using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public abstract class EFRepository<T> : IRepository<T> where T : class, IEntity, new()
    {
        public void Add(T entity)
        {
            using var context = new CarRentalDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            using var context = new CarRentalDbContext();
            context.Remove(entity);
            context.SaveChangesAsync();
        }

        public T Get(System.Linq.Expressions.Expression<Func<T, bool>> filter)
        {
            using var context = new CarRentalDbContext();
            return context.Set<T>().SingleOrDefault(filter);
        }

        public abstract List<T> GetAll(System.Linq.Expressions.Expression<Func<T, bool>>? filter = null);
        
        public void Update(T entity)
        {
            using var context = new CarRentalDbContext();
            context.Update(entity);
            context.SaveChangesAsync();
        }
    }
}
