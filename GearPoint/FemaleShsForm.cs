using System;
using System.Windows.Forms;

namespace GearPoint
{
    public partial class FemaleShsForm : Form
    {
        private readonly char gender;
        private string category;
        private double price;
        string lastForm;

        public FemaleShsForm(char gender, string lastForm)
        {
            this.gender = gender;
            this.lastForm = lastForm;
            InitializeComponent();
        }

        private void FemaleShsForm_Load(object sender, EventArgs e) { }

        // Reusable method for handling item selection
        private void HandleItemSelection(string itemName, double itemPrice)
        {
            price = itemPrice;
            var addOrder = new AddOrder(itemName, gender, price, "FemaleSHS");
            addOrder.Show();
            this.Close();
        }

        // Top Item Handlers
        private void ShsWomenTopPoloPicture_Click(object sender, EventArgs e) => HandleItemSelection(SHSWomenPoloTopLbl.Text, 250);
        private void SHSWomenPoloTopLbl_Click(object sender, EventArgs e) => HandleItemSelection(SHSWomenPoloTopLbl.Text, 250);
        private void SHSWomenPoloTopBackCard_Click(object sender, EventArgs e) => HandleItemSelection(SHSWomenPoloTopLbl.Text, 250);

        // Skirt Handlers
        private void SHSWomenPantsImage_Click(object sender, EventArgs e) => HandleItemSelection(SHSWomenSkirtLbl.Text, 200);
        private void SHSWomenSkirtLbl_Click(object sender, EventArgs e) => HandleItemSelection(SHSWomenSkirtLbl.Text, 200);
        private void SHSWomenSkirtBackCard_Click(object sender, EventArgs e) => HandleItemSelection(SHSWomenSkirtLbl.Text, 200);

        // Neck Tie Handlers
        private void ShsWomenNeckTiePicture_Click(object sender, EventArgs e) => HandleItemSelection(SHSWomenNeckTieLbl.Text, 85);
        private void SHSWomenNeckTieLbl_Click(object sender, EventArgs e) => HandleItemSelection(SHSWomenNeckTieLbl.Text, 85);
        private void SHSWomenNeckTieBackCard_Click(object sender, EventArgs e) => HandleItemSelection(SHSWomenNeckTieLbl.Text, 85);

        // Uniform Set Handlers
        private void ShsWomenUniformSetPicture_Click(object sender, EventArgs e) => HandleItemSelection(ShsWomenUniformSetLbl.Text, 535);
        private void ShsWomenUniformSetLbl_Click(object sender, EventArgs e) => HandleItemSelection(ShsWomenUniformSetLbl.Text, 535);
        private void ShsWomenUniformSetBackCard_Click(object sender, EventArgs e) => HandleItemSelection(ShsWomenUniformSetLbl.Text, 535);

        // Proware Handlers
        private void HandleProwareNavigation()
        {
            var prowareForm = new ProwareForm(category, lastForm);
            prowareForm.Show();
            this.Close();
        }

        private void ProwareLabelCard_Click(object sender, EventArgs e) => HandleProwareNavigation();
        private void ProwareImageCard_Click(object sender, EventArgs e) => HandleProwareNavigation();

        // Category Selection Handlers
        private void HandleCategorySelection(string newCategory)
        {
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
            var cart = new Cart("N/A", "N/A", "N/A", "N/A", "N/A");
            cart.Show();
            this.Close();
        }
    }
}
