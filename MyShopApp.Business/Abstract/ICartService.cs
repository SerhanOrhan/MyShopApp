using MyShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopApp.Business.Abstract
{
    public interface ICartService
    {
        Cart GeyById(int id);
        List<Cart> GetAll();
        void Create(Cart entity);
        void Update(Cart entity);
        void Delete(Cart entity);
        List<Cart> GetAllWithProduct();
        Cart GetByWithProduct(int cart);
        Cart GetProductMatch(int productId);


    }
}
