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
    public partial class MaleShsForm : Form
    {
        char gender;
        string category;
        double price;
        Cart cart;

        GenderCheckpoint genderCheckpoint;

        public MaleShsForm(string category, char gender)
        {
            this.gender = gender;
            this.category = category;
            InitializeComponent();
        }

        AddOrder addOrder;

        private void MaleShsForm_Load(object sender, EventArgs e)
        { 

        }

        private void SHSMenTopImage_Click(object sender, EventArgs e)
        {
            price = 250;
            addOrder = new AddOrder(SHSMenTopLbl.Text, gender, price);
            addOrder.Show();
            this.Close();
        }

        private void SHSMenTopLbl_Click(object sender, EventArgs e)
        {
            price = 250;
            addOrder = new AddOrder(SHSMenTopLbl.Text, gender, price);
            addOrder.Show();
            this.Close();
        }

        private void SHSMentopCard_Click(object sender, EventArgs e)
        {
            price = 250;
            addOrder = new AddOrder(SHSMenTopLbl.Text, gender, price);
            addOrder.Show();
            this.Close();
        }

        private void HMLabelCard_Click(object sender, EventArgs e)
        {
            category = "HM";
            genderCheckpoint = new GenderCheckpoint(category);
            genderCheckpoint.Show();
            this.Close();
        }

        private void CartIcon_Click(object sender, EventArgs e)
        {
            cart = new Cart("N/A", "N/A", "N/A", "N/A", "N/A");
            cart.Show();
            this.Close();
        }

        private void SHSMenPantsImage_Click(object sender, EventArgs e)
        { 
            price = 250;
            addOrder = new AddOrder(SHSMenPantsImage.Text, gender, price);
            addOrder.Show();
            this.Close();
        }

        private void SHSMenNeckTieImage_Click(object sender, EventArgs e)
        {
            price = 250;
            addOrder = new AddOrder(SHSMenNeckTieImage.Text, gender, price);
            addOrder.Show();
            this.Close();
        }

        private void SHSMenUniformSetImage_Click(object sender, EventArgs e)
        {
            price = 1000;
            addOrder = new AddOrder(SHSMenUniformSetImage.Text, gender, price);
            addOrder.Show();
            this.Close();
        }
    }
}
