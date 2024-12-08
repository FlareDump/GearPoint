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

        public string item, gender, size, quantity, price, total;

        public Cart(string item, string gender, string size, string quantity, string price, string total)
        {
            this.item = item;
            this.gender = gender;
            this.size = size;
            this.quantity = quantity;
            this.price = price;
            this.total = total;
            InitializeComponent();
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            AddToCart(item, gender, size, quantity, price);
            TotalResultlabel.Text = total;
        }

        public void AddToCart(string item, string gender, string size, string quantity, string price)
        {
            CartListGrid1.Rows.Add(item, gender, size, quantity, price);
        }

    }
}
