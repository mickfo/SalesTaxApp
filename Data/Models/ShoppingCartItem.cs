﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesTaxApp.Data.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }

        public Product Product { get; set; }

        public int Amount { get; set; }

        public decimal ItemTax { get; set; }

        public string ShoppingCartId { get; set; }
    }
}