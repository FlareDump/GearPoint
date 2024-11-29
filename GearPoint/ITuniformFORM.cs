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
    public partial class ITuniformFORM : Form
    {
        string category;
        char gender;
        double price;
        Cart cart;

        AddOrder addOrder;
        public ITuniformFORM(string category, char gender)
        {
            this.category = category;
            this.gender = gender;
            InitializeComponent();
        }

        private void ITuniformFORM_Load(object sender, EventArgs e)
        {
        }

        private void ITMenTopImage_Click(object sender, EventArgs e)
        {

        }
    }
}
