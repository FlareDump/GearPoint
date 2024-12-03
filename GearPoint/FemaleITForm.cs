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
    public partial class FemaleITForm : Form
    {

        char gender;
        string category;
        double price;
 
        Cart cart;
        AddOrder addOrder;
        GenderCheckpoint genderCheckpoint;
        ProwareForm prowareForm;

        public FemaleITForm(char gender)
        {
            this.gender = gender;
            InitializeComponent();
        }

        private void ITBlouseLabel_Click(object sender, EventArgs e)
        {
            price = 250;
            addOrder = new AddOrder(ITBlouseLabel.Text, gender , price);
            addOrder.Show();
            this.Close();
        }

        private void ITBlouseImage_Click(object sender, EventArgs e)
        {
            price = 250;
            addOrder = new AddOrder(ITBlouseLabel.Text, gender, price);
            addOrder.Show();
            this.Close();
        }

        private void ITBlouseBackCard_Click(object sender, EventArgs e)
        {
            price = 250;
            addOrder = new AddOrder(ITBlouseLabel.Text, gender, price);
            addOrder.Show();
            this.Close();
        }
    }
}
