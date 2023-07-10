using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Payment
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public ICollection<Billing> Billings { get; set; }
    }
}
