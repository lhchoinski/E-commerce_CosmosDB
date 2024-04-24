using CompanyManagement_API.Models;
using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;

namespace CompanyManagement_API.Data;

public class AppDataContext : DbContext
{
    public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)
    {

    }

    public DbSet<Employee>? Employees { get; set; }
    public DbSet<Customer>? Customers { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseCosmos(
        "URI",
        "PRIMARY KEY",
            "Luiz-DB");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // configuring Employees
        modelBuilder.Entity<Employee>()
                .ToContainer("Employees") 
                .HasPartitionKey(e => e.Id); 

        // configuring Customers
        modelBuilder.Entity<Customer>()
            .ToContainer("Customers") 
            .HasPartitionKey(c => c.Id); 

        // configuring Products
        modelBuilder.Entity<Product>()
            .ToContainer("Products") 
            .HasPartitionKey(p => p.Id); 

        // configuring Orders
        modelBuilder.Entity<Order>()
            .ToContainer("Orders") 
            .HasPartitionKey(o => o.Id); 
    }
}