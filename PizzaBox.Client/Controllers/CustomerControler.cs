using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Domain.Models;
using PizzaBox.Storage;
using PizzaBox.Storage.Repositories;

namespace PizzaBox.Client.Controllers
{
  [Route("[controller]")]
  public class CustomerController : Controller
  {
    private readonly UnitOfWork _unitOfWork;

    public CustomerController(UnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }

    [HttpGet]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Index(OrderViewModel order)
    {
      order.Load(_unitOfWork);

      return View("order", order);
    }
  }
}