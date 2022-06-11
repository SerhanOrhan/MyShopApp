using MyShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShopApp.WebUI.Models
{
    public class ProductCartModel
    {
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get { return this.TotalPrice; } set { this.TotalPriceCalculation(); } }

        private double TotalPriceCalculation()
        {
            return this.Quantity * (double)this.Product.Price;
        }
    }
}
