using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitaalBestelsysteem
{
    internal class MenuItem
    {
        public int Id { get; set; }
        public string Naam { get; set; } = "";
        public decimal Prijs { get; set; }
        public string Categorie { get; set; } = "Overig";
        public string Omschrijving { get; set; } = "Geen omschrijving";
        public bool IsDagfavoriet { get; set; } 

    }
}
