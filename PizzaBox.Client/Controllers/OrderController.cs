using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Domain.Models;
using PizzaBox.Storage;
using PizzaBox.Storage.Repositories;
using System;

namespace PizzaBox.Client.Controllers
{
  [Route("[controller]/[action]")]
  public class OrderController : Controller
  {
    private readonly UnitOfWork _unitOfWork;
    private Order Order = new Order();

    public OrderController(UnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }

    [HttpGet]
    public IActionResult Index()
    {
      var cust = new CustomerViewModel();

      cust.Load(_unitOfWork);

      return View("customer", cust);
    }


    [HttpGet]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Menu(CustomerViewModel cust)
    {
        OrderViewModel orderViewModel = new OrderViewModel();
        orderViewModel.Load(_unitOfWork);
        TempData["name"] = cust.SelectedCustomer;
        TempData["store"] = cust.SelectedStore;
        TempData.Keep();
        return View("order", orderViewModel);

      
    }

    [HttpGet]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(OrderViewModel order)
    {
      if (TempData["name"] == null)
      {
        CustomerViewModel cust = new CustomerViewModel();
        cust.Load(_unitOfWork);
        return View("customer", cust);
      }
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
        newOrder.Customer = _unitOfWork.Customers.Select(c => c.Name == TempData["name"].ToString()).First();
        newOrder.Store = _unitOfWork.Stores.Select(s => s.Name == TempData["store"].ToString()).First();
        if (newOrder.Customer == null) newOrder.Customer = new Customer() {Name = TempData["name"].ToString()};

        _unitOfWork.Orders.Insert(newOrder);
        _unitOfWork.Save();

        ViewBag.Order = newOrder;

        return View("placed", newOrder);
      }

      order.Load(_unitOfWork);

      return View("order", order);
    }

    [HttpGet]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Meat(PresetPizzaViewModel pizza)
    {
      pizza = new PresetPizzaViewModel();
      pizza.Load(_unitOfWork);
      var newPizza = pizza.MeatPizza;
      var newOrder = new Order { Pizzas = new List<Pizza> { newPizza } };

      _unitOfWork.Orders.Insert(newOrder);
      _unitOfWork.Save();

      ViewBag.Order = newOrder;

      return View("checkout");
    }

    [HttpGet]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Veggie(PresetPizzaViewModel pizza)
    {
      pizza = new PresetPizzaViewModel();
      pizza.Load(_unitOfWork);
      var newPizza = pizza.VeggiePizza;
      var newOrder = new Order { Pizzas = new List<Pizza> { newPizza } };

      _unitOfWork.Orders.Insert(newOrder);
      _unitOfWork.Save();

      ViewBag.Order = newOrder;

      return View("checkout");
    }
  }
}