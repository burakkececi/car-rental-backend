using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCustomerTypeDal : EFRepository<CustomerType>
    {
        public override List<CustomerType> GetAll(Expression<Func<CustomerType, bool>>? filter = null)
        {
            using var context = new CarRentalDbContext();
            return filter == null ?
                context.CustomerTypes.ToList() :
                context.CustomerTypes.Where(filter).ToList();
        }
    }
}
