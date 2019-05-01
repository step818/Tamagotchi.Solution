using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;

namespace Tamagotchi.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    {
      Pet newPet = new Pet("Panatda", 5, 5, 5);
      return View(newPet);
    }
  }
}
