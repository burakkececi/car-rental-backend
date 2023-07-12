using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFBillingDal : EFRepository<Billing>
    {
        public override List<Billing> GetAll(Expression<Func<Billing, bool>>? filter = null)
        {
            using var context = new CarRentalDbContext();
            return filter == null ?
                context.Billings.ToList() :
                context.Billings.Where(filter).ToList();
        }
    }
}
