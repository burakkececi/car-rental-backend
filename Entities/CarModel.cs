using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CarModel
    {
        public int Id { get; set; }
        public string Maker { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public int Year { get; set; }
        public decimal CostPerDay { get; set; }
        public decimal LateFeePerHour { get; set; }
        public ICollection<Car> Cars { get; set;}
    }
}
