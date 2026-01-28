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
                Console.WriteLine("-- Digitaal bestelsysteem --");
                Console.WriteLine();
                Console.WriteLine("Wat is jouw rol?");
                Console.WriteLine();
                Console.WriteLine("1. Gast (niet geïmplementeerd)");
                Console.WriteLine("2. Ober (niet geïmplementeerd)");
                Console.WriteLine("3. Chef-kok");
                Console.WriteLine("4. Leverancier (niet geïmplementeerd)");
                Console.WriteLine("0. Afsluiten");
                Console.WriteLine();

                Console.Write("Maak een keuze: ");
                string keuze = Console.ReadLine();

                switch (keuze)
                {
                    case "1":
                        ToonNietUitgewerkt(new UserRole("Gast"));
                        break;
                    case "2":
                        ToonNietUitgewerkt(new UserRole("Ober"));
                        break;
                    case "3":
                        ChefKokMenu(dAL);
                        break;
                    case "4":
                        ToonNietUitgewerkt(new UserRole("Leverancier"));
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

            // Helper voor rollen die nog niet zijn uitgewerkt

            static void ToonNietUitgewerkt(UserRole role)
            {
                Console.Clear();
                Console.WriteLine($"Rol: {role.Name}");
                Console.WriteLine();
                Console.WriteLine("Deze functionaliteit is nog niet uitgewerkt.");
                Console.WriteLine();
                Console.WriteLine("Druk op een toets om terug te gaan...");
                Console.ReadKey();
            }

            static void ChefKokMenu(DAL dAL)
            {
                bool running = true;

                while (running)
                {
                    Console.Clear();
                    Console.WriteLine("-- Chef-kok menu --");
                    Console.WriteLine();
                    Console.WriteLine("1. Nieuw gerecht toevoegen");
                    Console.WriteLine("2. Het menu bekijken");
                    Console.WriteLine("0. Afsluiten");
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
        }

        // Implementatie voor het aanmaken van een nieuw gerecht
        static void NieuwGerecht(DAL dAL)
        {
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

        // Implementatie voor het tonen van het menu
        static void ToonMenu(List<MenuItem> menuItems)

        {
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
                item.DisplayInfo();
            }

            Console.WriteLine("Druk op een toets om terug te gaan...");
            Console.ReadKey();

        }
    }
}