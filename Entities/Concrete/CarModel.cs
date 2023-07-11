using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CarModel : IEntity
    {
        public CarModel()
        {
            Cars = new List<Car>();
        }
        public int Id { get; set; }
        public string Maker { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
