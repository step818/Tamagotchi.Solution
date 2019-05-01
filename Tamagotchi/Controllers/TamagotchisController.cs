using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Tamagotchi.Models;


namespace Tamagotchi.Controllers
{
  public class TamagotchisController : Controller
  {

    [HttpGet("/tamagotchis")]
    public ActionResult Index()
    {
      List<Pet> collection = Pet.GetAll();
      return View(collection);
    }

    [HttpGet("/tamagotchis/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/tamagotchis")]
    public ActionResult Create(string name, int foodLevel, int attentionLevel, int restLevel)
    {
      Pet newPet = new Pet(name, foodLevel, attentionLevel, restLevel);
      return RedirectToAction("Index");
    }

    [HttpGet("/tamagotchis/{id}")]
    public ActionResult Show(int id)
    {
      Pet pet = Pet.Find(id);
      return View(pet);
    }

  }
}
