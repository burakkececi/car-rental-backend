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
    public class EFCustomerDal : ICustomerDal
    {
        public void Add(Customer entity)
        {
            using var context = new CarRentalDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Customer entity)
        {
            using var context = new CarRentalDbContext();
            context.Remove(entity);
            context.SaveChangesAsync();
        }

        public Customer Get(Expression<Func<Customer, bool>> filter)
        {
            using var context = new CarRentalDbContext();
            return context.Set<Customer>().FirstOrDefault(filter);
        }

        public List<Customer> GetAll(Expression<Func<Customer, bool>>? filter = null)
        {
            using var context = new CarRentalDbContext();
            return filter == null ?
                context.Customers.ToList() :
                context.Customers.Where(filter).ToList();
        }

        public void Update(Customer entity)
        {
            using var context = new CarRentalDbContext();
            context.Update(entity);
            context.SaveChangesAsync();
        }
    }
}
