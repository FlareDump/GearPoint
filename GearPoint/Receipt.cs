using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GearPoint
{
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(100000, 1000000);
            string formattedNumber = randomNumber.ToString().Insert(3, " ");

            RefNumber.Text = formattedNumber;

            TransferOrdersToHistory(formattedNumber);
            Console.WriteLine("Successdlly generated reference number...");
        }

        private void TransferOrdersToHistory(string formattedNumber)
        {
           string connString = "server=localhost;uid=root;pwd=sti-gearpoint;database=Gearpoint";

        // SQL command to add the Reference column to the history table if it doesn't exist
        string addColumnCommand = @"
            ALTER TABLE history ;";

            // SQL command to insert data from orders into history and include the Reference
            string insertCommand = @"
                INSERT INTO history (item_name, gender, size, quantity, price, reference)
                SELECT item_name, gender, size, quantity, price, @reference FROM orders;";

            // SQL command to delete all rows from orders
            string deleteCommand = "DELETE FROM orders;";

            // Create a new MySQL connection
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    // Start a transaction to ensure both operations are done atomically
                    using (MySqlTransaction transaction = conn.BeginTransaction())
                    {
                        // Add the Reference column to the history table if it doesn't exist
                        using (MySqlCommand addColumnCmd = new MySqlCommand(addColumnCommand, conn, transaction))
                        {
                            addColumnCmd.ExecuteNonQuery();
                        }

                        // Insert data from orders to history, including the reference number
                        using (MySqlCommand insertCmd = new MySqlCommand(insertCommand, conn, transaction))
                        {
                            // Pass the formatted reference number to the SQL command
                            insertCmd.Parameters.AddWithValue("@reference", formattedNumber);
                            insertCmd.ExecuteNonQuery();
                        }

                        // Delete all rows from the orders table
                        using (MySqlCommand deleteCmd = new MySqlCommand(deleteCommand, conn, transaction))
                        {
                            deleteCmd.ExecuteNonQuery();
                        }

                        // Commit the transaction to apply the changes
                        transaction.Commit();

                        Console.WriteLine("Orders successfully transferred to history with reference and deleted from orders.");
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Database error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            StartingPoint start = new StartingPoint();
            start.Show();
            this.Close();
        }
    }
}
