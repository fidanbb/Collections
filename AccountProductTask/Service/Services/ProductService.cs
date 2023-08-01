using AccountProductTask.Models;
using AccountProductTask.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountProductTask.Services
{
    public class ProductService : IProductService
    {
        public List<Product> GetAll()
        {
            List<Product> products = new List<Product>();

            products.Add(new Product { Id = 1, Name = "Iphone14", Price = 2000, Count = 5 });
            products.Add(new Product { Id = 2, Name = "Samsung", Price = 1500, Count = 10 });
            products.Add(new Product { Id = 3, Name = "Nokia", Price = 120, Count = 4 });
            products.Add(new Product { Id = 4, Name = "Ipad", Price = 3000, Count = 8 });
            products.Add(new Product { Id = 5, Name = "Macbook", Price = 4000, Count = 15 });

            return products;
        }

    }
}
