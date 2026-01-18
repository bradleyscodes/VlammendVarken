using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitaalBestelsysteem
{
    public class MenuItem : Product
    {
        public string Category { get; set; } 
        public string Description { get; set; } 
        public bool IsFavoriteDishOfTheDay { get; set; } = false;

        //Constructor
        public MenuItem(int id, string name, decimal price, string category, string description, bool isFavoriteDishOfTheDay = false) 
            : base(id, name, price)
        {
            Category = category;
            Description = description;
            IsFavoriteDishOfTheDay = isFavoriteDishOfTheDay;
        }
    }
}
