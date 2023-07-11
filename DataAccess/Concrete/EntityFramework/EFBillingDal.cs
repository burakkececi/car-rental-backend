using DataAccess.Abstract;
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
    public class EFBillingDal : IBillingDal
    {
        public void Add(Billing entity)
        {
            using var context = new CarRentalDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Billing entity)
        {
            using var context = new CarRentalDbContext();
            context.Remove(entity);
            context.SaveChangesAsync();
        }

        public Billing Get(Expression<Func<Billing, bool>> filter)
        {
            using var context = new CarRentalDbContext();
            return context.Set<Billing>().SingleOrDefault(filter);
        }

        public List<Billing> GetAll(Expression<Func<Billing, bool>>? filter = null)
        {
            //using var context = new CarRentalDbContext();
            //return filter == null ?
            //    context.Billings.ToList() :
            //    context.Billings.Where(filter).ToList();
            throw new NotImplementedException();
        }

        public void Update(Billing entity)
        {
            using var context = new CarRentalDbContext();
            context.Update(entity);
            context.SaveChangesAsync();
        }
    }
}
