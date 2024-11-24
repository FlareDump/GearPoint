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
    public partial class GenderCheckpoint : Form

    {
        private MaleShsForm maleShsForm;
        MainMenu mainMenu = new MainMenu();
        FemaleShsForm femaleShsForm = new FemaleShsForm();  

        public GenderCheckpoint()

        {
            InitializeComponent();

        }

        private void GenderCheckpoint_Load(object sender, EventArgs e)
        {
            
        }

        private void BACKButton4_Click(object sender, EventArgs e)
        {

        }

        private void FEMALEButton2_Click(object sender, EventArgs e)
        {
            femaleShsForm.Show();
            this.Hide();
            this.Close();
        }

        private void MALEButton1_Click(object sender, EventArgs e)
        {
            maleShsForm.Show();
            this.Hide();
            this.Close();
        }
    }
 }
   