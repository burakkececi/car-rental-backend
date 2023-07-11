using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Location : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public Booking DropOffBooking { get; set; }
        public Booking PickUpBooking { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
