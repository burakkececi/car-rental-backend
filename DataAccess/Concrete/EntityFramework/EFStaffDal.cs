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
    public class EFStaffDal : IStaffDal
    {
        public void Add(Staff entity)
        {
            using var context = new CarRentalDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Staff entity)
        {
            using var context = new CarRentalDbContext();
            context.Remove(entity);
            context.SaveChangesAsync();
        }

        public Staff Get(Expression<Func<Staff, bool>> filter)
        {
            using var context = new CarRentalDbContext();
            return context.Set<Staff>().SingleOrDefault(filter);
        }

        public List<Staff> GetAll(Expression<Func<Staff, bool>>? filter = null)
        {
            using var context = new CarRentalDbContext();
            //return filter == null ?
            //context.Staffs.ToList() :
            //context.Staffs.Where(filter).ToList();
            throw new NotImplementedException();

        }

        public void Update(Staff entity)
        {
            using var context = new CarRentalDbContext();
            context.Update(entity);
            context.SaveChangesAsync();
        }
    }
}
