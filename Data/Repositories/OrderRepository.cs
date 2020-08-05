using SalesTaxApp.Data.Interfaces;
using SalesTaxApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesTaxApp.Data.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepository(ApplicationContext appDbContext, ShoppingCart shoppingCart)
        {

            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }
        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;
            _appDbContext.Orders.Add(order);

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;

            foreach (var item in shoppingCartItems)
            {
                var orderDetail = new OrderDetail()
                {
                    Amount = item.Amount,
                    ProductId = item.Product.ProductId,
                    OrderId = order.OrderId,
                    Price = item.Product.Price
                };
                _appDbContext.OrderDetails.Add(orderDetail);
            }
            _appDbContext.SaveChanges();
        }
    }
}
