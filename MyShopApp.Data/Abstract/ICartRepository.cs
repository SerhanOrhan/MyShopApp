using MyShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopApp.Data.Abstract
{
   public interface ICartRepository: IRepository<Cart>
    {
        List<Cart> GetAllWithProduct();
        Cart GetByWithProduct(int cartId);
    }
}
