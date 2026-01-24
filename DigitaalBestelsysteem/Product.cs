using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitaalBestelsysteem
{
    public class Product
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; }
        public decimal Price { get; set; }

        //Constructor
        public Product(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
            
    }
}
