using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebSales.Models
{
    public class WebSalesContext : DbContext
    {
        public WebSalesContext (DbContextOptions<WebSalesContext> options)
            : base(options)
        {
        }

        public DbSet<WebSales.Models.Department> Department { get; set; }
    }
}
