using DytronCustomers.Models;
using Microsoft.EntityFrameworkCore;

namespace DytronCustomers.Data
{
    public class CustomerContext: DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options){}
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Customer>().HasData(
                Enumerable.Range(1, 20).Select(i => new Customer
                {
                    FirstName = $"First-{i}",
                    LastName = $"Last-{i}",
                    Email = $"customer{i}@example.com",
                    CreatedDate = DateTime.Now,
                    LastUpdatedDate = DateTime.Now
                }).ToArray()
                );
        }
    }
}
