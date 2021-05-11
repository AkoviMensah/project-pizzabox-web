using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Domain.Models;
using PizzaBox.Storage;
using PizzaBox.Storage.Repositories;

namespace PizzaBox.Client.Controllers
{
  [Route("[controller]/[action]")]
  public class CustomerController : Controller
  {
    private readonly UnitOfWork _unitOfWork;
    private Order Order = new Order();

    public CustomerController(UnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }

    [HttpGet]
    public IActionResult Index()
    {
      var order = new CustomerViewModel();
      Order = new Order();

      order.Load(_unitOfWork);

      return View("customer", order);
    }

    [HttpGet]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult start(CustomerViewModel cust)
    {
      var order = new OrderViewModel();

      order.Load(_unitOfWork);
      Order.Customer = _unitOfWork.Customers.Select(c => c.Name == cust.SelectedCustomer).First();
      Order.Store = _unitOfWork.Stores.Select(s => s.Name == cust.SelectedStore).First();
      ViewBag.Order = Order;
      return View("order", order);
    }

    [HttpGet]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(OrderViewModel order)
    {
      if (ModelState.IsValid)
      {
        var crust = _unitOfWork.Crusts.Select(c => c.Name == order.SelectedCrust).First();
        var size = _unitOfWork.Sizes.Select(s => s.Name == order.SelectedSize).First();
        var toppings = new List<Topping>();

        foreach (var item in order.SelectedToppings)
        {
          toppings.Add(_unitOfWork.Toppings.Select(t => t.Name == item).First());
        }

        var newPizza = new Pizza() { Crust = crust, Size = size, Toppings = toppings };
        var newOrder = new Order { Pizzas = new List<Pizza> { newPizza } };
        Order.Pizzas.Add(newPizza);

        _unitOfWork.Orders.Insert(newOrder);
        _unitOfWork.Save();

        ViewBag.Order = Order;

        return View("checkout", Order);
      }

      order.Load(_unitOfWork);

      return View("order", order);
    }
  }
}