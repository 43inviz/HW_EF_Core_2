using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_30_08
{
    internal class OrderLines
    {
        public Product Product { get; set; }

        public Orders Order { get; set; }

        public int Id { get; set; }

        public string Initials { get; set; }
    }
}
