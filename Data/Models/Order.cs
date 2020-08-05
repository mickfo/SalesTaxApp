using LinqToDB.DataProvider.SapHana;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesTaxApp.Data.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public List<OrderDetail> OrderLines { get; set; }

        public decimal OrderTotal { get; set; }

        public decimal TaxTotal { get; set; }

        public DateTime OrderPlaced { get; set; }
    }
}
