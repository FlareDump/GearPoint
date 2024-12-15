using System;
using System.CodeDom;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GearPoint
{
    public partial class MaleShsForm : Form
    {
        private string gender;
        private string category;
        private double price;
        string lastForm;

        AddOrder addOrder;
        Cart cart;

        public MaleShsForm(string gender, string lastForm)
        {
            this.gender = gender;
            this.lastForm = lastForm;
            InitializeComponent();
        }

        public MaleShsForm(string lastForm)
        {
            this.lastForm = lastForm;
            InitializeComponent();
        }

        private void MaleShsForm_Load(object sender, EventArgs e)
        {
            DatabaseHandler dbHandler = new DatabaseHandler();
            DataTable cartData = dbHandler.GetCartData(); // This updates TotalPrice
            decimal TotalPrice = dbHandler.TotalPrice;

            TotalOutputLbl.Text = "₱" + TotalPrice.ToString("F2");
        }

        // Unified method for handling item selection
        private void HandleItemSelection(string itemName, double itemPrice, Image itemImage)
        {
            price = itemPrice;
            addOrder = new AddOrder(itemName, gender, price, "MaleSHS", itemImage);
            addOrder.Show();
            this.Close();
        }

        // Gender Checkpoint Handlers
        private void HandleCategorySelection(string newCategory, string lastForm)
        {
            Console.WriteLine("User choosen a Category and will proceed to Gender Checkpoint...");
            category = newCategory;
            var genderCheckpoint = new GenderCheckpoint(category, lastForm);
            genderCheckpoint.Show();
            this.Close();
        }

        private void ICTHeaderLabel_Click(object sender, EventArgs e) => HandleCategorySelection("IT", "MaleSHS");
        private void ICTHeaderImage_Click(object sender, EventArgs e) => HandleCategorySelection("IT", "MaleSHS");
        private void TMHeaderLabel_Click(object sender, EventArgs e) => HandleCategorySelection("TM", "MaleSHS");
        private void TMHeaderImage_Click(object sender, EventArgs e) => HandleCategorySelection("TM", "MaleSHS");
        private void HMLabelCard_Click(object sender, EventArgs e) => HandleCategorySelection("HM", "MaleSHS");
        private void HMHeaderImage_Click(object sender, EventArgs e) => HandleCategorySelection("HM", "MaleSHS");


        // Top Item Handlers
        private void SHSMenTopImage_Click(object sender, EventArgs e) => HandleItemSelection(SHSMenTopLbl.Text, 250, SHSMenTopImage.BackgroundImage);
        private void SHSMenTopLbl_Click(object sender, EventArgs e) => HandleItemSelection(SHSMenTopLbl.Text, 250, SHSMenTopImage.BackgroundImage);
        private void SHSMentopCard_Click(object sender, EventArgs e) => HandleItemSelection(SHSMenTopLbl.Text, 250, SHSMenTopImage.BackgroundImage);

        // Pants Handlers
        private void SHSMenPantsImage_Click(object sender, EventArgs e) => HandleItemSelection(SHSMenPantsLabel.Text, 300, SHSMenPantsImage.BackgroundImage);
        private void SHSMenPantsLabel_Click(object sender, EventArgs e) => HandleItemSelection(SHSMenPantsLabel.Text, 300, SHSMenPantsImage.BackgroundImage);
        private void SHSMenPantsBackCard_Click(object sender, EventArgs e) => HandleItemSelection(SHSMenPantsLabel.Text, 300, SHSMenPantsImage.BackgroundImage);

        // Neck Tie Handlers
        private void SHSMenNeckTieImage_Click(object sender, EventArgs e) => HandleItemSelection(SHSNeckTieLbl.Text, 85, SHSMenNeckTieImage.BackgroundImage);
        private void SHSNeckTieLbl_Click(object sender, EventArgs e) => HandleItemSelection(SHSNeckTieLbl.Text, 85, SHSMenNeckTieImage.BackgroundImage);
        private void SHSNeckTieBackCard_Click(object sender, EventArgs e) => HandleItemSelection(SHSNeckTieLbl.Text, 85, SHSMenNeckTieImage.BackgroundImage);

        // Uniform Set Handlers
        private void SHSMenUniformSetImage_Click(object sender, EventArgs e) => HandleItemSelection(SHSMenUniformSetLbl.Text, 635, SHSMenUniformSetImage.BackgroundImage);
        private void SHSMenUniformSetLbl_Click(object sender, EventArgs e) => HandleItemSelection(SHSMenUniformSetLbl.Text, 635, SHSMenUniformSetImage.BackgroundImage);
        private void SHSMenUniformSetBackCard_Click(object sender, EventArgs e) => HandleItemSelection(SHSMenUniformSetLbl.Text, 635, SHSMenUniformSetImage.BackgroundImage);

        // Proware Handlers
        private void HandleProwareNavigation()
        {
            Console.WriteLine("User choosen Proware...");
            var prowareForm = new ProwareForm(category, lastForm);
            prowareForm.Show();
            this.Close();
        }

        private void ProwareLabelCard_Click(object sender, EventArgs e) => HandleProwareNavigation();
        private void ProwareImageCard_Click(object sender, EventArgs e) => HandleProwareNavigation();

        // Cart Handler
        private void CartIcon_Click(object sender, EventArgs e)
        {
            var cart = new Cart("MaleSHS");
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
