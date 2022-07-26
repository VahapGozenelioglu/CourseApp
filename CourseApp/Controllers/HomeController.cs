using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CourseApp.Models;
using CourseApp.ViewModels;

namespace CourseApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            int currentHour = DateTime.Now.Hour;
            ViewBag.Greeting = currentHour > 12 ? "Have a nice day" : "Good morning";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            var categories = new List<Category>()
            {
                new Category() {Name = "Category 1"},
                new Category() {Name = "Category 2"},
                new Category() {Name = "Category 3"}
            };

            var products = new List<Product>()
            {
                new Product(){Name = "Product1"},
                new Product(){Name = "Product2"},
                new Product(){Name = "Product3"},
            };
            
            var viewModel = new ProductCategoriesViewModel();
            viewModel.Categories = categories;
            viewModel.Products = products;
            
            return View(viewModel);
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}