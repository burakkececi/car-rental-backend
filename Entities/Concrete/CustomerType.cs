using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class CustomerType : IEntity
    {
        public CustomerType() 
        { 
            Customers = new List<Customer>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public double DiscountRate { get; set; }
        public ICollection<Customer> Customers { get; set; }
    }
}
