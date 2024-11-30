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
    public partial class ProwareForm : Form
    {

        string category;
        double price;
        Cart cart;

        AddOrder addOrder;

        public ProwareForm(string category)
        {
            this.category = category;
            InitializeComponent();
        }

        private void ProwareForm_Load(object sender, EventArgs e)
        {

        }
    }
}
