using MyShopApp.Data.Abstract;
using MyShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopApp.Data.Concrete
{
   public class EfCoreProductRepository : EfCoreGenericRepository<Product,MyShopContext>,IProductRepository
    {
    }
}
