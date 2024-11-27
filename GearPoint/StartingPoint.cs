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
    public partial class StartingPoint : Form
    {
        public StartingPoint()
        {
            InitializeComponent();
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            Main_Menu mainMenu = new Main_Menu();
            mainMenu.Show();
            this.Hide();
        }

        private void StartingPoint_Load(object sender, EventArgs e)
        {

        }
    }
}
