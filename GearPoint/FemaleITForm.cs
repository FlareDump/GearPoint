using System;
using System.Windows.Forms;

namespace GearPoint
{
    public partial class FemaleITForm : Form
    {
        private char gender;
        private string category;
        string lastForm;

        public FemaleITForm(char gender, string lastForm)
        {
            this.gender = gender;
            this.lastForm = lastForm;
            InitializeComponent();
        }

        // Reusable method for adding orders
        private void AddOrderItem(string itemName, double price)
        {
            var addOrder = new AddOrder(itemName, gender, price, "FemaleIT");
            addOrder.Show();
            this.Close();
        }

        // Reusable method for navigation
        private void NavigateToForm(string selectedCategory, bool isProware = false)
        {
            if (isProware)
            {
                var prowareForm = new ProwareForm(selectedCategory, lastForm);
                prowareForm.Show();
            }
            else
            {
                var genderCheckpoint = new GenderCheckpoint(selectedCategory, lastForm);
                genderCheckpoint.Show();
            }
            this.Close();
        }

        // IT Blouse Handlers
        private void ITBlouseLabel_Click(object sender, EventArgs e) => AddOrderItem(ITBlouseLabel.Text, 250);
        private void ITBlouseImage_Click(object sender, EventArgs e) => AddOrderItem(ITBlouseLabel.Text, 250);
        private void ITBlouseBackCard_Click(object sender, EventArgs e) => AddOrderItem(ITBlouseLabel.Text, 250);

        // IT Skirt Handlers
        private void ITSkirtLabel_Click(object sender, EventArgs e) => AddOrderItem(ITSkirtLabel.Text, 200);
        private void ITSkirtImage_Click(object sender, EventArgs e) => AddOrderItem(ITSkirtLabel.Text, 200);
        private void ITSkirtBackCard_Click(object sender, EventArgs e) => AddOrderItem(ITSkirtLabel.Text, 200);

        // IT Pants Handlers
        private void ITPantsLabel_Click(object sender, EventArgs e) => AddOrderItem(ITPantsLabel.Text, 450);
        private void ITPantsImage_Click(object sender, EventArgs e) => AddOrderItem(ITPantsLabel.Text, 450);
        private void ITPantsBackCard_Click(object sender, EventArgs e) => AddOrderItem(ITPantsLabel.Text, 450);

        // IT Set Handlers
        private void ITSetLabel_Click(object sender, EventArgs e) => AddOrderItem(ITSetLabel.Text, 900);
        private void ITSetImage_Click(object sender, EventArgs e) => AddOrderItem(ITSetLabel.Text, 900);
        private void ITSetBackCard_Click(object sender, EventArgs e) => AddOrderItem(ITSetLabel.Text, 900);

        // Proware Handlers
        private void ProwareLabelCard_Click(object sender, EventArgs e) => NavigateToForm(category, true);
        private void ProwareImageCard_Click(object sender, EventArgs e) => NavigateToForm(category, true);

        // SHS Handlers
        private void ShsLabelCard_Click(object sender, EventArgs e) => NavigateToForm("SHS");
        private void SHSImageCard_Click(object sender, EventArgs e) => NavigateToForm("SHS");

        // TM Handlers
        private void TMLabelCard_Click(object sender, EventArgs e) => NavigateToForm("TM");
        private void TMimageCard_Click(object sender, EventArgs e) => NavigateToForm("TM");

        // HM Handlers
        private void HMLabelCard_Click(object sender, EventArgs e) => NavigateToForm("HM");
        private void HMimageCard_Click(object sender, EventArgs e) => NavigateToForm("HM");
    }
}
