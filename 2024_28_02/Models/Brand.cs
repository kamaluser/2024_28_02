using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_28_02.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }

        public override string ToString()
        {
            return $"Id - {Id}, Name - {Name}";
        }
    }
}
