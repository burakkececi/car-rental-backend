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
    public class EFBookingDal : IBookingDal
    {
        public void Add(Booking entity)
        {
            using var context = new CarRentalDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Booking entity)
        {
            using var context = new CarRentalDbContext();
            context.Remove(entity);
            context.SaveChangesAsync();
        }

        public Booking Get(Expression<Func<Booking, bool>> filter)
        {
            using var context = new CarRentalDbContext();
            return context.Set<Booking>().SingleOrDefault(filter);
        }

        public List<Booking> GetAll(Expression<Func<Booking, bool>>? filter = null)
        {
            using var context = new CarRentalDbContext();
            //return filter == null ?
            //context.Bookings.ToList() :
            //context.Bookings.Where(filter).ToList();
            throw new NotImplementedException();

        }

        public void Update(Booking entity)
        {
            using var context = new CarRentalDbContext();
            context.Update(entity);
            context.SaveChangesAsync();
        }
    }
}
