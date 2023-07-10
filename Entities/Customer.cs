using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Customer
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; } = string.Empty;
        public string LastName { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public long Phone { get; set; }
        public string LicenceClass { get; set; }
        public DateTime LicenceExpirationDate { get; set; }
        
        public virtual CustomerType CustomerType { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual Car Car { get; set; }
        public virtual Booking Booking { get; set; }
    }
}
