using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using PizzaBox.Domain.Models;
using PizzaBox.Storage;


namespace PizzaBox.Client.Models
{
  public class OrderViewModel : IValidatableObject
  {
    public List<Customer> Customers { get; set; }
    public List<Store> Stores { get; set; }
    public List<Crust> Crusts { get; set; }
    public List<Size> Sizes { get; set; }
    public List<Topping> Toppings { get; set; }

    [Required(ErrorMessage = "please select a crust")]
    [DataType(DataType.Text)]
    public string SelectedCrust { get; set; }

    [Required(ErrorMessage = "please select a size")]
    [DataType(DataType.Text)]
    public string SelectedSize { get; set; }

    [Required(ErrorMessage = "please select some toppings")]
    public List<string> SelectedToppings { get; set; }

    [Required(ErrorMessage = "please select a store")]
    [DataType(DataType.Text)]
    public string SelectedStore { get; set; }

    [Required(ErrorMessage = "please select a name")]
    [DataType(DataType.Text)]
    public string SelectedCustomer { get; set; }

    public void Load(UnitOfWork unitOfWork)
    {
      Crusts = unitOfWork.Crusts.Select(c => !string.IsNullOrWhiteSpace(c.Name)).ToList();
      Sizes = unitOfWork.Sizes.Select(s => !string.IsNullOrWhiteSpace(s.Name)).ToList();
      Toppings = unitOfWork.Toppings.Select(t => !string.IsNullOrWhiteSpace(t.Name)).ToList();
      Stores = unitOfWork.Stores.Select(s => !string.IsNullOrWhiteSpace(s.Name)).ToList();
      Customers = unitOfWork.Customers.Select(c => !string.IsNullOrWhiteSpace(c.Name)).ToList();
    }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
      if (SelectedToppings.Count < 2 || SelectedToppings.Count > 5)
      {
        yield return new ValidationResult("please select at least 2, but no more than 5 toppings", new[] { "SelectedToppings" });
      }
    }
  }
}