using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace GearPoint
{
    public partial class MaleITForm : Form
    {
        private string gender;
        private string category;
        private double price;
        string lastForm;
        public string totalPrice;

        public MaleITForm(string gender, string lastForm)
        {
            this.gender = gender;
            this.lastForm = lastForm;
            InitializeComponent();
        }

        public MaleITForm(string lastForm)
        {
            this.lastForm = lastForm;
            InitializeComponent();
        }

        // Reusable method for adding orders
        private void AddOrderItem(string itemName, double itemPrice, Image ItemImage)
        {
            price = itemPrice;
            var addOrder = new AddOrder(itemName, gender, price, "MaleIT", ItemImage);
            addOrder.Show();
            this.Close();
        }

        // Reusable method for navigating to other forms
        private void NavigateToForm(string selectedCategory, bool isProware = false)
        {
            if (isProware)
            {
                Console.WriteLine("User choosen Proware...");
                var prowareForm = new ProwareForm(category, "MaleIT");
                prowareForm.Show();
            }
            else
            {
                Console.WriteLine("User choosen a Category and will proceed to Gender Checkpoint...");
                var genderCheckpoint = new GenderCheckpoint(selectedCategory, "MaleIT");
                genderCheckpoint.Show();
            }
            this.Close();
        }

        // IT Top Handlers
        private void ITMenTopImage_Click(object sender, EventArgs e) => AddOrderItem(ITMenTopLbl.Text, 350, ITMenTopImage.BackgroundImage);
        private void ITMenTopLbl_Click(object sender, EventArgs e) => AddOrderItem(ITMenTopLbl.Text, 350, ITMenTopImage.BackgroundImage);
        private void ICTMentopCard_Click(object sender, EventArgs e) => AddOrderItem(ITMenTopLbl.Text, 350, ITMenTopImage.BackgroundImage);

        // IT Pants Handlers
        private void ITMenPantsLabel_Click(object sender, EventArgs e) => AddOrderItem(ITMenPantsLabel.Text, 400, ITMenPantsImage.BackgroundImage);
        private void ITMenPantsImage_Click(object sender, EventArgs e) => AddOrderItem(ITMenPantsLabel.Text, 400, ITMenPantsImage.BackgroundImage);
        private void ITMenPantsBackCard_Click(object sender, EventArgs e) => AddOrderItem(ITMenPantsLabel.Text, 400, ITMenPantsImage.BackgroundImage);

        // IT Uniform Set Handlers
        private void ITMenUniformSetLabel_Click(object sender, EventArgs e) => AddOrderItem(ITMenUniformSetLabel.Text, 750, ITmenUniformSetImage.BackgroundImage);
        private void ITmenUniformSetImage_Click(object sender, EventArgs e) => AddOrderItem(ITMenUniformSetLabel.Text, 750, ITmenUniformSetImage.BackgroundImage);
        private void ITmenUniformSetBackCard_Click(object sender, EventArgs e) => AddOrderItem(ITMenUniformSetLabel.Text, 750, ITmenUniformSetImage.BackgroundImage);

        // Navigation Handlers
        private void ProwareLabelCard_Click(object sender, EventArgs e) => NavigateToForm(category, true);
        private void ProwareImageCard_Click(object sender, EventArgs e) => NavigateToForm(category, true);

        private void ShsLabel_Click(object sender, EventArgs e) => NavigateToForm("SHS");
        private void SHSImageCard_Click(object sender, EventArgs e) => NavigateToForm("SHS");

        private void TMLabel_Click(object sender, EventArgs e) => NavigateToForm("TM");
        private void TMImageCard_Click(object sender, EventArgs e) => NavigateToForm("TM");

        private void HMLabelCard_Click(object sender, EventArgs e) => NavigateToForm("HM");
        private void HMImageCard_Click(object sender, EventArgs e) => NavigateToForm("HM");

        private void MaleITForm_Load(object sender, EventArgs e)
        {
            DatabaseHandler dbHandler = new DatabaseHandler();
            DataTable cartData = dbHandler.GetCartData(); // This updates TotalPrice
            decimal TotalPrice = dbHandler.TotalPrice;

            TotalOutputLbl.Text = "₱" + TotalPrice.ToString("F2");
        }

        private void CartIcon_Click(object sender, EventArgs e)
        {
            var cart = new Cart("MaleIT");
            cart.Show();
            this.Close();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment("FemaleHM");
            payment.Show();
            this.Close();
        }
    }
}
