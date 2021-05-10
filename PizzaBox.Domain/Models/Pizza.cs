using System.Collections.Generic;
using System.Text;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Pizza : Entity
  {
    public string Name { get; set; }
    public decimal Price { get; set; } = 15M;
    public Crust Crust
    { get; set; }
    public long CrustEntityId { get; set; }
    public Size Size { get; set; }
    public long SizeEntityId { get; set; }
    public Order Order { get; set; }
    public long OrderEntityId { get; set; }
    public List<Topping> Toppings { get; set; }

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