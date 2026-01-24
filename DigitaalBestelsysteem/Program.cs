using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DigitaalBestelsysteem
{
    public class Program
    {
 
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DAL dAL = new DAL();

            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("-- Chef-kok menu --");
                Console.WriteLine();
                Console.WriteLine("1. Nieuw gerecht toevoegen");
                Console.WriteLine("2. Het menu bekijken");
                Console.WriteLine("0. Programma beëindigen");
                Console.WriteLine();

                Console.Write("Maak een keuze: ");
                string keuze = Console.ReadLine();

                switch (keuze)
                {
                    case "1":
                        NieuwGerecht(dAL);
                        break;
                    case "2":
                        List<MenuItem> menuItems = dAL.ReadMenu();
                        ToonMenu(menuItems);
                        break;
                    case "0":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Ongeldige keuze. Druk op een toets...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void NieuwGerecht(DAL dAL)
        {
            // Implementatie voor het aanmaken van een nieuw gerecht
            MenuItem menuItem = new MenuItem();
            
            Console.Clear();
            Console.WriteLine("-- Nieuw gerecht aanmaken --");
            Console.WriteLine();

            Console.Write("Naam: ");
            menuItem.Name = Console.ReadLine();

            Console.Write("Prijs: ");
            menuItem.Price = decimal.Parse(Console.ReadLine());

            Console.Write("Categorie: ");
            menuItem.Category = Console.ReadLine();

            Console.Write("Beschrijving: ");
            menuItem.Description = Console.ReadLine();

            dAL.CreateMenu(menuItem);

            Console.WriteLine();
            Console.WriteLine("Gerecht toegevoegd! Druk op een toets om terug te gaan...");
            Console.ReadKey();

        }

        static void ToonMenu(List<MenuItem> menuItems)

        {
            // Implementatie voor het tonen van het menu
            Console.Clear();
            Console.WriteLine("-- Menu --");
            Console.WriteLine();

            if (menuItems.Count == 0)
            {
                Console.WriteLine("Het menu is leeg.");
                Console.WriteLine("Druk op een toets om terug te gaan...");
                Console.ReadKey();
                return;
            }

            foreach (var item in menuItems)
            {
                Console.WriteLine($"{item.Id}. {item.Name} - €{item.Price} ({item.Category})");
                Console.WriteLine($"{item.Description}");
                Console.WriteLine();
            }

            Console.WriteLine("Druk op een toets om terug te gaan...");
            Console.ReadKey();

        }
    }
}