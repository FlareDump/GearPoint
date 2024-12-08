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
    public partial class AddOrder : Form
    {
        string item_name;
        char gender;
        double quantity;
        string size;
        double price;
        double total;
        string lastForm;
        string category;

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
            string Size = size;
            string Quantity = quantity.ToString();
            string Total = total.ToString("F2");

            cart = new Cart(Item, Gender, Size, Quantity, Total);
            MessageBox.Show("Item Added to cart");
            cart.Show();
            this.Close();
            menu = new Main_Menu(lastForm, "₱" + Total);
            menu.Show();
   
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
                    maleHMForm= new MaleHMForm(gender, lastForm);
                    femaleHMForm.Show();
                    break;
                case "Proware":
                    prowareForm = new ProwareForm(category, lastForm);
                    prowareForm.Show();
                    break;
            }
            this.Close();

        }

        private void QuantityBox_ValueChanged(object sender, EventArgs e)
        {
            quantity = (double)QuantityBox.Value;
            total = quantity * price;

            PriceOutputLbl.Text = total.ToString("F2");
        }
    }
}
