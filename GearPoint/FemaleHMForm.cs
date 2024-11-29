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
    public partial class FemaleHMForm : Form
    {
        string category;
        char gender;
        double price;

        Cart cart;
        AddOrder addOrder;
        public FemaleHMForm(string category, char gender)
        {
            this.category = category;
            this.gender = gender;
            InitializeComponent();
        }

        private void HMlongsleevePoloImage_Click(object sender, EventArgs e)
        {
            price = 250;
            addOrder = new AddOrder(HMlongsleevePoloImage.Text, gender, price);
            addOrder.Show();
            this.Close();
        }

        private void HMBlazerImage_Click(object sender, EventArgs e)
        {
            price = 250;
            addOrder = new AddOrder(HMBlazerImage.Text, gender, price);
            addOrder.Show();
            this.Close();
        }

        private void HMPantsImage_Click(object sender, EventArgs e)
        {
            price = 250;
            addOrder = new AddOrder(HMPantsImage.Text, gender, price);
            addOrder.Show();
            this.Close();
        }

        private void HMSkirtImage_Click(object sender, EventArgs e)
        {
            price = 250;
            addOrder = new AddOrder(HMSkirtImage.Text, gender, price);
            addOrder.Show();
            this.Close();
        }

        private void HMFemaleUniformSetImage_Click(object sender, EventArgs e)
        {
            price = 250;
            addOrder = new AddOrder(HMFemaleUniformSetImage.Text, gender, price);
            addOrder.Show();
            this.Close();
        }

        private void HMGraySkullCapImage_Click(object sender, EventArgs e)
        {
            price = 250;
            addOrder = new AddOrder(HMGraySkullCapImage.Text, gender, price);
            addOrder.Show();
            this.Close();
        }

        private void HMGrayChefsPoloImage_Click(object sender, EventArgs e)
        {
            price = 250;
            addOrder = new AddOrder(HMGrayChefsPoloImage.Text, gender, price);
            addOrder.Show();
            this.Close();
        }

        private void HMChefsPantsImage_Click(object sender, EventArgs e)
        {
            price = 250;
            addOrder = new AddOrder(HMChefsPantsImage.Text, gender, price);
            addOrder.Show();
            this.Close();
        }

        private void HMKitchenUniformSetImage_Click(object sender, EventArgs e)
        {
            price = 250;
            addOrder = new AddOrder(HMKitchenUniformSetImage.Text, gender, price);
            addOrder.Show();
            this.Close();
        }

        private void PaymentButton_Click(object sender, EventArgs e)
        {

        }

        private void CartIcon_Click(object sender, EventArgs e)
        {
            cart = new Cart("N/A", "N/A", "N/A", "N/A", "N/A");
            cart.Show();
            this.Close();
        }
    }
}
