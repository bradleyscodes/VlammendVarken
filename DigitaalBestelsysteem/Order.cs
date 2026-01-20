using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitaalBestelsysteem
{
    public class Order
    {
        public int Id { get; set; }
        public int TableNumber { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<OrderLine> Lines { get; set; }

        // Constructor

        public Order(int id, int tableNumber)
        {
            Id = id;
            TableNumber = tableNumber;
            CreatedAt = DateTime.Now;
            Lines = new List<OrderLine>();
        }
              
    }
}
