using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindWithLinq.Models
{
    public class NorthwindContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<CustomerCustomersDemo> CustomerCustomersDemo { get; set; }



        public NorthwindContext() { } //only needed for console apps
        public NorthwindContext(DbContextOptions<NorthwindContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            string connectionString = @"server=localhost\sqlexpress01;" +
                                      "database=Northwind;" +
                                      "trusted_connection=true;";
            if(!builder.IsConfigured)
            {
                builder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {           //both columns have PK
                    //builder.Entity says which table are we working on?
            builder.Entity<OrderDetail>(p =>
            {               //same as Select New {columns you want}
                p.HasKey(x => new { x.OrderId, x.ProductId });
            });
            builder.Entity<CustomerCustomersDemo>(q =>
            {
                q.HasKey(z => new { z.CustomerID, z.CustomerTypeID });
            });
        }
    }
}
