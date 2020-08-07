using Microsoft.AspNetCore.Mvc;
using SalesTaxApp.Data.Models;
using SalesTaxApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesTaxApp.Components
{
    public class ShoppingCartSummary : ViewComponent
    {

        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartSummary(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal(),
                ShoppingCartTaxTotal = _shoppingCart.GetShoppingCartTaxTotal()
            };

            return View(shoppingCartViewModel);
        }

    }
}
