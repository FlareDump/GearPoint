using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace GearPoint
{
    public partial class FemaleShsForm : Form
    {
        private string gender;
        private string category = "Proware";
        private double price;
        string lastForm;
        public string totalPrice;

        public FemaleShsForm(string lastForm)
        {
            this.lastForm = lastForm;
            InitializeComponent();
        }

        public FemaleShsForm(string gender, string lastForm)
        {
            this.gender = gender;
            this.lastForm = lastForm;
            InitializeComponent();
        }

        private void FemaleShsForm_Load(object sender, EventArgs e) 
        {
            DatabaseHandler dbHandler = new DatabaseHandler();
            DataTable cartData = dbHandler.GetCartData(); // This updates TotalPrice
            decimal TotalPrice = dbHandler.TotalPrice;

            TotalOutputLbl.Text = "₱" + TotalPrice.ToString("F2");
        }

        // Reusable method for handling item selection
        private void HandleItemSelection(string itemName, double itemPrice, Image ItemImage)
        {
            price = itemPrice;
            var addOrder = new AddOrder(itemName, gender, price, "FemaleSHS", ItemImage);
            addOrder.Show();
            this.Close();
        }

        // Top Item Handlers
        private void ShsWomenTopPoloPicture_Click(object sender, EventArgs e) => HandleItemSelection(SHSWomenPoloTopLbl.Text, 250, ShsWomenTopPoloPicture.BackgroundImage);
        private void SHSWomenPoloTopLbl_Click(object sender, EventArgs e) => HandleItemSelection(SHSWomenPoloTopLbl.Text, 250, ShsWomenTopPoloPicture.BackgroundImage);
        private void SHSWomenPoloTopBackCard_Click(object sender, EventArgs e) => HandleItemSelection(SHSWomenPoloTopLbl.Text, 250, ShsWomenTopPoloPicture.BackgroundImage);

        // Skirt Handlers
        private void SHSWomenPantsImage_Click(object sender, EventArgs e) => HandleItemSelection(SHSWomenSkirtLbl.Text, 200, SHSWomenPantsImage.BackgroundImage);
        private void SHSWomenSkirtLbl_Click(object sender, EventArgs e) => HandleItemSelection(SHSWomenSkirtLbl.Text, 200, SHSWomenPantsImage.BackgroundImage);
        private void SHSWomenSkirtBackCard_Click(object sender, EventArgs e) => HandleItemSelection(SHSWomenSkirtLbl.Text, 200, SHSWomenPantsImage.BackgroundImage);

        // Neck Tie Handlers
        private void ShsWomenNeckTiePicture_Click(object sender, EventArgs e) => HandleItemSelection(SHSWomenNeckTieLbl.Text, 85, ShsWomenNeckTiePicture.BackgroundImage);
        private void SHSWomenNeckTieLbl_Click(object sender, EventArgs e) => HandleItemSelection(SHSWomenNeckTieLbl.Text, 85, ShsWomenNeckTiePicture.BackgroundImage);
        private void SHSWomenNeckTieBackCard_Click(object sender, EventArgs e) => HandleItemSelection(SHSWomenNeckTieLbl.Text, 85, ShsWomenNeckTiePicture.BackgroundImage);

        // Uniform Set Handlers
        private void ShsWomenUniformSetPicture_Click(object sender, EventArgs e) => HandleItemSelection(ShsWomenUniformSetLbl.Text, 535, ShsWomenUniformSetPicture.BackgroundImage);
        private void ShsWomenUniformSetLbl_Click(object sender, EventArgs e) => HandleItemSelection(ShsWomenUniformSetLbl.Text, 535, ShsWomenUniformSetPicture.BackgroundImage);
        private void ShsWomenUniformSetBackCard_Click(object sender, EventArgs e) => HandleItemSelection(ShsWomenUniformSetLbl.Text, 535, ShsWomenUniformSetPicture.BackgroundImage);

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

        // Category Selection Handlers
        private void HandleCategorySelection(string newCategory)
        {
            Console.WriteLine("User choosen a Category and will proceed to Gender Checkpoint...");
            category = newCategory;
            var genderCheckpoint = new GenderCheckpoint(category, lastForm);
            genderCheckpoint.Show();
            this.Close();
        }

        private void ICTHeaderLabel_Click(object sender, EventArgs e) => HandleCategorySelection("IT");
        private void ICTHeaderImage_Click(object sender, EventArgs e) => HandleCategorySelection("IT");
        private void TMHeaderLabel_Click(object sender, EventArgs e) => HandleCategorySelection("TM");
        private void TMHeaderImage_Click(object sender, EventArgs e) => HandleCategorySelection("TM");
        private void HMLabelCard_Click(object sender, EventArgs e) => HandleCategorySelection("HM");
        private void HMHeaderImage_Click(object sender, EventArgs e) => HandleCategorySelection("HM");

        // Cart Icon Handler
        private void CartIcon_Click(object sender, EventArgs e)
        {
            var cart = new Cart("FemaleSHS");
            cart.Show();
            this.Close();
        }

        private void PaymentButton_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment("FemaleSHS");
            payment.Show();
            this.Close();
        }
    }
}
