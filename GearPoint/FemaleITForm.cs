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
    public partial class FemaleITForm : Form
    {

        char gender;
        string category;
        double price;
 
        Cart cart;
        AddOrder addOrder;
        GenderCheckpoint genderCheckpoint;
        ProwareForm prowareForm;

        public FemaleITForm(char gender)
        {
            this.gender = gender;
            InitializeComponent();
        }

        //IT Blouse
        private void ITBlouseLabel_Click(object sender, EventArgs e)
        {
            price = 250;
            addOrder = new AddOrder(ITBlouseLabel.Text, gender , price);
            addOrder.Show();
            this.Close();
        }

        private void ITBlouseImage_Click(object sender, EventArgs e)
        {
            price = 250;
            addOrder = new AddOrder(ITBlouseLabel.Text, gender, price);
            addOrder.Show();
            this.Close();
        }

        private void ITBlouseBackCard_Click(object sender, EventArgs e)
        {
            price = 250;
            addOrder = new AddOrder(ITBlouseLabel.Text, gender, price);
            addOrder.Show();
            this.Close();
        }
        //END IT Blouse

        //IT Skirt
        private void ITSkirtLabel_Click(object sender, EventArgs e)
        {
            price = 200;
            addOrder = new AddOrder(ITSkirtLabel.Text, gender, price);
            addOrder.Show();
            this.Close();
        }

        private void ITSkirtImage_Click(object sender, EventArgs e)
        {
            price = 200;
            addOrder = new AddOrder(ITSkirtLabel.Text, gender, price);
            addOrder.Show();
            this.Close();
        }

        private void ITSkirtBackCard_Click(object sender, EventArgs e)
        {
            price = 200;
            addOrder = new AddOrder(ITSkirtLabel.Text, gender, price);
            addOrder.Show();
            this.Close();
        }
        //END IT Skirt 

        //IT Pants
        private void ITPantsLabel_Click(object sender, EventArgs e)
        {
            price = 450;
            addOrder = new AddOrder(ITPantsLabel.Text, gender, price);
            addOrder.Show(); 
            this.Close();
        }

        private void ITPantsImage_Click(object sender, EventArgs e)
        {
            price = 450;
            addOrder = new AddOrder(ITPantsLabel.Text, gender, price);
            addOrder.Show();
            this.Close();
        }

        private void ITPantsBackCard_Click(object sender, EventArgs e)
        {
            price = 450;
            addOrder = new AddOrder(ITPantsLabel.Text, gender, price);
            addOrder.Show();
            this.Close();
        }
        //IT Pants

        //IT Set
        private void ITSetLabel_Click(object sender, EventArgs e)
        {
            price = 900;
            addOrder = new AddOrder(ITSetLabel.Text, gender, price);
            addOrder.Show();
            this.Close();
        }

        private void ITSetImage_Click(object sender, EventArgs e)
        {
            price = 900;
            addOrder = new AddOrder(ITSetLabel.Text, gender, price);
            addOrder.Show();
            this.Close();
        }

        private void ITSetBackCard_Click(object sender, EventArgs e)
        {
            price = 900;
            addOrder = new AddOrder(ITSetLabel.Text, gender, price);
            addOrder.Show();
            this.Close();
        }
        //END IT Set

        //Proware
        private void ProwareLabelCard_Click(object sender, EventArgs e)
        {
            prowareForm = new ProwareForm(category);
            prowareForm.Show();
            this.Close();
        }

        private void ProwareImageCard_Click(object sender, EventArgs e)
        {
            prowareForm = new ProwareForm(category);
            prowareForm.Show();
            this.Close();
        }
        //END Proware

        //SHS
        private void ShsLabelCard_Click(object sender, EventArgs e)
        {
            category = "SHS";
            genderCheckpoint = new GenderCheckpoint(category);
            genderCheckpoint.Show();
            this.Close();
        }
        
        private void SHSImageCard_Click(object sender, EventArgs e)
        {
            category = "SHS";
            genderCheckpoint = new GenderCheckpoint(category);
            genderCheckpoint.Show();
            this.Close();
        }

        //END SHS

        //TM
        private void TMimageCard_Click(object sender, EventArgs e)
        {
            category = "TM";
            genderCheckpoint = new GenderCheckpoint(category);
            genderCheckpoint.Show();
            this.Close();
        }

        private void TMLabelCard_Click(object sender, EventArgs e)
        {
            category = "TM";
            genderCheckpoint = new GenderCheckpoint(category);
            genderCheckpoint.Show();
            this.Close();
        }
        //END TM

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
       

    }
}
