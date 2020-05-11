using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationTest.Interfaces;

namespace WebApplicationTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICoffeeRepository _coffeeRepository;
        public HomeController(ICoffeeRepository coffeeRepository)
        {
            _coffeeRepository = coffeeRepository;
        }
        public IActionResult Index()
        {
            ViewBag.Title = "Welcome";

            var coffees = _coffeeRepository.GetAllCoffees().OrderBy(c => c.Name);
            return View(coffees);
        }
    }
}