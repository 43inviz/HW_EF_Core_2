using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_30_08
{
    internal class ApplicationContext:DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Orders> Orders { get; set; }

        public DbSet<OrderLines> OrderLines { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-R3LQDV9; Database = Shop; Trusted_Connection = True; TrustServerCertificate = True");
        }

    }
}
