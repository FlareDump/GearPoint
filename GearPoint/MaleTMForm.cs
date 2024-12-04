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
    public partial class MaleTMForm : Form
    {
        char gender;
        string category;
        double price;

        Cart cart;
        AddOrder addOrder;
        GenderCheckpoint genderCheckpoint;
        ProwareForm prowareForm;

        public MaleTMForm(char gender)
        {
            this.gender = gender;
            InitializeComponent();
        }

        //TM Polo
        private void TMPoloLabel_Click(object sender, EventArgs e)
        {
            addOrder = new AddOrder(TMPoloLabel.Text, gender, price);
            addOrder.Show();
            this.Close();
        }

        private void TMPoloImage_Click(object sender, EventArgs e)
        {
            addOrder = new AddOrder(TMPoloLabel.Text, gender, price);
            addOrder.Show();
            this.Close();
        }

        private void TMPoloBackCard_Click(object sender, EventArgs e)
        {
            addOrder = new AddOrder(TMPoloLabel.Text, gender, price);
            addOrder.Show();
            this.Close();
        }
        //TM Polo End

        //TM Blazer
        private void TMBlazerLabel_Click(object sender, EventArgs e)
        {
            addOrder = new AddOrder(TMBlazerLabel.Text, gender, price);
            addOrder.Show();
            this.Close();
        }

        private void TMBlazerImage_Click(object sender, EventArgs e)
        {
            addOrder = new AddOrder(TMBlazerLabel.Text, gender, price);
            addOrder.Show();
            this.Close();
        }

        private void TMBlazerBackCard_Click(object sender, EventArgs e)
        {
            addOrder = new AddOrder(TMBlazerLabel.Text, gender, price);
            addOrder.Show();
            this.Close();
        }
        //TM Blazer End

        //TM Pants
        private void TMPantsLabel_Click(object sender, EventArgs e)
        {
            addOrder = new AddOrder(TMPantsLabel.Text, gender, price);
            addOrder.Show();
            this.Close();
        }

        private void TMPantsIamge_Click(object sender, EventArgs e)
        {
            addOrder = new AddOrder(TMPantsLabel.Text, gender, price);
            addOrder.Show();
            this.Close();
        }

        private void TMPantsBackCard_Click(object sender, EventArgs e)
        {
            addOrder = new AddOrder(TMPantsLabel.Text, gender, price);
            addOrder.Show();
            this.Close();
        }
        //TM Pants End

    }
}
