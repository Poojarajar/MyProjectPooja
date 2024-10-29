using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using ProductMicroservices.DBContexts;
using ProductMicroservices.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ProductMicroservices.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _dbContext;

        public ProductRepository(ProductContext dbContext)// constructor
        {
            _dbContext = dbContext;
        }

        public void DeleteProduct(int ProductId)
        {
            var product = _dbContext.Products.Find(ProductId);
            _dbContext.Products.Remove(product);
            Save();
            //throw new NotImplementedException();
        }

        public Product GetProductById(int ProductId)
        {
            return _dbContext.Products.Find(ProductId);
            //throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProducts()
        {
            return _dbContext.Products.ToList();
            //throw new NotImplementedException();
        }

        public void InsertProduct(Product Product)
        {
            _dbContext.Add(Product);
            Save();

            //throw new NotImplementedException();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
            //throw new NotImplementedException();
        }

        public void UpdateProduct(Product Product)
        {
            _dbContext.Entry(Product).State = EntityState.Modified;
            Save();

            //throw new NotImplementedException();
        }

        
    }
}
