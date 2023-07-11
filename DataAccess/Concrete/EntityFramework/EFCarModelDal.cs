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
    public class EFCarModelDal : ICarModelDal
    {
        public void Add(CarModel entity)
        {
            using var context = new CarRentalDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(CarModel entity)
        {
            using var context = new CarRentalDbContext();
            context.Remove(entity);
            context.SaveChangesAsync();
        }

        public CarModel Get(Expression<Func<CarModel, bool>> filter)
        {
            using var context = new CarRentalDbContext();
            return context.Set<CarModel>().SingleOrDefault(filter);
        }

        public List<CarModel> GetAll(Expression<Func<CarModel, bool>>? filter = null)
        {
            using var context = new CarRentalDbContext();
            //return filter == null ?
                //context.CarModels.ToList() :
                //context.CarModels.Where(filter).ToList();
                throw new NotImplementedException();
        }

        public void Update(CarModel entity)
        {
            using var context = new CarRentalDbContext();
            context.Update(entity);
            context.SaveChangesAsync();
        }
    }
}
