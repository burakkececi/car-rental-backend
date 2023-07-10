using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public ICollection<Booking> DropOffBookings { get; set; }
        public ICollection<Booking> PickUpBookings { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
