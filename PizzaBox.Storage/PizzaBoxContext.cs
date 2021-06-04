using System.Linq;
using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage
{
  public class PizzaBoxContext : DbContext
  {
    public DbSet<Crust> Crusts { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Pizza> Pizzas { get; set; }
    public DbSet<Size> Sizes { get; set; }
    public DbSet<Topping> Toppings { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Store> Stores { get; set; }

    public PizzaBoxContext(DbContextOptions options) : base(options) { }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="builder"></param>
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Crust>().HasKey(e => e.EntityId);
      builder.Entity<Order>().HasKey(e => e.EntityId);
      builder.Entity<Pizza>().HasKey(e => e.EntityId);
      builder.Entity<Size>().HasKey(e => e.EntityId);
      builder.Entity<Topping>().HasKey(e => e.EntityId);
      builder.Entity<Customer>().HasKey(e => e.EntityId);
      builder.Entity<Store>().HasKey(e => e.EntityId);

      OnModelSeeding(builder);
    }

    private void OnModelSeeding(ModelBuilder builder)
    {
      builder.Entity<Crust>().HasData(new[]
      {
        new Crust() { EntityId = 1, Name = "original" },
        new Crust() { EntityId = 2, Name = "stuffed" },
        new Crust() { EntityId = 3, Name = "flatbread" },
        new Crust() { EntityId = 4, Name = "thin" },
        new Crust() { EntityId = 5, Name = "italian" }
      });

      builder.Entity<Size>().HasData(new[]
      {
        new Size() { EntityId = 1, Name = "small" },
        new Size() { EntityId = 2, Name = "medium" },
        new Size() { EntityId = 3, Name = "large"}
      });

      builder.Entity<Topping>().HasData(new[]
      {
        new Topping() { EntityId = 1, Name = "pepperoni" },
        new Topping() { EntityId = 2, Name = "pineapple" },
        new Topping() { EntityId = 3, Name = "ham" },
        new Topping() { EntityId = 4, Name = "green peppers" },
        new Topping() { EntityId = 5, Name = "black olives" }
      });

      builder.Entity<Store>().HasData(new[]
      {
        new Store() { EntityId = 1, Name = "ChicagoStore" },
        new Store() { EntityId = 2, Name = "MadisonStore" },
        new Store() { EntityId = 3, Name = "NewYorkStore" },
      });

      builder.Entity<Customer>().HasData(new[]
      {
        new Customer() { EntityId = 1, Name = "RONALDO" },
        new Customer() { EntityId = 2, Name = "REBECCA" },
        new Customer() { EntityId = 3, Name = "MESSI" },
        new Customer() { EntityId = 4, Name = "NEYMAR" }
      });
    }
  }
}