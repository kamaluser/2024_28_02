using _2024_28_02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _2024_28_02.Data
{
    public class Brand_Data
    {
        AppDbContext context = new AppDbContext();

        public void InsertBrand(Brand brand)
        {
            context.Brands.Add(brand);
            context.SaveChanges();
        }

        public Brand GetBrandById(int id)
        {
            return context.Brands.Find(id);
        }

        public List<Brand> GetAllBrands()
        {
            var list = context.Brands.ToList();
            return context.Brands.ToList();
        }

        public void DeleteBrand(int id)
        {
            var a = context.Brands.FirstOrDefault(x => x.Id == id);
            if (a != null)
            {
                context.Brands.Remove(a);
                context.SaveChanges();
                Console.WriteLine("Deleted Succesfully");
            }
            else
            {
                Console.WriteLine("Id Not Found!");
            }   
        }

        public void UpdateBrand(int id)
        {
            string name;
            do
            {
                Console.WriteLine("Name:");
                name = Console.ReadLine();
            } while (String.IsNullOrWhiteSpace(name));

            var a = context.Brands.FirstOrDefault(x => x.Id == id);
            if (a != null)
            {
                a.Name = name;
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Id Not Found!");
            }
        }
    }
}
