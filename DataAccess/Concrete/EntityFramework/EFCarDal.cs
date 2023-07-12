using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCarDal : EFRepository<Car>
    {
        public override List<Car> GetAll(Expression<Func<Car, bool>>? filter = null)
        {
            using var context = new CarRentalDbContext();
            return filter == null ?
                context.Cars.ToList() :
                context.Cars.Where(filter).ToList();
        }
    }
}
