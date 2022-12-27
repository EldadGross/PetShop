using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PetShop.Client.Models;
using PetShop.Data.Model;
using PetShop.Service.Interfaces;
using System.Diagnostics;

namespace PetShop.Client.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly IAnimalService<Animal> animalService;
        public HomeController(IAnimalService<Animal> animalService)
        {
            this.animalService = animalService;
        }

        public async Task<IActionResult> Index()
        {
            var towAnimals = animalService.GetTwoPopulareAnimals();
            return View(await towAnimals);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}