using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace GearPoint
{
    public partial class FemaleTMForm : Form
    {
        private string gender;
        private string category = "Proware";
        string lastForm;

        public FemaleTMForm(string lastForm)
        {
            this.lastForm = lastForm;
            InitializeComponent();
        }

        public FemaleTMForm(string gender, string lastForm)
        {
            this.gender = gender;
            this.lastForm = lastForm;
            InitializeComponent();
        }

        // Reusable method for adding orders
        private void AddOrderItem(string itemName, double price, Image ItemIamge)
        {
            var addOrder = new AddOrder(itemName, gender, price, "FemaleTM", ItemIamge);
            addOrder.Show();
            this.Close();
        }

        // Reusable method for navigation
        private void NavigateToForm(string selectedCategory, bool isProware = false)
        {
            if (isProware)
            {
                Console.WriteLine("User choosen Proware...");
                var prowareForm = new ProwareForm(category, "FemaleTM");
                prowareForm.Show();
            }
            else
            {
                Console.WriteLine("User choosen a Category and will proceed to Gender Checkpoint...");
                var genderCheckpoint = new GenderCheckpoint(selectedCategory, "FemaleTM");
                genderCheckpoint.Show();
            }
            this.Close();
        }

        // TM Blouse Handlers
        private void TMBlouseLabel_Click(object sender, EventArgs e) => AddOrderItem(TMBlouseLabel.Text, 300, TMBlouseImage.BackgroundImage);
        private void TMBlouseImage_Click(object sender, EventArgs e) => AddOrderItem(TMBlouseLabel.Text, 300, TMBlouseImage.BackgroundImage);
        private void TMBlouseBackCard_Click(object sender, EventArgs e) => AddOrderItem(TMBlouseLabel.Text, 300, TMBlouseImage.BackgroundImage);

        // TM Blazer Handlers
        private void TMBlazerLabel_Click(object sender, EventArgs e) => AddOrderItem(TMBlazerLabel.Text, 600, TMBlazerImage.BackgroundImage);
        private void TMBlazerImage_Click(object sender, EventArgs e) => AddOrderItem(TMBlazerLabel.Text, 600, TMBlazerImage.BackgroundImage);
        private void TMBlazerBackCard_Click(object sender, EventArgs e) => AddOrderItem(TMBlazerLabel.Text, 600, TMBlazerImage.BackgroundImage);

        // TM NeckTie Handlers
        private void TMNeckTieLabel_Click(object sender, EventArgs e) => AddOrderItem(TMNeckTieLabel.Text, 100, TMNeckTieImage.BackgroundImage);
        private void TMNeckTieImage_Click(object sender, EventArgs e) => AddOrderItem(TMNeckTieLabel.Text, 100, TMNeckTieImage.BackgroundImage);
        private void TMNeckTieBackCard_Click(object sender, EventArgs e) => AddOrderItem(TMNeckTieLabel.Text, 100, TMNeckTieImage.BackgroundImage);

        // TM Skirt Handlers
        private void TMSkirtLabel_Click(object sender, EventArgs e) => AddOrderItem(TMSkirtLabel.Text, 400, TMSkirtImage.BackgroundImage);
        private void TMSkirtImage_Click(object sender, EventArgs e) => AddOrderItem(TMSkirtLabel.Text, 400, TMSkirtImage.BackgroundImage);
        private void TMSkirtBackCard_Click(object sender, EventArgs e) => AddOrderItem(TMSkirtLabel.Text, 400, TMSkirtImage.BackgroundImage);

        // TM Uniform Set Handlers
        private void TMUniformSetLabel_Click(object sender, EventArgs e) => AddOrderItem(TMUniformSetLabel.Text, 1200, TMUniformSetImage.BackgroundImage);
        private void TMUniformSetImage_Click(object sender, EventArgs e) => AddOrderItem(TMUniformSetLabel.Text, 1200, TMUniformSetImage.BackgroundImage);
        private void TMUniformSetBackCard_Click(object sender, EventArgs e) => AddOrderItem(TMUniformSetLabel.Text, 1200, TMUniformSetImage.BackgroundImage);

        // Navigation Handlers
        private void ShsLabel_Click(object sender, EventArgs e) => NavigateToForm("SHS");
        private void SHSImage_Click(object sender, EventArgs e) => NavigateToForm("SHS");

        private void ITLabel_Click(object sender, EventArgs e) => NavigateToForm("IT");
        private void ITImage_Click(object sender, EventArgs e) => NavigateToForm("IT");

        private void ProwareLabel_Click(object sender, EventArgs e) => NavigateToForm(category, true);
        private void ProwareImage_Click(object sender, EventArgs e) => NavigateToForm(category, true);

        private void HMLabel_Click(object sender, EventArgs e) => NavigateToForm("HM");
        private void HMImage_Click(object sender, EventArgs e) => NavigateToForm("HM");

        private void FemaleTMForm_Load(object sender, EventArgs e)
        {
            DatabaseHandler dbHandler = new DatabaseHandler();
            DataTable cartData = dbHandler.GetCartData(); // This updates TotalPrice
            decimal TotalPrice = dbHandler.TotalPrice;

            TotalOutputLbl.Text = "₱" + TotalPrice.ToString("F2");
        }

        private void CartIcon_Click(object sender, EventArgs e)
        {
            var cart = new Cart("FemaleTM");
            cart.Show();
            this.Close();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment("FemaleTM");
            payment.Show();
            this.Close();
        }
    }
}
