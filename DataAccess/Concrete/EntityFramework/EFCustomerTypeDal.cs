using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCustomerTypeDal : ICustomerTypeDal
    {
        public void Add(CustomerType entity)
        {
            using var context = new CarRentalDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(CustomerType entity)
        {
            using var context = new CarRentalDbContext();
            context.Remove(entity);
            context.SaveChangesAsync();
        }

        public CustomerType Get(Expression<Func<CustomerType, bool>> filter)
        {
            using var context = new CarRentalDbContext();
            return context.Set<CustomerType>().SingleOrDefault(filter);
        }

        public List<CustomerType> GetAll(Expression<Func<CustomerType, bool>>? filter = null)
        {
            using var context = new CarRentalDbContext();
            return filter == null ?
                context.CustomerTypes.ToList() :
                context.CustomerTypes.Where(filter).ToList();
        }

        public void Update(CustomerType entity)
        {
            using var context = new CarRentalDbContext();
            context.Update(entity);
            context.SaveChangesAsync();
        }
    }
}
