using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Billing
    {
        public int Id { get; set; }
        public int BookingId { get; set; }
        public int PaymentId { get; set; }
        public DateTime CreatedAt { get; set; }
        public decimal TotalFee { get; set; }
        public decimal TotalLateFee { get; set; }
        public Payment Payment { get; set; }
        public Booking Booking { get; set; }
    }
}
