using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjectWebApiSales.Models
{
    public class ProjectWebApiSalesContext : DbContext
    {
        public ProjectWebApiSalesContext (DbContextOptions<ProjectWebApiSalesContext> options)
            : base(options)
        {
        }

        public DbSet<ProjectWebApiSales.Models.Department> Department { get; set; }
    }
}
