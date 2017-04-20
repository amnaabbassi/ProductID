

using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Service.Service
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        Product GetById(int id);
        void Add(Product product);
    }
}