using Microsoft.AspNetCore.Mvc;
using SalesTaxApp.Data.Interfaces;
using SalesTaxApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesTaxApp.Controllers
{
    public class HomeController : Controller
    {

        private readonly IProductRepository _productRepository;

        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                Greeting = "Hello Friend"
            };
            return View(homeViewModel);
        }

    }
}
