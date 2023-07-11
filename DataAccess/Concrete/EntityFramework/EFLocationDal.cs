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
    public class EFLocationDal : ILocationDal
    {
        public void Add(Location entity)
        {
            using var context = new CarRentalDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Location entity)
        {
            using var context = new CarRentalDbContext();
            context.Remove(entity);
            context.SaveChangesAsync();
        }

        public Location Get(Expression<Func<Location, bool>> filter)
        {
            using var context = new CarRentalDbContext();
            return context.Set<Location>().FirstOrDefault(filter);
        }

        public List<Location> GetAll(Expression<Func<Location, bool>>? filter = null)
        {
            using var context = new CarRentalDbContext();
            return filter == null ?
                context.Locations.ToList() :
                context.Locations.Where(filter).ToList();

        }

        public void Update(Location entity)
        {
            using var context = new CarRentalDbContext();
            context.Update(entity);
            context.SaveChangesAsync();
        }
    }
}
