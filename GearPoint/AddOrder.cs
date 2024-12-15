using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Data;
using System.Drawing; // Required for Image
using System.Windows.Forms;

namespace GearPoint
{
    public partial class AddOrder : Form
    {
        // Private fields
        private string item_name;
        private string gender;
        private double quantity;
        private string size;
        private double price;
        private string lastForm;
        private string category;
        public double Total;
        private double item_price;
        public string TotalPrice;
        private Boolean isOrdered = false;
        private Image itemImage; // Field to hold the image

        ArrayList dataTable = new ArrayList();

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
        Cart cart;

        string connstring = "server=localhost;uid=root;pwd=sti-gearpoint;database=Gearpoint";

        // Constructors
        public AddOrder(string item_name, string gender, double price, string lastForm, Image itemImage)
        {
            this.item_name = item_name;
            this.gender = gender;
            this.price = price;
            this.lastForm = lastForm;
            this.itemImage = itemImage; // Assign the image
            InitializeComponent();
        }

        public AddOrder(string item_name, string category, string lastForm, double price, Image itemImage)
        {
            this.lastForm = lastForm;
            this.category = category;
            this.gender = category;
            this.item_name = item_name;
            this.price = price;
            this.itemImage = itemImage; // Assign the image
            InitializeComponent();
        }

        // Events and Methods
        private void AddOrder_Load(object sender, EventArgs e)
        {
            string[] shirtSizes = { "XS", "S", "M", "L", "XL", "XXL", "XXXL" };


            for (int i = 0; i < shirtSizes.Length; i++)
            {
                SizesComboBox.Items.Add(shirtSizes[i]);
            }

            ItemNameLbl.Text = item_name.ToString();

            if (category == "Proware")
            {
                GenCatLbl.Text = "Category: ";
                GenderLbl.Text = "Proware";
            }
            else
            {
                GenderLbl.Text = gender.ToString();
            }

            // Display the image in the PictureBox if provided
            if (itemImage != null)
            {
                OrderImageBox.Image = itemImage;
                OrderImageBox.SizeMode = PictureBoxSizeMode.StretchImage; // Adjust image display
            }

        }

        private void addToDataTable(ArrayList inputs)
        {
            string itemName;
            string gender;
            string size;
            string quantity;
            string price;
            string totalPrice;
            dataTable.Add(inputs);

            for (int i = 0; i < dataTable.Count; i++)
            {
                ArrayList row = (ArrayList)dataTable[i];
                if (row.Count >= 5)  // Ensure the row has enough columns
                {
                    itemName = (string)row[0];  // Get itemName from the first column
                    gender = (string)row[1];    // Get gender from the second column
                    size = (string)row[2];      // Get size from the third column
                    quantity = (string)row[3];  // Get quantity from the fourth column
                    totalPrice = (string)row[4]; // Get totalPrice from the fifth column
                    price = (string)row[5];

                    cart = new Cart(itemName, gender, size, quantity, price, totalPrice, lastForm);
                }
            }
        }

        private void AddToCartBtn_Click(object sender, EventArgs e)
        {
            string Item = item_name;
            string Gender = gender.ToString();
            size = SizesComboBox.Text;

            // Ensure size is selected and quantity is entered
            if (string.IsNullOrEmpty(size) || QuantityBox.Value == 0)
            {
                Console.WriteLine("The User did not enter complete values");
                MessageBox.Show("Please fill the information needed: Select size and enter quantity.");
                return; // Stop execution if the conditions aren't met
            }

            // Assign the item price
            item_price = price;

            // Calculate the total price
            double Quantity = (double)QuantityBox.Value;
            Total = Quantity * item_price;
            TotalPrice = "₱" + Total.ToString("F2");

            // Add inputs to the data table
            ArrayList inputs = new ArrayList { Item, Gender, size, Quantity.ToString(), item_price.ToString(), TotalPrice };
            addToDataTable(inputs);

            Console.WriteLine("Item Added to cart");

            try
            {
                // Pass item_price and Total to the database handler
                DatabaseHandler dbHandler = new DatabaseHandler();
                dbHandler.AddOrder(Item, Gender, size, (int)Quantity, (decimal)item_price, (decimal)Total);

                isOrdered = true;
                AddToCartBtn.Enabled = false;
                AddToCartBtn.Text = "Added To Cart";
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

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (isOrdered)
            {
                // Pass updated total to Main_Menu form
                mainMenu = new Main_Menu(lastForm);
                mainMenu.Show();
                this.Close();
            }
            else
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
            }
            this.Close();
        }

        private void QuantityBox_ValueChanged(object sender, EventArgs e)
        {
            quantity = (double)QuantityBox.Value;
            Total = quantity * price; // Dynamically update Total based on quantity and item price

            PriceOutputLbl.Text = Total.ToString("F2");
        }

        private void OrderImageBox_Click(object sender, EventArgs e)
        {
            // Click event for the PictureBox
        }
    }
}
