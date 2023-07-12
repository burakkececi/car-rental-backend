using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFPaymentDal : EFRepository<Payment>
    {
        public override List<Payment> GetAll(Expression<Func<Payment, bool>>? filter = null)
        {
            using var context = new CarRentalDbContext();
            return filter == null ?
                context.Payments.ToList() :
                context.Payments.Where(filter).ToList();
        }
    }
}
