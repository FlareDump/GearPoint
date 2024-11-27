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
        public FemaleTMForm()
        {
            InitializeComponent();
        }

        private void FemaleTMForm_Load(object sender, EventArgs e)
        {
                this.Size = new Size(1024, 768); // Extend to 1024x768
                this.MinimumSize = new Size(800, 600); // Set a minimum size
                this.MaximumSize = new Size(1920, 1080); // Set a maximum size
           
        }
    }
}
