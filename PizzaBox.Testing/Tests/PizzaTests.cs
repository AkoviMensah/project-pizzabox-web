using System.Collections.Generic;
using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Testing.Tests
{
  public class PizzaTests
  {
    [Fact]
    public void Test_PizzaConstructor()
    {
      var sut = new Pizza();

      Assert.NotNull(sut);
    }

    [Fact]
    public void Test_Size()
    {
      var x = "Small";
      var temp = new Size() { Name = x };
      Assert.NotNull(temp.Name == x);
    }
    [Fact]
    public void Test_Topping()
    {
      var x = "onion";
      var temp = new Topping() { Name = x };
      Assert.NotNull(temp.Name == x);
    }
    [Fact]
    public void Test_Order()
    {
      var c = new Crust() { Name = "Original" };
      var s = new Size() { Name = "Small" };
      var t1 = new Topping() { Name = "onion" };
      var t2 = new Topping() { Name = "ham" };
      var p = new Pizza()
      {
        Name = "CustomPizza",
        Crust = c,
        Size = s,
        Toppings = new List<Topping>() { t1, t2 }
      };
      Order o = new Order()
      {
        Customer = new Customer() { Name = "AFI" },
        Store = new Store() { Name = "MadisonStore" },
        Pizzas = new List<Pizza>() { p }
      };
      Assert.NotNull(o.Pizzas.Contains(p));
    }
  }
}