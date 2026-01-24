using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitaalBestelsysteem
{
    public class DAL
    {
        public List<MenuItem> MenuItems = new List<MenuItem>();
        string ConnectionString = "Data Source=.;Initial Catalog=sqldatabase-vvarken-01;Integrated Security=True;TrustServerCertificate=True";
        public DAL()
        {

        }

        // Create, Read, Update, Delete (CRUD) methods can be added here

        public void CreateMenu(MenuItem menuItem)
        {
            MenuItems.Clear();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "INSERT INTO MenuItems (Name, Price, Category, Description) " +
                        "VALUES (@name, @price, @category, @description)";
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@name", menuItem.Name);
                        command.Parameters.AddWithValue("@price", menuItem.Price);
                        command.Parameters.AddWithValue("@category", menuItem.Category);
                        command.Parameters.AddWithValue("@description", menuItem.Description);
                        command.ExecuteNonQuery();
                    }

                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
        }

        public List<MenuItem> ReadMenu()
        {
            MenuItems.Clear();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sql = "SELECT Id, Name, Price, Category, Description FROM MenuItems";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                MenuItem menuItem = new MenuItem
                                {
                                    Id = reader.GetInt32(0),
                                    Name = reader.GetString(1),
                                    Price = reader.GetDecimal(2),
                                    Category = reader.GetString(3),
                                    Description = reader.GetString(4)
                                };

                                MenuItems.Add(menuItem);
                            }

                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }

            return MenuItems;
        }

        public void UpdateOrder()
        {

        }
        public void DeleteOrder()
        {

        }


    }
}
