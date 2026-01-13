namespace DigitaalBestelsysteem
{
    internal class Program
    {
              
        static void Main(string[] args)
        {   
            // Menu lijst aanmaken
            List<MenuItem> menu = new List<MenuItem>();

            // Een paar gerechten toevoegen aan het menu
            menu.Add(new MenuItem { Id = 1, Name = "Spaghetti Bolognese", Price = 12.50m, Category = "Pasta", Description = "Heerlijke spaghetti met een rijke bolognesesaus.", IsFavoriteDishOfTheDay = true });
            menu.Add(new MenuItem { Id = 2, Name = "Margherita Pizza", Price = 10.00m, Category = "Pizza", Description = "Klassieke pizza met tomaat, mozzarella en verse basilicum." });
            menu.Add(new MenuItem { Id = 3, Name = "Caesar Salad", Price = 8.50m, Category = "Salad", Description = "Frisse salade met romaine sla, croutons en Caesar dressing." });

            // Menu weergeven
            Console.WriteLine("Menu:");

            for (int i = 0; i < menu.Count; i++)
            {
                MenuItem item = menu[i];
                Console.WriteLine($"{item.Id}. {item.Name} - €{item.Price} ({item.Category})");
                Console.WriteLine($"   {item.Description}");
                if (item.IsFavoriteDishOfTheDay)
                {
                    Console.WriteLine("   * Favoriete gerecht van de dag *");
                }

                Console.WriteLine("\nDruk op Enter om af te sluiten...");
                Console.ReadLine();
            }
        }
    }
}
