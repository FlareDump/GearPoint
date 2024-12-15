using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace GearPoint
{
    public partial class Main_Menu : Form
    {
        private System.Windows.Forms.Label totalOutputLbl;

        public Label TotalOutputLabel => totalOutputLbl;

        private string lastForm;
        public string totalPrice;
        public string updatePrice;
        public string category = "Proware";

        public Main_Menu()
        {
            totalPrice = "₱0.00";
            InitializeComponent();
        }

        public Main_Menu(string lastForm, string updatePrice)
        {
            this.lastForm = lastForm;
            this.updatePrice = updatePrice;
            InitializeComponent();
        }

        public Main_Menu(string lastForm)
        {
            this.lastForm = lastForm;
            InitializeComponent();
        }

        public void UpdateTotalOutputLabel(string text)
        {
            TotalOutputLabel.Text = text; // Helper method to update the label
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Main_Menu_Load triggered");

            if (!string.IsNullOrEmpty(updatePrice))
            {
                Console.WriteLine("Using passed updatePrice: " + updatePrice);
                TotalOutputLbl.Text = updatePrice;
            }
            else
            {
                try
                {
                    string connstring = "server=localhost;uid=root;pwd=sti-gearpoint;database=Gearpoint";
                    using (MySqlConnection connection = new MySqlConnection(connstring))
                    {
                        connection.Open();
                        string query = "SELECT SUM(price) AS total_sum FROM orders";
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        object result = cmd.ExecuteScalar();

                        decimal totalSum = result != DBNull.Value && result != null ? Convert.ToDecimal(result) : 0.00m;
                        TotalOutputLbl.Text = "₱" + totalSum.ToString("F2");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    MessageBox.Show("An error occurred while updating the total.");
                    TotalOutputLbl.Text = "₱0.00";
                }
            }
        }


        // Reusable method for category navigation
        private void NavigateToCategory(string selectedCategory, bool isProware = false)
        {
            if (isProware)
            {
                Console.WriteLine("User choosen Proware...");
                var prowareForm = new ProwareForm(category, lastForm);
                prowareForm.Show();
            }
            else
            {
                Console.WriteLine("User choosen a Category and will proceed to Gender Checkpoint...");
                var genderCheckpoint = new GenderCheckpoint(selectedCategory, "MainMenu");
                genderCheckpoint.Show();
            }
            this.Close();
        }

        // SHS Card Handlers
        private void ShsImageCard_Click(object sender, EventArgs e) => NavigateToCategory("SHS");
        private void ShsLabelCard_Click(object sender, EventArgs e) => NavigateToCategory("SHS");
        private void ShsBackCard_Click(object sender, EventArgs e) => NavigateToCategory("SHS");

        // ICT Card Handlers
        private void ICTImageCard_Click(object sender, EventArgs e) => NavigateToCategory("IT");
        private void ICTLabelCard_Click(object sender, EventArgs e) => NavigateToCategory("IT");
        private void ICTBackCard_Click(object sender, EventArgs e) => NavigateToCategory("IT");

        // TM Card Handlers
        private void TMImageCard_Click(object sender, EventArgs e) => NavigateToCategory("TM");
        private void TMLabelCard_Click(object sender, EventArgs e) => NavigateToCategory("TM");
        private void TMBackCard_Click(object sender, EventArgs e) => NavigateToCategory("TM");

        // HM Card Handlers
        private void HMImageCard_Click(object sender, EventArgs e) => NavigateToCategory("HM");
        private void HMLabelCard_Click(object sender, EventArgs e) => NavigateToCategory("HM");
        private void HMBackCard_Click(object sender, EventArgs e) => NavigateToCategory("HM");

        // Proware Card Handlers
        private void ProwareImageCard_Click(object sender, EventArgs e) => NavigateToCategory("Proware", true);
        private void ProwareLabelCard_Click(object sender, EventArgs e) => NavigateToCategory("Proware", true);
        private void ProwareBackCard_Click(object sender, EventArgs e) => NavigateToCategory("Proware", true);

        private void CartIcon_Click(object sender, EventArgs e)
        {
            var cart = new Cart("MainMenu");
            cart.Show();
            this.Close();
        }

        private void PaymentButton_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment("MainMenu");
            payment.Show();
            this.Close();
        }
    }
}
