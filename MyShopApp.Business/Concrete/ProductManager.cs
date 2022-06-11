using MyShopApp.Business.Abstract;
using MyShopApp.Data.Abstract;
using MyShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopApp.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductRepository _productRepository;

        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            _productRepository.Delete(entity);
        }

        public List<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public Product GeyById(int id)
        {
            return _productRepository.GetById(id);
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
