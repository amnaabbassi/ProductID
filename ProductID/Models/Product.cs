using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Service.Models
{
    public class Product
    {
        public List<Product> product { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}