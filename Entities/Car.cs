using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Car
    {
        public int Id { get; set; }
        public long CustomerId { get; set; }
        public string PolicyNumber { get; set; }
        public DateTime PolicyExpirationDate { get; set; }
        public bool IsAvailable { get; set; }
        public long Mileage { get; set; }
        public int Rating { get; set; }

        public virtual CarModel CarModel { get; set; }
        public virtual Location Location { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Booking Booking { get; set; }
    }
}
