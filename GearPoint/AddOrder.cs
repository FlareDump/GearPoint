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
        string category;
        char gender;
        double quantity;
        string size;
        double price;
        double total;
        Cart cart;
        Main_Menu menu = new Main_Menu();
        MaleShsForm maleShsForm;
        MaleHMForm maleHMForm;
        ITuniformFORM ituniform;
        FemaleTMForm femaleTMForm;
        FemaleShsForm femaleShsForm;

        public AddOrder(string item_name, char gender, double price)
        {
            this.item_name = item_name;
            this.gender = gender;
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

        

        private void OrderImageBox_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            quantity = (double)QuantityBox.Value;
            total = quantity * price;

            PriceOutputLbl.Text = total.ToString("F2");

        }

        private void AddToCartBtn_Click(object sender, EventArgs e)
        {
            string Item = item_name;
            string Gender = gender.ToString();
            string Size = size;
            string Quantity = quantity.ToString();
            string Total = total.ToString();

            cart = new Cart(Item, Gender, Size, Quantity, Total);
            MessageBox.Show("Item Added to cart");
            cart.Show();
            this.Close();
   
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            maleShsForm = new MaleShsForm(category, gender);
            maleShsForm.Show();
            this.Close();

        }
    }
}
