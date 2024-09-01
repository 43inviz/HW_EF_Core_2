using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_30_08
{
    internal class Orders
    {
        public int Id { get; set; }

        public DateTime DateTime { get; set; }
        public string Name { get; set; }

        public List<OrderLines> OrderLines { get; set; } = new List<OrderLines>();
        
    }
}
