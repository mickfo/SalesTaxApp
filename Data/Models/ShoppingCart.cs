using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesTaxApp.Data.Models
{
    public class ShoppingCart
    {

        private readonly ApplicationContext _appDbContext;

        public ShoppingCart(ApplicationContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public string ShoppingCartId { get; set; }
        
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;

            var context = services.GetService<ApplicationContext>();
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);

            return new ShoppingCart(context) { ShoppingCartId = cartId };
        }

        public void AddToCart(Product product, int amount)
        {

            var shoppingCartItem =
                _appDbContext.ShoppingCartItems.SingleOrDefault(
                    s => s.Product.ProductId == product.ProductId && s.ShoppingCartId == ShoppingCartId);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Product = product,
                    Amount = 1
                };

                _appDbContext.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }

            shoppingCartItem.ItemTax = CalculateTax(product, shoppingCartItem.Amount);

            _appDbContext.SaveChanges();
        }

        public int RemoveFromCart(Product product)
        {
            var shoppingCartItem =
                _appDbContext.ShoppingCartItems.SingleOrDefault(
                    s => s.Product.ProductId == product.ProductId && s.ShoppingCartId == ShoppingCartId);
            var localAmount = 0;

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else 
                {
                    _appDbContext.ShoppingCartItems.Remove(shoppingCartItem);
                }

                shoppingCartItem.ItemTax = CalculateTax(product, shoppingCartItem.Amount);

                _appDbContext.SaveChanges();

             }

            return localAmount;
        }

        public decimal CalculateTax(Product product, int amount)
        {
            decimal itemTax = 0.00M;
            decimal taxRate = 0.10M;

            if (product.IsMedical || product.IsFood || product.Name == "Book")
            {
                taxRate = 0.00M;
            }
            
            if (product.IsImport)
            {
                taxRate = taxRate + .05M;
            }

            itemTax = Math.Ceiling(product.Price * taxRate * 20) / 20; // tax round up to the nickel.

            return itemTax * amount;
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ??
                (ShoppingCartItems =
                    _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                        .Include(s => s.Product)
                        .ToList());

        }

        public void ClearCart()
        {
            var cartItems = _appDbContext
                .ShoppingCartItems
                .Where(cart => cart.ShoppingCartId == ShoppingCartId);

            _appDbContext.ShoppingCartItems.RemoveRange(cartItems);

            _appDbContext.SaveChanges();
        }

        public decimal GetShoppingCartTotal()
        {
            var total = _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                .Select(c => (c.Product.Price * c.Amount) + c.ItemTax).Sum();
            return total;
        }

        public decimal GetShoppingCartTaxTotal()
        {
            var taxTotal = _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                .Select(c => c.ItemTax).Sum();
            return taxTotal;
        }

        public decimal GetShoppingCartCount()
        {
            var taxTotal = _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                .Select(c => c.Amount).Sum();
            return taxTotal;
        }
    }
}
