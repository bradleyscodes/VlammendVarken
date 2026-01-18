using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitaalBestelsysteem
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string? Category { get; set; } 
        public string? Description { get; set; } 
        public bool IsFavoriteDishOfTheDay { get; set; } = false;

        //Constructor
        public MenuItem(int id, string name, decimal price, string category, string description, bool isFavoriteDishOfTheDay = false)
        {
            Id = id;
            Name = name;
            Price = price;
            Category = category;
            Description = description;
            IsFavoriteDishOfTheDay = isFavoriteDishOfTheDay;
        }
    }
}
