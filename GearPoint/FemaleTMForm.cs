using System;
using System.Windows.Forms;

namespace GearPoint
{
    public partial class FemaleTMForm : Form
    {
        private char gender;
        private string category;
        string lastForm;

        public FemaleTMForm(char gender, string lastForm)
        {
            this.gender = gender;
            this.lastForm = lastForm;
            InitializeComponent();
        }

        // Reusable method for adding orders
        private void AddOrderItem(string itemName, double price)
        {
            var addOrder = new AddOrder(itemName, gender, price, "FemaleTM");
            addOrder.Show();
            this.Close();
        }

        // Reusable method for navigation
        private void NavigateToForm(string selectedCategory, bool isProware = false)
        {
            if (isProware)
            {
                var prowareForm = new ProwareForm(selectedCategory, "FemaleTM");
                prowareForm.Show();
            }
            else
            {
                var genderCheckpoint = new GenderCheckpoint(selectedCategory, "FemaleTM");
                genderCheckpoint.Show();
            }
            this.Close();
        }

        // TM Blouse Handlers
        private void TMBlouseLabel_Click(object sender, EventArgs e) => AddOrderItem(TMBlouseLabel.Text, 300);
        private void TMBlouseImage_Click(object sender, EventArgs e) => AddOrderItem(TMBlouseLabel.Text, 300);
        private void TMBlouseBackCard_Click(object sender, EventArgs e) => AddOrderItem(TMBlouseLabel.Text, 300);

        // TM Blazer Handlers
        private void TMBlazerLabel_Click(object sender, EventArgs e) => AddOrderItem(TMBlazerLabel.Text, 600);
        private void TMBlazerImage_Click(object sender, EventArgs e) => AddOrderItem(TMBlazerLabel.Text, 600);
        private void TMBlazerBackCard_Click(object sender, EventArgs e) => AddOrderItem(TMBlazerLabel.Text, 600);

        // TM NeckTie Handlers
        private void TMNeckTieLabel_Click(object sender, EventArgs e) => AddOrderItem(TMNeckTieLabel.Text, 100);
        private void TMNeckTieImage_Click(object sender, EventArgs e) => AddOrderItem(TMNeckTieLabel.Text, 100);
        private void TMNeckTieBackCard_Click(object sender, EventArgs e) => AddOrderItem(TMNeckTieLabel.Text, 100);

        // TM Skirt Handlers
        private void TMSkirtLabel_Click(object sender, EventArgs e) => AddOrderItem(TMSkirtLabel.Text, 400);
        private void TMSkirtImage_Click(object sender, EventArgs e) => AddOrderItem(TMSkirtLabel.Text, 400);
        private void TMSkirtBackCard_Click(object sender, EventArgs e) => AddOrderItem(TMSkirtLabel.Text, 400);

        // TM Uniform Set Handlers
        private void TMUniformSetLabel_Click(object sender, EventArgs e) => AddOrderItem(TMUniformSetLabel.Text, 1200);
        private void TMUniformSetImage_Click(object sender, EventArgs e) => AddOrderItem(TMUniformSetLabel.Text, 1200);
        private void TMUniformSetBackCard_Click(object sender, EventArgs e) => AddOrderItem(TMUniformSetLabel.Text, 1200);

        // Navigation Handlers
        private void ShsLabel_Click(object sender, EventArgs e) => NavigateToForm("SHS");
        private void SHSImage_Click(object sender, EventArgs e) => NavigateToForm("SHS");

        private void ITLabel_Click(object sender, EventArgs e) => NavigateToForm("IT");
        private void ITImage_Click(object sender, EventArgs e) => NavigateToForm("IT");

        private void ProwareLabel_Click(object sender, EventArgs e) => NavigateToForm(category, true);
        private void ProwareImage_Click(object sender, EventArgs e) => NavigateToForm(category, true);

        private void HMLabel_Click(object sender, EventArgs e) => NavigateToForm("HM");
        private void HMImage_Click(object sender, EventArgs e) => NavigateToForm("HM");

        private void TotalOutputLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
