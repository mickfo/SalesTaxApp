using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesTaxApp.Data.Interfaces;
using SalesTaxApp.ViewModels;

namespace SalesTaxApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public ViewResult List()
        {
            ViewBag.Name = "Product: ";
            //var products = _productRepository.Products;
            ProductListViewModel vm = new ProductListViewModel();
            vm.Products = _productRepository.Products;
            return View(vm);
        }
    }
}
