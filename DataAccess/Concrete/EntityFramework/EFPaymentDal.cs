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
    public class EFPaymentDal : IPaymentDal
    {
        public void Add(Payment entity)
        {
            using var context = new CarRentalDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Payment entity)
        {
            using var context = new CarRentalDbContext();
            context.Remove(entity);
            context.SaveChangesAsync();
        }

        public Payment Get(Expression<Func<Payment, bool>> filter)
        {
            using var context = new CarRentalDbContext();
            return context.Set<Payment>().SingleOrDefault(filter);
        }

        public List<Payment> GetAll(Expression<Func<Payment, bool>>? filter = null)
        {
            using var context = new CarRentalDbContext();
            //return filter == null ?
            //context.Payments.ToList() :
            //context.Payments.Where(filter).ToList();
            throw new NotImplementedException();

        }

        public void Update(Payment entity)
        {
            using var context = new CarRentalDbContext();
            context.Update(entity);
            context.SaveChangesAsync();
        }
    }
}
