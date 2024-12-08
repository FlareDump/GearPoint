using System.Windows.Forms;
using System;

namespace GearPoint
{
    public partial class AddOrder : Form
    {
        // Private fields
        private string item_name;
        private char gender;
        private double quantity;
        private string size;
        private double price;
        private string lastForm;
        private string category;
        public double Total;
        public string TotalPrice;

        MaleShsForm maleShsForm;
        FemaleShsForm femaleShsForm;
        MaleITForm maleITForm;
        FemaleITForm femaleITForm;
        MaleTMForm maleTMForm;
        FemaleTMForm femaleTMForm;
        MaleHMForm maleHMForm;
        FemaleHMForm femaleHMForm;
        ProwareForm prowareForm;

        Cart cart;
        Main_Menu menu = new Main_Menu();

        public string getTotalPrice()
        {
            return TotalPrice;
        }

        // Constructors
        public AddOrder(string item_name, char gender, double price, string lastForm)
        {
            this.item_name = item_name;
            this.gender = gender;
            this.price = price;
            this.lastForm = lastForm;
            InitializeComponent();
        }

        public AddOrder(string item_name, double price)
        {
            this.item_name = item_name;
            this.price = price;
            InitializeComponent();
        }

        public AddOrder(string item_name, double price, string lastForm)
        {
            this.lastForm = lastForm;
            this.item_name = item_name;
            this.price = price;
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
            GenderLbl.Text = gender.ToString();
        }

        private void AddToCartBtn_Click(object sender, EventArgs e)
        {
            string Item = item_name;
            string Gender = gender.ToString();
            size = SizesComboBox.Text;
            string Quantity = quantity.ToString();
            TotalPrice = "₱" + Total.ToString("F2");

            cart = new Cart(Item, Gender, size, Quantity, TotalPrice, TotalPrice);
            MessageBox.Show("Item Added to cart");
            cart.Show();
            this.Close();
            menu = new Main_Menu(lastForm, TotalPrice, TotalPrice);
            menu.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            switch (lastForm)
            {
                case "MaleSHS":
                    maleShsForm = new MaleShsForm(gender, lastForm, TotalPrice);
                    maleShsForm.Show();
                    break;
                case "FemaleSHS":
                    femaleShsForm = new FemaleShsForm(gender, lastForm, TotalPrice);
                    femaleShsForm.Show();
                    break;
                case "MaleIT":
                    maleITForm = new MaleITForm(gender, lastForm, TotalPrice);
                    maleITForm.Show();
                    break;
                case "FemaleIT":
                    femaleITForm = new FemaleITForm(gender, lastForm, TotalPrice);
                    femaleITForm.Show();
                    break;
                case "MaleTM":
                    maleTMForm = new MaleTMForm(gender, lastForm, TotalPrice);
                    maleTMForm.Show();
                    break;
                case "FemaleTM":
                    femaleTMForm = new FemaleTMForm(gender, lastForm, TotalPrice);
                    femaleTMForm.Show();
                    break;
                case "MaleHM":
                    maleHMForm = new MaleHMForm(gender, lastForm, TotalPrice);
                    maleHMForm.Show();
                    break;
                case "FemaleHM":
                    maleHMForm = new MaleHMForm(gender, lastForm, TotalPrice);
                    femaleHMForm.Show();
                    break;
                case "Proware":
                    prowareForm = new ProwareForm(category, lastForm, TotalPrice);
                    prowareForm.Show();
                    break;
            }
            this.Close();
        }

        private void QuantityBox_ValueChanged(object sender, EventArgs e)
        {
            quantity = (double)QuantityBox.Value;
            Total = quantity * price; // Update the public property

            PriceOutputLbl.Text = Total.ToString("F2");
        }
    }
}
