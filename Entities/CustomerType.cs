﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CustomerType : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal DiscountRate { get; set; }
        public ICollection<Customer> Customers { get; set; }
    }
}
