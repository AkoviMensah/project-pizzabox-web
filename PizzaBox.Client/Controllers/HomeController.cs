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

    public HomeController(UnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }

    [HttpGet]
    public IActionResult Index()
    {
      //ViewBag.Order = new OrderViewModel();
      //ViewData
      //TempData

      var view = View("index", new OrderViewModel(_unitOfWork));

      return view;
    }
  }
}