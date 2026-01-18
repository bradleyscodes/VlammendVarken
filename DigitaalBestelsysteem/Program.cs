using System.Text;

namespace DigitaalBestelsysteem
{
    public class Program
    {
        static List<MenuItem> menu = new List<MenuItem>();
        static List<Order> orders = new List<Order>();

        static int nextMenuId = 1;
        static int nextOrderId = 1;

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            menu.Add(new MenuItem(nextMenuId++, "Pulled Pork Burger", 14.50m, "Hoofdgerecht", "Sappige pulled pork van de grill op een brioche bun, met BBQ-saus en coleslaw.", true));
            menu.Add(new MenuItem(nextMenuId++, "Varkensribben van de Grill", 18.00m, "Hoofdgerecht", "Langzaam gegaarde spareribs, gelakt met onze huisgemaakte Vlammend Varken BBQ-saus."));
            menu.Add(new MenuItem(nextMenuId++, "BBQ Nacho’s", 8.00m, "Voorgerecht", "Nacho’s met pulled pork, gesmolten kaas, jalapeños en BBQ-saus."));
            menu.Add(new MenuItem(nextMenuId++, "Loaded Fries Pulled Pork", 7.50m, "Voorgerecht", "Friet met pulled pork, cheddarkaas, bosui en BBQ-saus."));
            menu.Add(new MenuItem(nextMenuId++, "Chocolade Lava Cake", 6.50m, "Nagerecht", "Warm chocoladetaartje met een zachte, vloeibare kern, geserveerd met vanille-ijs."));
            menu.Add(new MenuItem(nextMenuId++, "Gegrilde Ananas met Kaneelsuiker", 5.50m, "Nagerecht", "Zoete ananas van de grill met kaneelsuiker en een bolletje romig vanille-ijs."));

            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("\"Welkom bij Vlammend Varken. Genieten staat bij ons centraal. Eet smakelijk!\"");
                Console.WriteLine();
                Console.WriteLine("1. Nieuw gerecht aanmaken");
                Console.WriteLine("2. Het menu bekijken");
                Console.WriteLine("3. Een bestelling plaatsen");
                Console.WriteLine("4. Een gerecht aanpassen");
                Console.WriteLine("5. Status van een bestelling bekijken");
                Console.WriteLine("6. Alle geplaatste bestellingen tonen");
                Console.WriteLine("7. Inzicht in bezette en vrije tafels");
                Console.WriteLine("0. Programma beëindigen");
                Console.WriteLine();

                Console.Write("Maak een keuze: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        NieuwGerecht();
                        break;
                    case "2":
                        ToonMenu();
                        break;
                    case "3":
                        BestellingPlaatsen();
                        break;
                    case "4":
                        GerechtAanpassen();
                        break;
                    case "5":
                        BestellingStatusBekijken();
                        break;
                    case "6":
                        ToonAlleBestellingen();
                        break;
                    case "7":
                        ToonTafels();
                        break;
                    case "0":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Ongeldige keuze.");
                        break;
                }
            }
        }

        static void NieuwGerecht()
        {
            // Implementatie voor het aanmaken van een nieuw gerecht
            Console.Clear();
            Console.WriteLine("Nieuw gerecht aanmaken");
            Console.WriteLine();

            Console.Write("Naam: ");
            string name = Console.ReadLine();

            Console.Write("Prijs: ");
            decimal price = decimal.Parse(Console.ReadLine());

            Console.Write("Categorie: ");
            string category = Console.ReadLine();

            Console.Write("Beschrijving: ");
            string description = Console.ReadLine();

            MenuItem item = new MenuItem(nextMenuId++, name, price, category, description);
            menu.Add(item);

            Pauze("Gerecht toegevoegd aan het menu.");
        }

        static void ToonMenu()
        {
            // Implementatie voor het tonen van het menu
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine();

            if (menu.Count == 0)
            {
                Console.WriteLine("Het menu is leeg.");
                Pauze();
                return;
            }

            foreach (var item in menu)
            {
                Console.WriteLine($"{item.Id}. {item.Name} - €{item.Price} ({item.Category})");
                Console.WriteLine($"   {item.Description}");
                Console.WriteLine();
            }
            Pauze();
        }

        static void BestellingPlaatsen()
        {
            // Implementatie voor het plaatsen van een bestelling
            Console.WriteLine("Bestelling plaatsen");
        }

        static void GerechtAanpassen()
        {
            // Implementatie voor het aanpassen van een gerecht
            Console.WriteLine("Gerecht aanpassen");
        }
        static void BestellingStatusBekijken()
        {
            // Implementatie voor het bekijken van de status van een bestelling
            Console.WriteLine("Status van een bestelling bekijken");
        }
        static void ToonAlleBestellingen()
        {
            // Implementatie voor het tonen van alle bestellingen
            Console.WriteLine("Alle geplaatste bestellingen:");
        }

        static void ToonTafels()
        {             // Implementatie voor het tonen van bezette en vrije tafels
            Console.WriteLine("Inzicht in bezette en vrije tafels");
        }

        static void Pauze(string tekst = "")
        {
            if (tekst != "")
                Console.WriteLine(tekst);

            Console.WriteLine();
            Console.Write("Druk op ENTER om verder te gaan...");
            Console.ReadLine();
        }

    }
}   
