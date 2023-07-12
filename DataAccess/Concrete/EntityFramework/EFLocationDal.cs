using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFLocationDal : EFRepository<Location>
    {
        public override List<Location> GetAll(Expression<Func<Location, bool>>? filter = null)
        {
            using var context = new CarRentalDbContext();
            return filter == null ?
                context.Locations.ToList() :
                context.Locations.Where(filter).ToList();
        }
    }
}
