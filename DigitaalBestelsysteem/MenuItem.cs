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

        // Default constructor
        public MenuItem() 
            : base(0, string.Empty, 0m) { Category = string.Empty; Description = string.Empty; }

        //Constructor
        public MenuItem(int id, string name, decimal price, string category, string description) 
            : base(id, name, price)
        {
            Category = category;
            Description = description;
        }
    }
}
