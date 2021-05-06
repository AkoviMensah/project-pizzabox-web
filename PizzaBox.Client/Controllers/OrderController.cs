using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;

namespace PizzaBox.Client.Controllers
{
  [Route("[controller]")]
  public class OrderController : Controller
  {
    [HttpGet]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public string Create(OrderViewModel order)
    {
      // var o = order != null;

      if (ModelState.IsValid)
      {
        return "ggod request";
      }

      return "bad request";
    }
  }
}