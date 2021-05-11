using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using PizzaBox.Domain.Models;
using PizzaBox.Storage;
using PizzaBox.Storage.Repositories;

namespace PizzaBox.Client.Models
{
  public class StoreViewModel
  {
    public List<Customer> Customers { get; set; }
    public List<Store> Stores { get; set; }
    public List<Order> Orders { get; set; }


    [Required(ErrorMessage = "please select a store")]
    [DataType(DataType.Text)]
    public string SelectedStore { get; set; }

    [Required(ErrorMessage = "please enter your name")]
    [DataType(DataType.Text)]
    public string SelectedCustomer { get; set; }

    [Required(ErrorMessage = "please choose a pizza")]
    public string SelectedPizza { get; set; }

    public void Load(UnitOfWork unitOfWork)
    {
      Stores = unitOfWork.Stores.Select(s => !string.IsNullOrWhiteSpace(s.Name)).ToList();
      Customers = unitOfWork.Customers.Select(c => !string.IsNullOrWhiteSpace(c.Name)).ToList();
      Orders = unitOfWork.Orders.Select(o => !string.IsNullOrWhiteSpace(o.ToString())).ToList();
    }

    public bool IsCompleted()
    {
      return ((SelectedCustomer != null) && (SelectedStore != null));
    }


  }
}