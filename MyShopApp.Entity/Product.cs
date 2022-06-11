using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopApp.Entity
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public string Description { get; set; }
        public List<Cart> Carts { get; set; }
    }
}
