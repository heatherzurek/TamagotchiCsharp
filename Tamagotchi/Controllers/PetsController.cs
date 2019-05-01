using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;
using System.Collections.Generic;

namespace Tamagotchi.Controllers
{
  public class PetsController : Controller
  {

    [HttpGet("/pets")]
    public ActionResult Index()
    {
      List<Pet> myPets = Pet.GetAll();
      return View(myPets);
    }

    [HttpGet("/pets/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/pets")]
    public ActionResult Create(string name)
    {
      Pet myPet = new Pet(name);
      return RedirectToAction("Index");
    }
    // [HttpGet("/items")]
    // public ActionResult Index()
    // {
    //   List<Item> allItems = Item.GetAll();
    //   return View(allItems);
    // }
    //
    // [HttpGet("/items/new")]
    // public ActionResult CreateForm()
    // {
    //   return View();
    // }
    //
    // [HttpPost("/items")]
    // public ActionResult Create(string description)
    // {
    //   Item myItem = new Item(description);
    //   return RedirectToAction("Index");
    // }
    //
    // [HttpPost("/items/delete")]
    // public ActionResult DeleteAll()
    // {
    //   Item.ClearAll();
    //   return View();
    // }

  }
}
