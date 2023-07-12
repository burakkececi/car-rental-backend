using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFBookingDal : EFRepository<Booking>
    {
        public override List<Booking> GetAll(Expression<Func<Booking, bool>>? filter = null)
        {
            using var context = new CarRentalDbContext();
            return filter == null ?
                context.Bookings.ToList() :
                context.Bookings.Where(filter).ToList();
        }
    }
}
