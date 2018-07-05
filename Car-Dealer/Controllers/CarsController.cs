using Microsoft.AspNetCore.Mvc;
using CarDealer.Models;

namespace CarDealer.Controllers
{
  public class CarsController : Controller
  {

    [HttpGet("/Cars")]
    public ActionResult Car()
    {
      // Cars newCars = new Cars(Request.Query["car-make"]);
      // newCars.Save();
      return View(Cars.GetAll());
      // return View();
    }
    [HttpGet("/Cars/new")]
    public ActionResult Form()
    {
      return View();
    }
    [HttpPost("/cars")]
    public ActionResult Create()
    {
      Cars newCars = new Cars(Request.Form["car-make"]);
      newCars.Save();
      return View("Car", Cars.GetAll());
    }
    [HttpGet("/Cars/Details")]
    public ActionResult Details()
    {
      return View();
    }
  }
}
