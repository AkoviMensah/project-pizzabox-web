using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Models;
using PizzaBox.Storage;


namespace PizzaBox.Client.Models
{
  public class PresetPizzaViewModel
  {
    public Pizza VeggiePizza;

    public Pizza MeatPizza;

    public void Load(UnitOfWork unitOfWork)
    {
      VeggiePizza = new Pizza();
      MeatPizza = new Pizza();
      VeggiePizza.Name = "VeggiePizza";
      MeatPizza.Name = "MeatPizza";
      MeatPizza.Crust = unitOfWork.Crusts.Select(c => c.Name == "original").First();
      VeggiePizza.Crust = unitOfWork.Crusts.Select(c => c.Name == "original").First();
      MeatPizza.Size = unitOfWork.Sizes.Select(s => s.Name == "medium").First();
      VeggiePizza.Size = unitOfWork.Sizes.Select(s => s.Name == "small").First();
      VeggiePizza.Toppings = new List<Topping>();
      MeatPizza.Toppings = new List<Topping>();
      VeggiePizza.Toppings.Add(unitOfWork.Toppings.Select(t => t.Name == "pineapple").First());
      VeggiePizza.Toppings.Add(unitOfWork.Toppings.Select(t => t.Name == "green peppers").First());
      MeatPizza.Toppings.Add(unitOfWork.Toppings.Select(t => t.Name == "ham").First());
      MeatPizza.Toppings.Add(unitOfWork.Toppings.Select(t => t.Name == "pepperoni").First());


    }
  }
}