using Microsoft.AspNetCore.Mvc;
using System.Collections.Genreic;
using Tamagotchi.Models;

namespace Tamagotchi.Controllers
{
  public class TamagotchisController : Controller
  {

    [HttpGet("/tamagotchis")]
    public ActionResult Index()
    {
      List<Tamagotchi> allTamagotchis = Tamagotchi.GetAll();
      return View(allTamagotchis);
    }

    [HttpGet("/tamagotchis/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/items")]
    public ActionResult Create(string name)
    {
      Tamagotchi newPet = new Tamagotchi(name);
      return RedirectToAction("Index");
    }

    [HttpGet("/items/{id}")]
    public ActionResult Show(int id)
    {
      Tamagotchi petId = Tamagotchi.Find(id);
      return View(petId);
    }

  }
}
