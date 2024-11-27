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
    public partial class Cart : Form
    {

        string item, gender, size, quantity, price;

        private void roundButton2_Click_1(object sender, EventArgs e)
        {

        }

      

        public Cart(string item, string gender, string size, string quantity, string price)
        {
            this.item = item;
            this.gender = gender;
            this.size = size;
            this.quantity = quantity;
            this.price = price;
            InitializeComponent();
        }

        private void Cart_Load(object sender, EventArgs e)
        {

        }

        public void AddToCart(string item, string gender, string size, string quantity, string price)
        {
            CartListGrid1.Rows.Add(item, gender, size, quantity, price);
        }

    }
}
