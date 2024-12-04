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
        char gender;
        string category;
        double price;

        Cart cart;
        AddOrder addOrder;
        GenderCheckpoint genderCheckpoint;
        ProwareForm prowareForm;
        public FemaleTMForm(char gender)
        {
            this.gender = gender;
            InitializeComponent();
        }

        private void FemaleTMForm_Load(object sender, EventArgs e)
        {

        }

        //TM Blouse
        private void TMBlouseLabel_Click(object sender, EventArgs e)
        {
            addOrder = new AddOrder(TMBlouseLabel.Text, gender, price);
            addOrder.Show();
            this.Close();
        }

        private void TMBlouseImage_Click(object sender, EventArgs e)
        {
            addOrder = new AddOrder(TMBlouseLabel.Text, gender, price);
            addOrder.Show();
            this.Close();
        }

        private void TMBlouseBackCard_Click(object sender, EventArgs e)
        {
            addOrder = new AddOrder(TMBlouseLabel.Text, gender, price);
            addOrder.Show();
            this.Close();
        }
        //END TM Blouse

        //TM Blazer
        private void TMBlazerLabel_Click(object sender, EventArgs e)
        {
            addOrder = new AddOrder(TMBlazerLabel.Text, gender, price);
            addOrder.Show();
            this.Close();
        }

        private void TMBlazerImage_Click(object sender, EventArgs e)
        {
            addOrder = new AddOrder(TMBlazerLabel.Text, gender, price);
            addOrder.Show();
            this.Close();
        }

        private void TMBlazerBackCard_Click(object sender, EventArgs e)
        {
            addOrder = new AddOrder(TMBlazerLabel.Text, gender, price);
            addOrder.Show();
            this.Close();
        }
        //END TM Blazer

        //TM NeckTie
        private void TMNeckTieLabel_Click(object sender, EventArgs e)
        {
            addOrder = new AddOrder(TMNeckTieLabel.Text, gender, price);
            addOrder.Show();
            this.Close();
        }

        private void TMNeckTieImage_Click(object sender, EventArgs e)
        {
            addOrder = new AddOrder(TMNeckTieLabel.Text, gender, price);
            addOrder.Show();
            this.Close();
        }

        private void TMNeckTieBackCard_Click(object sender, EventArgs e)
        {
            addOrder = new AddOrder(TMNeckTieLabel.Text, gender, price);
            addOrder.Show();
            this.Close();
        }
        //END TM NeckTie

        //TM Skirt
        private void TMSkirtLabel_Click(object sender, EventArgs e)
        {
            addOrder = new AddOrder(TMSkirtLabel.Text, gender, price);
            addOrder.Show();
            this.Close();
        }

        private void TMSkirtImage_Click(object sender, EventArgs e)
        {
            addOrder = new AddOrder(TMSkirtLabel.Text, gender, price);
            addOrder.Show();
            this.Close();
        }

        private void TMSkirtBackCard_Click(object sender, EventArgs e)
        {
            addOrder = new AddOrder(TMSkirtLabel.Text, gender, price);
            addOrder.Show();
            this.Close();
        }
        //END TM Skirt

        //TM Uniform Set
        private void TMUniformSetLabel_Click(object sender, EventArgs e)
        {
            addOrder = new AddOrder(TMUniformSetLabel.Text, gender, price);
            addOrder.Show();
            this.Close();
        }

        private void TMUniformSetImage_Click(object sender, EventArgs e)
        {
            addOrder = new AddOrder(TMUniformSetLabel.Text, gender, price);
            addOrder.Show();
            this.Close();
        }

        private void TMUniformSetBackCard_Click(object sender, EventArgs e)
        {
            addOrder = new AddOrder(TMUniformSetLabel.Text, gender, price);
            addOrder.Show();
            this.Close();
        }
        //TM Uniform Set

        //Headers

        //SHS
        private void ShsLabel_Click(object sender, EventArgs e)
        {
            category = "SHS";
            genderCheckpoint = new GenderCheckpoint(category);
            genderCheckpoint.Show();
            this.Close();
        }

        private void SHSImage_Click(object sender, EventArgs e)
        {
            category = "SHS";
            genderCheckpoint = new GenderCheckpoint(category);
            genderCheckpoint.Show();
            this.Close();
        }
        //END SHS

        //IT
        private void ITLabel_Click(object sender, EventArgs e)
        {
            category = "IT";
            genderCheckpoint = new GenderCheckpoint(category);
            genderCheckpoint.Show();
            this.Close();
        }

        private void ITImage_Click(object sender, EventArgs e)
        {
            category = "IT";
            genderCheckpoint = new GenderCheckpoint(category);
            genderCheckpoint.Show();
            this.Close();
        }
        //END IT

        //Proware
        private void ProwareLabel_Click(object sender, EventArgs e)
        {
            prowareForm = new ProwareForm(category);
            prowareForm.Show();
            this.Close();
        }

        private void ProwareImage_Click(object sender, EventArgs e)
        {
            prowareForm = new ProwareForm(category);
            prowareForm.Show();
            this.Close();
        }
        //End Proware

        //HM
        private void HMLabel_Click(object sender, EventArgs e)
        {
            category = "HM";
            genderCheckpoint = new GenderCheckpoint(category);
            genderCheckpoint.Show();
            this.Close();
        }

        private void HMImage_Click(object sender, EventArgs e)
        {
            category = "HM";
            genderCheckpoint = new GenderCheckpoint(category);
            genderCheckpoint.Show();
            this.Close();
        }
        //END HM

    }
}
