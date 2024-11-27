using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GearPoint
{
    public partial class Main_Menu : Form
    {
        GenderCheckpoint GenderCheckpoint = new GenderCheckpoint();
        public Main_Menu()
        {

            InitializeComponent();
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {

        }
        //Shs Card button
        private void ShsImageCard_Click(object sender, EventArgs e)
        {
            GenderCheckpoint.Show();
            this.Close();
        }

        private void ShsLabelCard_Click(object sender, EventArgs e)
        {
            GenderCheckpoint.Show();
            this.Close();
        }

        private void ShsBackCard_Click(object sender, EventArgs e)
        {
            GenderCheckpoint.Show();
            this.Close();
        }
        // End of Shs Card button

        // ICT Card Button
        private void ICTImageCard_Click(object sender, EventArgs e)
        {
            GenderCheckpoint.Show();
            this.Close();
        }

        private void ICTLabelCard_Click(object sender, EventArgs e)
        {
            GenderCheckpoint.Show();
            this.Close();
        }

        private void ICTBackCard_Click(object sender, EventArgs e)
        {
            GenderCheckpoint.Show();
            this.Close();
        }
        // End of ICT Card Button

        // TM Card Button

        private void TMLabelCard_Click(object sender, EventArgs e)
        {
            GenderCheckpoint.Show();
            this.Close();
        }

        private void TMImageCard_Click(object sender, EventArgs e)
        {
            GenderCheckpoint.Show();
            this.Close();
        }

        private void TMBackCard_Click(object sender, EventArgs e)
        {
            GenderCheckpoint.Show();
            this.Close();
        }
        // End of TM Card Button

        // HM Card Button
        private void HMLabelCard_Click(object sender, EventArgs e)
        {
            GenderCheckpoint.Show();
            this.Close();
        }

        private void HMImageCard_Click(object sender, EventArgs e)
        {
            GenderCheckpoint.Show();
            this.Close();
        }

        private void HMBackCard_Click(object sender, EventArgs e)
        {
            GenderCheckpoint.Show();
            this.Close();

        }
        // End of HM Card Button

        // Proware Card Button
        private void ProwareLabelCard_Click(object sender, EventArgs e)
        {
            GenderCheckpoint.Show();
            this.Close();
        }

        private void ProwareImageCard_Click(object sender, EventArgs e)
        {
            GenderCheckpoint.Show();
            this.Close();
        }

        private void ProwareBackCard_Click(object sender, EventArgs e)
        {
            GenderCheckpoint.Show();
            this.Close();
        }
        // End of Prwoware Card Button

    }
}