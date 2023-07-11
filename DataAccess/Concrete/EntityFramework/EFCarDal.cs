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
    public class EFCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using var context = new CarRentalDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Car entity)
        {
            using var context = new CarRentalDbContext();
            context.Remove(entity);
            context.SaveChangesAsync();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using var context = new CarRentalDbContext();
            return context.Set<Car>().FirstOrDefault(filter);
        }

        public List<Car> GetAll(Expression<Func<Car, bool>>? filter = null)
        {
            using var context = new CarRentalDbContext();
            return filter == null ?
            context.Cars.ToList() :
            context.Cars.Where(filter).ToList();

        }

        public void Update(Car entity)
        {
            using var context = new CarRentalDbContext();
            context.Update(entity);
            context.SaveChangesAsync();
        }
    }
}
