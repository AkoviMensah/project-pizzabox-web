using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Order : Entity
  {

    public List<Pizza> Pizzas { get; set; }
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