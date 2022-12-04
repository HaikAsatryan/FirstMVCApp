using Microsoft.AspNetCore.Mvc;
using FirstMVCApp.Models;

namespace FirstMVCApp.Controllers;

public class DogSoftController : Controller
{
    private static List<DogViewModel> dogs = new List<DogViewModel>();

    public IActionResult Index()
    {
        //var doggo = new DogViewModel() { Name = "Sif", Age = 2 };
        return View(dogs);
    }

    public IActionResult Create()
    {
        var dogVm = new DogViewModel();
        return View(dogVm);
    }

    public IActionResult CreateDog(DogViewModel dogViewModel)
    {
        dogs.Add(dogViewModel);
        return RedirectToAction(nameof(Index));
    }

    public string Hello()
    {
        return "Who's there?";
    }
}