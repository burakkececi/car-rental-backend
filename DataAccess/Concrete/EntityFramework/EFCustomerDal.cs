using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCustomerDal : EFRepository<Customer>
    {
        public override List<Customer> GetAll(Expression<Func<Customer, bool>>? filter = null)
        {
            using var context = new CarRentalDbContext();
            return filter == null ?
                context.Customers.ToList() :
                context.Customers.Where(filter).ToList();
        }
    }
}
