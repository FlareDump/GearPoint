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
        Main_Menu mainMenu = new Main_Menu();
        FemaleShsForm femaleShsForm = new FemaleShsForm();

        public string category;
        public char gender;

        public GenderCheckpoint(string category)
        {
            this.category = category;
            InitializeComponent();

        }

        private void GenderCheckpoint_Load(object sender, EventArgs e)
        {
            
        }

        private void BACKButton4_Click(object sender, EventArgs e)
        {
            mainMenu.Show();
        }

        private void FEMALEButton2_Click(object sender, EventArgs e)
        {
            femaleShsForm.Show();
            this.Hide();
            this.Close();
        }

        private void MALEButton1_Click(object sender, EventArgs e)
        {
            gender = 'M';

            if (gender == 'M' && category == "SHS")
            {
                maleShsForm = new MaleShsForm(category, gender); 
                maleShsForm.Show();
                this.Hide();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Choices");
            }
            
        }
    }
 }
   