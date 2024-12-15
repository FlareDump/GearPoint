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
    public partial class MaleTMForm : Form
    {
        string gender;
        string category;
        double price;
        string lastForm;
        public string totalPrice;

        Cart cart;
        AddOrder addOrder;
        GenderCheckpoint genderCheckpoint;
        ProwareForm prowareForm;

        public MaleTMForm(string gender, string lastForm)
        {
            this.lastForm = lastForm;
            this.gender = gender;
            InitializeComponent();
        }

        public MaleTMForm(string lastForm)
        {
            this.lastForm = lastForm;
            InitializeComponent();
        }

        private void HandleItemSelection(string ItemName, double Itemprice, Image ItemImage)
        {
            price = Itemprice;
            var addOrder = new AddOrder(ItemName, gender, Itemprice, "MaleTM", ItemImage);
            addOrder.Show();
            this.Close();
        }

        private void TMPoloLabel_Click(object sender, EventArgs e) => HandleItemSelection(TMPoloLabel.Text, 450, TMBPoloImage.BackgroundImage);
        private void TMBPoloImage_Click(object sender, EventArgs e) => HandleItemSelection(TMPoloLabel.Text, 450, TMBPoloImage.BackgroundImage);
        private void TMPoloBackCard_Click(object sender, EventArgs e) => HandleItemSelection(TMPoloLabel.Text, 450, TMBPoloImage.BackgroundImage);

        private void TMBlazerLabel_Click(object sender, EventArgs e) => HandleItemSelection(TMBlazerLabel.Text, 700, TMBlazerImage.BackgroundImage);
        private void TMBlazerImage_Click(object sender, EventArgs e) => HandleItemSelection(TMBlazerLabel.Text, 700, TMBlazerImage.BackgroundImage);
        private void TMBlazerBackCard_Click(object sender, EventArgs e) => HandleItemSelection(TMBlazerLabel.Text, 700, TMBlazerImage.BackgroundImage);

        private void TMNeckTieLabel_Click(object sender, EventArgs e) => HandleItemSelection(TMNeckTieLabel.Text, 85, TMNeckTieImage.BackgroundImage);
        private void TMNeckTieImage_Click(object sender, EventArgs e) => HandleItemSelection(TMNeckTieLabel.Text, 85, TMNeckTieImage.BackgroundImage);
        private void TMNeckTieBackCard_Click(object sender, EventArgs e) => HandleItemSelection(TMNeckTieLabel.Text, 85, TMNeckTieImage.BackgroundImage);

        private void TMUniformSetLabel_Click(object sender, EventArgs e) => HandleItemSelection(TMUniformSetLabel.Text, 1235, TMUniformSetImage.BackgroundImage);
        private void TMUniformSetImage_Click(object sender, EventArgs e) => HandleItemSelection(TMUniformSetLabel.Text, 1235, TMUniformSetImage.BackgroundImage);
        private void TMUniformSetBackCard_Click(object sender, EventArgs e) => HandleItemSelection(TMUniformSetLabel.Text, 1235, TMUniformSetImage.BackgroundImage);

        //PROWARE Handler
        private void HandleProwareNavigation()
        {
            Console.WriteLine("User choosen Proware...");
            var prowareForm = new ProwareForm(category, "MaleTM");
            prowareForm.Show();
            this.Close();
        }
        private void ProwareLabelCard_Click(object sender, EventArgs e) => HandleProwareNavigation();
        private void ProwareImageCard_Click(object sender, EventArgs e) => HandleProwareNavigation();
        
        //Category Handler
        private void HandleCategorySelection(string newCategory)
        {
            Console.WriteLine("User choosen a Category and will proceed to Gender Checkpoint...");
            category = newCategory;
            var genderCheckpoint = new GenderCheckpoint(newCategory, "MaleTM");
            genderCheckpoint.Show();
            this.Close();
        }

        //SHS Handler
        private void ShsLabelCard_Click(object sender, EventArgs e) => HandleCategorySelection("SHS");
        private void ShsPictureCard_Click(object sender, EventArgs e) => HandleCategorySelection("SHS");

        //IT Handler
        private void ITLabelCard_Click(object sender, EventArgs e) => HandleCategorySelection("IT");
        private void ITPictureCard_Click(object sender, EventArgs e) => HandleCategorySelection("IT");

        //HM Handler
        private void HMPictureCard_Click(object sender, EventArgs e) => HandleCategorySelection("HM");
        private void HMLabelCard_Click(object sender, EventArgs e) => HandleCategorySelection("HM");

        private void MaleTMForm_Load_1(object sender, EventArgs e)
        {
            DatabaseHandler dbHandler = new DatabaseHandler();
            DataTable cartData = dbHandler.GetCartData(); // This updates TotalPrice
            decimal TotalPrice = dbHandler.TotalPrice;

            TotalOutputLbl.Text = "₱" + TotalPrice.ToString("F2");
        }

        private void CartIcon_Click(object sender, EventArgs e)
        {
            var cart = new Cart("MaleTM");
            cart.Show();
            this.Close();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment("MaleTM");
            payment.Show();
            this.Close();
        }

    }
}
