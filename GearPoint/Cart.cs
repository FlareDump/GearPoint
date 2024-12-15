using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace GearPoint
{
    public partial class Cart : Form
    {

        public string item, gender, size, quantity, price, item_price, category, lastForm;

        MaleShsForm maleShsForm;
        FemaleShsForm femaleShsForm;
        MaleITForm maleITForm;
        FemaleITForm femaleITForm;
        MaleTMForm maleTMForm;
        FemaleTMForm femaleTMForm;
        MaleHMForm maleHMForm;
        FemaleHMForm femaleHMForm;
        ProwareForm prowareForm;
        Main_Menu mainMenu;


        ArrayList dataList = new ArrayList();
        public ArrayList table = new ArrayList();


        public Cart(string item, string gender, string size, string quantity, string price, string itemPrice, string LastForm)
        {
            this.item = item;
            this.gender = gender;
            this.size = size;
            this.quantity = quantity;
            this.price = price;
            this.item_price = itemPrice; // Include item_price
            this.lastForm = LastForm;

            InitializeComponent();
        }

        public Cart()
        {
            InitializeComponent();
        }

        private void CartListGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the Delete button was clicked
            if (e.ColumnIndex == CartListGrid1.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                try
                {
                    // Get the item identifier (assuming 'Item' column contains a unique identifier like an ID)
                    string item = CartListGrid1.Rows[e.RowIndex].Cells["Item"].Value.ToString();
                    string gender = CartListGrid1.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
                    string size = CartListGrid1.Rows[e.RowIndex].Cells["Size"].Value.ToString();

                    // Log for debugging
                    Console.WriteLine($"Attempting to delete Item: {item}, Gender: {gender}, Size: {size}");

                    // Delete the row from the DataGridView
                    CartListGrid1.Rows.RemoveAt(e.RowIndex);

                    // Delete the item from the database
                    DatabaseHandler dbHandler = new DatabaseHandler();
                    dbHandler.DeleteCartItem(item, gender, size); // Assuming you have a method to delete from DB

                    // Log after the delete attempt
                    Console.WriteLine("Item deleted from database");

                    // Recalculate the total price of the cart
                    DataTable cartData = dbHandler.GetCartData();
                    decimal total = cartData.AsEnumerable().Sum(row => row.Field<decimal>("Price"));
                    TotalResultlabel.Text = "₱" + total.ToString("F2");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting item: {ex.Message}", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        public Cart(string lastForm)
        {
            this.lastForm = lastForm;
            InitializeComponent();
        }

        private void ProceedPaymentButton_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment("Cart");
            payment.Show();
            this.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            switch (lastForm)
            {
                case "MaleSHS":
                    maleShsForm = new MaleShsForm(gender, lastForm);
                    maleShsForm.Show();
                    break;
                case "FemaleSHS":
                    femaleShsForm = new FemaleShsForm(gender, lastForm);
                    femaleShsForm.Show();
                    break;
                case "MaleIT":
                    maleITForm = new MaleITForm(gender, lastForm);
                    maleITForm.Show();
                    break;
                case "FemaleIT":
                    femaleITForm = new FemaleITForm(gender, lastForm);
                    femaleITForm.Show();
                    break;
                case "MaleTM":
                    maleTMForm = new MaleTMForm(gender, lastForm);
                    maleTMForm.Show();
                    break;
                case "FemaleTM":
                    femaleTMForm = new FemaleTMForm(gender, lastForm);
                    femaleTMForm.Show();
                    break;
                case "MaleHM":
                    maleHMForm = new MaleHMForm(gender, lastForm);
                    maleHMForm.Show();
                    break;
                case "FemaleHM":
                    femaleHMForm = new FemaleHMForm(gender, lastForm);
                    femaleHMForm.Show();
                    break;
                case "Proware":
                    prowareForm = new ProwareForm(category, lastForm);
                    prowareForm.Show();
                    break;
                case "MainMenu":
                    mainMenu = new Main_Menu(lastForm);
                    mainMenu.Show();
                    break;
            }
            this.Close();
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            DatabaseHandler dbHandler = new DatabaseHandler();

            // Retrieve data and bind to the DataGridView
            DataTable cartData = dbHandler.GetCartData();
            if (cartData.Rows.Count > 0)
            {
                CartListGrid1.DataSource = cartData;

                // Add a Delete button column
                DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn
                {
                    HeaderText = "Delete",
                    Text = "Delete",
                    Name = "Delete",
                    UseColumnTextForButtonValue = true
                };
                CartListGrid1.Columns.Add(deleteColumn);

                // Set column widths
                CartListGrid1.Columns["Item"].Width = 95;
                CartListGrid1.Columns["Gender"].Width = 50;
                CartListGrid1.Columns["Size"].Width = 35;
                CartListGrid1.Columns["Quantity"].Width = 50;
                CartListGrid1.Columns["Price"].Width = 55;
                CartListGrid1.Columns["Delete"].Width = 50;

                // Explicitly set the column order
                CartListGrid1.Columns["Item"].DisplayIndex = 0;       // Item Name
                CartListGrid1.Columns["Gender"].DisplayIndex = 1;     // Gender
                CartListGrid1.Columns["Size"].DisplayIndex = 2;       // Size
                CartListGrid1.Columns["Quantity"].DisplayIndex = 3;   // Quantity
                CartListGrid1.Columns["Price"].DisplayIndex = 4;      // Price
                CartListGrid1.Columns["Delete"].DisplayIndex = 5;     // Delete
                CartListGrid1.Columns["Item Price"].DisplayIndex = 6; // Item Price
            }

            // Allow users to edit rows
            CartListGrid1.ReadOnly = false;
            CartListGrid1.AllowUserToAddRows = false;

            // Optionally calculate the total
            decimal total = cartData.AsEnumerable().Sum(row => row.Field<decimal>("Price"));
            TotalResultlabel.Text = "₱" + total.ToString("F2");
        }





        private void CartListGrid1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the row and column are valid
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                try
                {
                    // Check if the edited cell is in the Quantity column (assuming Quantity column index is 3)
                    if (CartListGrid1.Columns[e.ColumnIndex].Name == "Quantity")
                    {
                        // Get the updated quantity and other required data
                        int quantity = int.Parse(CartListGrid1.Rows[e.RowIndex].Cells["Quantity"].Value.ToString());
                        decimal itemPrice = decimal.Parse(CartListGrid1.Rows[e.RowIndex].Cells["Item Price"].Value.ToString());

                        // Calculate the new price (Total = Quantity * Item Price)
                        decimal newPrice = quantity * itemPrice;

                        // Update the Price cell in the DataGridView
                        CartListGrid1.Rows[e.RowIndex].Cells["Price"].Value = newPrice;

                        // Get identifiers to update the database
                        string item = CartListGrid1.Rows[e.RowIndex].Cells["Item"].Value.ToString();
                        string gender = CartListGrid1.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
                        string size = CartListGrid1.Rows[e.RowIndex].Cells["Size"].Value.ToString();

                        // Update the database with the new values
                        DatabaseHandler dbHandler = new DatabaseHandler();
                        dbHandler.UpdateCartItem(item, gender, size, quantity, newPrice, itemPrice);

                        // Recalculate the total price of the cart
                        DataTable cartData = dbHandler.GetCartData();
                        decimal total = cartData.AsEnumerable().Sum(row => row.Field<decimal>("Price"));
                        TotalResultlabel.Text = "₱" + total.ToString("F2");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating item: {ex.Message}", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        public void AddToCart(string item, string gender, string size, string quantity, string price)
        {
            CartListGrid1.Rows.Add(item, gender, size, quantity, price);
        }

    }
}
