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

        GenderCheckpoint genderCheckpoint;

        public ProwareForm(string category)
        {
            this.category = category;
            InitializeComponent();
        }

        private void ProwareForm_Load(object sender, EventArgs e)
        {

        }
        //SHS
        private void SHSLabelCard_Click(object sender, EventArgs e)
        {
            category = "SHS";
            genderCheckpoint = new GenderCheckpoint(category);
            genderCheckpoint.Show();
            this.Close();
        }

        private void SHSimageCard_Click(object sender, EventArgs e)
        {
            category = "SHS";
            genderCheckpoint = new GenderCheckpoint(category);
            genderCheckpoint.Show();
            this.Close();
        }
        //END OF SHS

        //TM
        private void TMLabelCard_Click(object sender, EventArgs e)
        {
            category = "TM";
            genderCheckpoint = new GenderCheckpoint(category);
            genderCheckpoint.Show();
            this.Close();
        }

        private void TMimageCard_Click(object sender, EventArgs e)
        {
            category = "TM";
            genderCheckpoint = new GenderCheckpoint(category);
            genderCheckpoint.Show();
            this.Close();
        }

        //END OF TM

        //IT
        private void ITLabelCard_Click(object sender, EventArgs e)
        {
            category = "IT";
            genderCheckpoint = new GenderCheckpoint(category);
            genderCheckpoint.Show();
            this.Close();
        }

        private void ITimageCard_Click(object sender, EventArgs e)
        {
            category = "IT";
            genderCheckpoint = new GenderCheckpoint(category);
            genderCheckpoint.Show();
            this.Close();
        }
        //END OF IT

        //HM
        private void HMLabelCard_Click(object sender, EventArgs e)
        {
            category = "HM";
            genderCheckpoint = new GenderCheckpoint(category);
            genderCheckpoint.Show();
            this.Close();
        }

        private void HMimageCard_Click(object sender, EventArgs e)
        {
            category = "HM";
            genderCheckpoint = new GenderCheckpoint(category);
            genderCheckpoint.Show();
            this.Close();
        }
        //END OF HM
    }
}
