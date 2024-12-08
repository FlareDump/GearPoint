using System;
using System.CodeDom;
using System.Windows.Forms;

namespace GearPoint
{
    public partial class MaleShsForm : Form
    {
        private readonly char gender;
        private string category;
        private double price;
        string lastForm;

        public MaleShsForm(char gender, string lastForm)
        {
            this.gender = gender;
            this.lastForm = lastForm;
            InitializeComponent();
        }

        private void MaleShsForm_Load(object sender, EventArgs e) { }

        // Unified method for handling item selection
        private void HandleItemSelection(string itemName, double itemPrice)
        {
            price = itemPrice;
            var addOrder = new AddOrder(itemName, gender, price, "MaleSHS");
            addOrder.Show();
            this.Close();
        }

        // Gender Checkpoint Handlers
        private void HandleCategorySelection(string newCategory, string lastForm)
        {
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
        private void SHSMenTopImage_Click(object sender, EventArgs e) => HandleItemSelection(SHSMenTopLbl.Text, 250);
        private void SHSMenTopLbl_Click(object sender, EventArgs e) => HandleItemSelection(SHSMenTopLbl.Text, 250);
        private void SHSMentopCard_Click(object sender, EventArgs e) => HandleItemSelection(SHSMenTopLbl.Text, 250);

        // Pants Handlers
        private void SHSMenPantsImage_Click(object sender, EventArgs e) => HandleItemSelection(SHSMenPantsLabel.Text, 300);
        private void SHSMenPantsLabel_Click(object sender, EventArgs e) => HandleItemSelection(SHSMenPantsLabel.Text, 300);
        private void SHSMenPantsBackCard_Click(object sender, EventArgs e) => HandleItemSelection(SHSMenPantsLabel.Text, 300);

        // Neck Tie Handlers
        private void SHSMenNeckTieImage_Click(object sender, EventArgs e) => HandleItemSelection(SHSNeckTieLbl.Text, 85);
        private void SHSNeckTieLbl_Click(object sender, EventArgs e) => HandleItemSelection(SHSNeckTieLbl.Text, 85);
        private void SHSNeckTieBackCard_Click(object sender, EventArgs e) => HandleItemSelection(SHSNeckTieLbl.Text, 85);

        // Uniform Set Handlers
        private void SHSMenUniformSetImage_Click(object sender, EventArgs e) => HandleItemSelection(SHSMenUniformSetLbl.Text, 635);
        private void SHSMenUniformSetLbl_Click(object sender, EventArgs e) => HandleItemSelection(SHSMenUniformSetLbl.Text, 635);
        private void SHSMenUniformSetBackCard_Click(object sender, EventArgs e) => HandleItemSelection(SHSMenUniformSetLbl.Text, 635);

        // Proware Handlers
        private void HandleProwareNavigation()
        {
            var prowareForm = new ProwareForm(category, lastForm);
            prowareForm.Show();
            this.Close();
        }

        private void ProwareLabelCard_Click(object sender, EventArgs e) => HandleProwareNavigation();
        private void ProwareImageCard_Click(object sender, EventArgs e) => HandleProwareNavigation();

        // Cart Handler
        private void CartIcon_Click(object sender, EventArgs e)
        {
            var cart = new Cart("N/A", "N/A", "N/A", "N/A", "N/A");
            cart.Show();
            this.Close();
        }

        private void RoundedFooter_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
