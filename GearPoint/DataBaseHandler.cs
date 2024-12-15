using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GearPoint
{
    class DatabaseHandler
    {
        private string connString = "server=localhost;uid=root;pwd=sti-gearpoint;database=Gearpoint";

        // New public variable to store the total price
        public decimal TotalPrice { get; private set; } = 0;

        public bool DeleteAllHistory()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string query = "DELETE FROM history"; // Deletes all rows in the 'history' table

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery(); // Executes the delete command
                    }
                }
                return true; // Indicate successful deletion
            }
            catch (Exception ex)
            {
                // Log the error for debugging purposes
                MessageBox.Show($"Error deleting all history entries: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public DataTable GetHistory()
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT item_name, gender, size, quantity, price, Reference FROM history";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving history: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }

        // Method to delete history entry by item_name (you could modify this to use another identifier)
        public bool DeleteHistory(string reference)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string query = "DELETE FROM history WHERE Reference = @Reference";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Reference", reference);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting history: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool AddUser(string username, string password)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string query = "INSERT INTO accounts (username, password) VALUES (@username, @password)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password); // You can hash the password before storing
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding user: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool ValidateUser(string username, string password)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM accounts WHERE username = @username AND password = @password";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password); // You can hash the password before comparing

                        int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                        return userCount > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error validating user: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        } 

        public void AddOrder(string itemName, string gender, string size, int quantity, decimal itemPrice, decimal totalPrice)
        {
            string query = "INSERT INTO orders (item_name, gender, size, quantity, item_price, price) " +
                           "VALUES (@itemName, @gender, @size, @quantity, @itemPrice, @price)";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@itemName", itemName);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@size", size);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@itemPrice", itemPrice); // Save item_price
                    cmd.Parameters.AddWithValue("@price", totalPrice);    // Save total price

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteCartItem(string item, string gender, string size)
        {
            try
            {
                // Use MySqlConnection instead of SqlConnection
                using (var connection = new MySqlConnection(connString))
                {
                    connection.Open();
                    string query = "DELETE FROM orders WHERE item_name = @Item AND gender = @Gender AND size = @Size";

                    // Log the query and parameters for debugging
                    Console.WriteLine($"Executing query: {query}");
                    Console.WriteLine($"Parameters: Item = {item}, Gender = {gender}, Size = {size}");

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Item", item);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@Size", size);

                        int rowsAffected = command.ExecuteNonQuery();

                        // Log the number of rows affected
                        Console.WriteLine($"Rows affected: {rowsAffected}");

                        if (rowsAffected == 0)
                        {
                            Console.WriteLine("No matching records found for deletion.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting item from database: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Method to retrieve data for the cart
        public DataTable GetCartData()
        {
            DataTable cartData = new DataTable();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();

                    // SQL query to fetch data for the cart
                    string sql = "SELECT item_name AS 'Item', gender AS 'Gender', size AS 'Size', quantity AS 'Quantity', price AS 'Price', item_price AS 'Item Price' FROM orders";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(cartData); // Fill the DataTable with results
                    }
                }

                // Update TotalPrice after fetching the data
                UpdateTotalPrice(cartData);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Database error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return cartData;
        }

        // New method to calculate and update the total price
        private void UpdateTotalPrice(DataTable cartData)
        {
            try
            {
                if (cartData.Columns.Contains("Price"))
                {
                    TotalPrice = cartData.AsEnumerable()
                                         .Where(row => row["Price"] != DBNull.Value)
                                         .Sum(row => row.Field<decimal>("Price"));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while calculating total price: " + ex.Message);
            }
        }

        public void UpdateCartItem(string item, string gender, string size, int quantity, decimal price, decimal item_price)
        {
            if (string.IsNullOrEmpty(item))
                throw new ArgumentException("Item name cannot be null or empty.", nameof(item));

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string query = @"UPDATE orders 
                         SET gender = @Gender, size = @Size, quantity = @Quantity, price = @Price, item_price = @Item_Price
                         WHERE item_name = @Item";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Item", item);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Size", size);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@Price", quantity * item_price); // Calculate total price here
                    cmd.Parameters.AddWithValue("@Item_price", item_price);

                    cmd.ExecuteNonQuery();
                }
            }
        }

    }

}
