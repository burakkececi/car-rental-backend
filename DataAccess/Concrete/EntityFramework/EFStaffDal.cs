using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFStaffDal : EFRepository<Staff>
    {
        public override List<Staff> GetAll(Expression<Func<Staff, bool>>? filter = null)
        {
            using var context = new CarRentalDbContext();
            return filter == null ?
                context.Staffs.ToList() :
                context.Staffs.Where(filter).ToList();
        }
    }
}
