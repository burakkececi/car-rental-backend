using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        public int Id { get; set; }
        public int CarModelId { get; set; }
        public int LocationId { get; set; }
        public string PolicyNumber { get; set; }
        public DateTime PolicyExpirationDate { get; set; }
        public bool IsAvailable { get; set; }
        public long Mileage { get; set; }
        public int Year { get; set; }
        public double CostPerDay { get; set; }
        public double LateFeePerHour { get; set; }
        public int Rating { get; set; }

        public virtual CarModel CarModel { get; set; }
        public virtual Location Location { get; set; }
        public virtual Booking Booking { get; set; }
    }
}
