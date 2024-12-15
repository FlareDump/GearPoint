using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace GearPoint
{
    public partial class FemaleITForm : Form
    {
        private string gender;
        private string category = "Proware";
        string lastForm;

        public FemaleITForm(string lastForm)
        {
            this.lastForm = lastForm;
            InitializeComponent();
        }

        public FemaleITForm(string gender, string lastForm)
        {
            this.gender = gender;
            this.lastForm = lastForm;
            InitializeComponent();
        }

        // Reusable method for adding orders
        private void AddOrderItem(string itemName, double price, Image ItemImage)
        {
            var addOrder = new AddOrder(itemName, gender, price, "FemaleIT", ItemImage);
            addOrder.Show();
            this.Close();
        }

        // Reusable method for navigation
        private void NavigateToForm(string selectedCategory, bool isProware = false)
        {
            if (isProware)
            {
                Console.WriteLine("User choosen Proware...");
                var prowareForm = new ProwareForm(category, "FemaleIT");
                prowareForm.Show();
            }
            else
            {
                Console.WriteLine("User choosen a Category and will proceed to Gender Checkpoint...");
                var genderCheckpoint = new GenderCheckpoint(selectedCategory, "FemaleIT");
                genderCheckpoint.Show();
            }
            this.Close();
        }

        // IT Blouse Handlers
        private void ITBlouseLabel_Click(object sender, EventArgs e) => AddOrderItem(ITBlouseLabel.Text, 350, ITBlouseImage.BackgroundImage);
        private void ITBlouseImage_Click(object sender, EventArgs e) => AddOrderItem(ITBlouseLabel.Text, 350, ITBlouseImage.BackgroundImage);
        private void ITBlouseBackCard_Click(object sender, EventArgs e) => AddOrderItem(ITBlouseLabel.Text, 350, ITBlouseImage.BackgroundImage);   

        // IT Skirt Handlers
        private void ITSkirtLabel_Click(object sender, EventArgs e) => AddOrderItem(ITSkirtLabel.Text, 350, ITSkirtImage.BackgroundImage);
        private void ITSkirtImage_Click(object sender, EventArgs e) => AddOrderItem(ITSkirtLabel.Text, 350, ITSkirtImage.BackgroundImage);
        private void ITSkirtBackCard_Click(object sender, EventArgs e) => AddOrderItem(ITSkirtLabel.Text, 350, ITSkirtImage.BackgroundImage);

        // IT Pants Handlers
        private void ITPantsLabel_Click(object sender, EventArgs e) => AddOrderItem(ITPantsLabel.Text, 450, ITPantsImage.BackgroundImage);
        private void ITPantsImage_Click(object sender, EventArgs e) => AddOrderItem(ITPantsLabel.Text, 450, ITPantsImage.BackgroundImage);
        private void ITPantsBackCard_Click(object sender, EventArgs e) => AddOrderItem(ITPantsLabel.Text, 450, ITPantsImage.BackgroundImage);

        // IT Set Handlers
        private void ITSetLabel_Click(object sender, EventArgs e) => AddOrderItem(ITSetLabel.Text, 800, ITSetImage.BackgroundImage);
        private void ITSetImage_Click(object sender, EventArgs e) => AddOrderItem(ITSetLabel.Text, 800, ITSetImage.BackgroundImage);
        private void ITSetBackCard_Click(object sender, EventArgs e) => AddOrderItem(ITSetLabel.Text, 800, ITSetImage.BackgroundImage);

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

        private void FemaleITForm_Load(object sender, EventArgs e)
        {
            DatabaseHandler dbHandler = new DatabaseHandler();
            DataTable cartData = dbHandler.GetCartData(); // This updates TotalPrice
            decimal TotalPrice = dbHandler.TotalPrice;

            TotalOutputLbl.Text = "₱" + TotalPrice.ToString("F2");
        }

        private void CartIcon_Click(object sender, EventArgs e)
        {
            var cart = new Cart("FemaleIT");
            cart.Show();
            this.Close();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment("FemaleIT");
            payment.Show();
            this.Close();
        }
    }
}
