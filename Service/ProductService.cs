

using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Service.Service
{
    public class ProductService : IProductRepository
    {
        
        private ProductEntities db = new ProductEntities();

        public List<Product> GetAll()
        {
            return db.Product.ToList();
        }

        public Product GetById(int id)
        {
            return db.Product.FirstOrDefault(p => p.Id == id);
        }

        public void Add(Product product)
        {
            db.Product.Add(product);
            db.SaveChanges();
        }

        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (db != null)
                {
                    db.Dispose();
                    db = null;
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}