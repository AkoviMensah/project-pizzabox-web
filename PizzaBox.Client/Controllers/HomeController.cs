using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Storage;
using PizzaBox.Storage.Repositories;

namespace PizzaBox.Client.Controllers
{
  [Route("[controller]")]
  public class HomeController : Controller
  {
    private readonly UnitOfWork _unitOfWork;

    private CustomerViewModel cvm = new CustomerViewModel();

    public HomeController(UnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }

    [HttpGet]
    public IActionResult Index()
    {
      var customer = new CustomerViewModel();

      customer.Load(_unitOfWork);
      cvm.Load(_unitOfWork);

      return View("Customer", customer);
    }
  }
}