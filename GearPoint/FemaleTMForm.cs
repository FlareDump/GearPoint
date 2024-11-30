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
    public partial class FemaleTMForm : Form
    {
        string category;
        char gender;
        double price;
        Cart cart;
        public FemaleTMForm(char gender)
        {
            this.gender = gender;
            InitializeComponent();
        }

        
    }
}
