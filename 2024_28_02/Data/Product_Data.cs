using _2024_28_02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_28_02.Data
{
    public class Product_Data
    {

        AppDbContext context = new AppDbContext();
        public void InsertProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }

        public Product GetProductById(int id)
        {
            return context.Products.Find(id);
        }

        public List<Product> GetAllProducts()
        {
            var list = context.Products.ToList();
            return list;
        }
    }
}
