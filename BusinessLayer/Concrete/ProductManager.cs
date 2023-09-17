using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        EfProductRepository efProductRepository;

        public ProductManager()
        {
            efProductRepository = new EfProductRepository();
        }
        public void DeleteProduct(Product product)
        {
           efProductRepository.Delete(product);
        }

        public List<Product> GetAllProducts()
        {
           return efProductRepository.GetList();
        }

        public Product GetProductById(int id)
        {
            return efProductRepository.GetById(id);
        }

        public void InsertProduct(Product product)
        {
            efProductRepository.Insert(product);
        }

        public void UpdateProduct(Product product)
        {
            efProductRepository.Update(product);
        }
    }
}
