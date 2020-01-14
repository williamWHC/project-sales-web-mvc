using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectWebApiSales.Models.Enums;

namespace ProjectWebApiSales.Models
{
    public class ProjectWebApiSalesContext : DbContext
    {
        public ProjectWebApiSalesContext (DbContextOptions<ProjectWebApiSalesContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        //add DbSet in DbContext 
        public DbSet<SalesRecord> SalesRecords { get; set; }
        public DbSet<Seller> Sellers { get; set; }
    }
}
