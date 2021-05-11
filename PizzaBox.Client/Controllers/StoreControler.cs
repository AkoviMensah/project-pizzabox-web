using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Domain.Models;
using PizzaBox.Storage;

namespace PizzaBox.Client.Controllers
{
  [Route("[controller]")]
  public class StoreController : Controller
  {
    private readonly UnitOfWork _unitOfWork;

    public StoreController(UnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }

    [HttpGet]
    public IActionResult Index()
    {
      var store = new StoreViewModel();
      store.Load(_unitOfWork);
      return View("store");
    }

    [HttpGet]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult ListOrders(StoreViewModel store)
    {
      var s = _unitOfWork.Stores.Select(s => s.Name == store.SelectedStore).First();
      ViewBag.Store = s;
      store.Load(_unitOfWork);
      return View("order", store);
    }
  }
}