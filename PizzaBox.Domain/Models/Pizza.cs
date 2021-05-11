using System.Collections.Generic;
using System.Text;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Pizza : Entity
  {
    public string Name { get; set; }
    public decimal Price { get; set; }
    public Crust Crust { get; set; }
    public long CrustEntityId { get; set; }
    public Size Size { get; set; }
    public long SizeEntityId { get; set; }
    public Order Order { get; set; }
    public long OrderEntityId { get; set; }
    public List<Topping> Toppings { get; set; }

    public Pizza()
    {
      Name = "MeatPizza";
      Crust = new Crust() { Name = "Original" };
      Price = 18M;
      Size = new Size() { Name = "Large" };
      Toppings = new List<Topping>(){
        new Topping() { Name = "pinapple" },
        new Topping() { Name = "onion" }
      };
    }

    public override string ToString()
    {
      var stringBuilder = new StringBuilder();
      var separator = ", ";

      foreach (var item in Toppings)
      {
        stringBuilder.Append($"{item}{separator}");
      }

      return $"{Name} === {Size} - {Crust} - {stringBuilder.ToString().TrimEnd(separator.ToCharArray())} - ${Price}\n";
    }
  }
}