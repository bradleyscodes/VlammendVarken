using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitaalBestelsysteem
{
    public class OrderLine
    {
        public MenuItem Item { get; set; }
        public int Quantity { get; set; }
        public string Customization { get; set; }

        // Bereken de totale prijs voor deze orderregel
        public decimal LineTotal => Item.Price * Quantity;

        // Constructor
        public OrderLine(MenuItem item, int quantity, string customization = "")
        {
            Item = item;
            Quantity = quantity;
            Customization = customization;
        }
    }
}
