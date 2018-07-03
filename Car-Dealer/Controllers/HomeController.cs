using Microsoft.AspNetCore.Mvc;
using CarDealer.Models;

namespace CarDealer.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Form()
    {
      return View();
    }
  }
}
