using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCarModelDal : EFRepository<CarModel>
    {
        public override List<CarModel> GetAll(Expression<Func<CarModel, bool>>? filter = null)
        {
            using var context = new CarRentalDbContext();
            return filter == null ?
                context.CarModels.ToList() :
                context.CarModels.Where(filter).ToList();
        }
    }
}
