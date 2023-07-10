using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Booking
    {
        public int Id { get; set; }
        public long CustomerId { get; set; }
        public int CarId { get; set; }

        public int DropOffLocId { get; set; }
        public int PickUpLocId { get; set; }

        public DateTime From { get; set; }
        public DateTime Return { get; set; }
        public DateTime ActualReturn { get; set; }

        public virtual Location DropOffLoc { get; set; } 
        public virtual Location PickUpLoc { get; set; }   

        public virtual Billing Billing { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Car Car { get; set; }
    }
}
