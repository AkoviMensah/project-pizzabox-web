using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Order : Entity
  {
    public Customer Customer;
    public Store Store;
    public List<Pizza> Pizzas { get; set; } = new List<Pizza>();
    public override string ToString()
    {
      var temp = "";
      foreach (Pizza p in Pizzas)
      {
        temp += p.ToString();
      }
      return temp;
    }
  }
}