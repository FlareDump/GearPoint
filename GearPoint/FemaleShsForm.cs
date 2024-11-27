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
    public partial class FemaleShsForm : Form
    {

        string category;
        char gender;
        double price;
        Cart cart;

        AddOrder addOrder;
        GenderCheckpoint genderCheckpoint;
        public FemaleShsForm(string category, char gender)
        {
            this.gender = gender;
            this.category = category;
            InitializeComponent();
        }

       
        private void ShsWomenTopPoloPicture_Click(object sender, EventArgs e)
        {
            price = 250;
            addOrder = new AddOrder(ShsWomenTopPoloPicture.Text,gender, price);
            addOrder.Show();
            this.Close();
        }

        private void SHSWomenPantsImage_Click(object sender, EventArgs e)
        {
            price = 250;
            addOrder = new AddOrder(SHSWomenPantsImage.Text, gender, price);
            addOrder.Show();
            this.Close();
        }

        private void ShsWomenNeckTiePicture_Click(object sender, EventArgs e)
        {
            price = 250;
            addOrder = new AddOrder(ShsWomenNeckTiePicture.Text,gender, price);
            addOrder.Show();
            this.Close();
        }

        private void ShsWomenUniformSetPicture_Click(object sender, EventArgs e)
        {
            price = 1000;
            addOrder = new AddOrder(ShsWomenUniformSetPicture.Text, gender, price);
            addOrder.Show();
            this.Close();
        }

        private void CartIcon_Click(object sender, EventArgs e)
        {
            cart = new Cart("N/A", "N/A", "N/A", "N/A", "N/A");
            cart.Show();
            this.Close();
        }
    }
}
