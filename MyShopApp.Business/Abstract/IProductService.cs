using MyShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopApp.Business.Abstract
{
    public interface IProductService
    {
        Product GeyById(int id);
        List<Product> GetAll();
        void Create(Product entity);
        void Update(Product entity);
        void Delete(Product entity);
    }
}
