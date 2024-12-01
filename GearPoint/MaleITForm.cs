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
    public partial class MaleITForm : Form
    {
        char gender;
        string category;
        double price;

        Cart cart;
        AddOrder addOrder;
        GenderCheckpoint genderCheckpoint;
        ProwareForm prowareForm;

        public MaleITForm(char gender)
        {
            this.gender = gender;
            InitializeComponent();
        }

        //IT Top
        private void ITMenTopImage_Click(object sender, EventArgs e)
        {
            price = 350;
            addOrder = new AddOrder(ITMenTopLbl.Text, price);
            addOrder.Show();

        } 
        private void ITMenTopLbl_Click(object sender, EventArgs e)
        {
            price = 350;
            addOrder = new AddOrder(ITMenTopLbl.Text, price);
            addOrder.Show();
        }
        private void ICTMentopCard_Click(object sender, EventArgs e)
        {
            price = 350;
            addOrder = new AddOrder(ITMenTopLbl.Text, price);
            addOrder.Show();
        }
        //End IT Top

        //IT Pants
        private void ITMenPantsLabel_Click(object sender, EventArgs e)
        {
            price = 400;
            addOrder = new AddOrder(ITMenPantsLabel.Text, price);
            addOrder.Show();
            this.Close();
        }

        private void ITMenPantsImage_Click(object sender, EventArgs e)
        {
            price = 400;
            addOrder = new AddOrder(ITMenPantsLabel.Text, price);
            addOrder.Show();
            this.Close();
        }

        private void ITMenPantsBackCard_Click(object sender, EventArgs e)
        {
            price = 400;
            addOrder = new AddOrder(ITMenPantsLabel.Text, price);
            addOrder.Show();
            this.Close();
        }
        //END IT Pants
        //IT Uniform Set
        private void ITMenUniformSetLabel_Click(object sender, EventArgs e)
        {
            price = 750;
            addOrder = new AddOrder(ITMenUniformSetLabel.Text, price);
            addOrder.Show();
            this.Close();
        }

        private void ITmenUniformSetImage_Click(object sender, EventArgs e)
        {
            price = 750;
            addOrder = new AddOrder(ITMenUniformSetLabel.Text, price);
            addOrder.Show();
            this.Close();
        }

        private void ITmenUniformSetBackCard_Click(object sender, EventArgs e)
        {
            price = 750;
            addOrder = new AddOrder(ITMenUniformSetLabel.Text, price);
            addOrder.Show();
            this.Close();
        }
        //END Uniform Set


        //HEADERSS

        private void ShsLabel_Click(object sender, EventArgs e)
        {
            category = "SHS";
            genderCheckpoint = new GenderCheckpoint(category);
            genderCheckpoint.Show();
            this.Close();
        }

        private void SHSImageCard_Click(object sender, EventArgs e)
        {
            category = "SHS";
            genderCheckpoint = new GenderCheckpoint(category);
            genderCheckpoint.Show();
            this.Close();
        }

    }
}
