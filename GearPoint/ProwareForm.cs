using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace GearPoint
{

    public partial class ProwareForm : Form
    {
        string lastForm, category = "Proware";

        Cart cart;
        AddOrder addOrder;
        GenderCheckpoint genderCheckpoint;

        public ProwareForm(string category, string lastForm)
        {
            this.category = category;
            this.lastForm = lastForm;
            InitializeComponent();
        }

        public ProwareForm()
        {
            InitializeComponent();
        }

        private void HandleItemSelection(string itemName, string category, double itemPrice, Image ItemImage)
        {
            var addOrder = new AddOrder(itemName, category, "Proware", itemPrice, ItemImage);
            addOrder.Show();
            this.Close();

        }
        private void ProwareForm_Load(object sender, EventArgs e)
        {
            DatabaseHandler dbHandler = new DatabaseHandler();
            DataTable cartData = dbHandler.GetCartData(); // This updates TotalPrice
            decimal TotalPrice = dbHandler.TotalPrice;

            TotalOutputLbl.Text = "₱" + TotalPrice.ToString("F2");
        }

        //39th Anniversary Shirt Handler
        private void ThirtyNineAnniversaryShirtImageCard_Click(object sender, EventArgs e) => HandleItemSelection(ThirtyNineAnniversaryShirtLabelCard.Text, category, 250, ThirtyNineAnniversaryShirtImageCard.BackgroundImage);
        private void ThirtyNineAnniversaryShirtPictureCard_Click(object sender, EventArgs e) => HandleItemSelection(ThirtyNineAnniversaryShirtLabelCard.Text, category, 250, ThirtyNineAnniversaryShirtImageCard.BackgroundImage);
        private void ThirtyNineAnniversaryShirtLabelCard_Click(object sender, EventArgs e) => HandleItemSelection(ThirtyNineAnniversaryShirtLabelCard.Text, category, 250, ThirtyNineAnniversaryShirtImageCard.BackgroundImage);

        //40th Anniversary Shirt Handler
        private void FourthyAnniversaryShirtImageCard_Click(object sender, EventArgs e) => HandleItemSelection(FourthyAnniversaryShirtLabelCard.Text, category, 250, FourthyAnniversaryShirtImageCard.BackgroundImage);
        private void FourthyAnniversaryShirtLabelCard_Click(object sender, EventArgs e) => HandleItemSelection(FourthyAnniversaryShirtLabelCard.Text, category, 250, FourthyAnniversaryShirtImageCard.BackgroundImage);
        private void FourthyAnniversaryShirtPictureCard_Click(object sender, EventArgs e) => HandleItemSelection(FourthyAnniversaryShirtLabelCard.Text, category, 250, FourthyAnniversaryShirtImageCard.BackgroundImage);

        //41th Anniversary Shirt Handler
        private void FourthyOneAnniversaryShirtImageCard_Click(object sender, EventArgs e) => HandleItemSelection(FourthyOneAnniversaryShirtLabelCard.Text, category, 250, FourthyOneAnniversaryShirtImageCard.BackgroundImage);
        private void FourthyOneAnniversaryShirtLabelCard_Click(object sender, EventArgs e) => HandleItemSelection(FourthyOneAnniversaryShirtLabelCard.Text, category, 250, FourthyOneAnniversaryShirtImageCard.BackgroundImage);
        private void FourthyOneAnniversaryShirtPictureCard_Click(object sender, EventArgs e) => HandleItemSelection(FourthyOneAnniversaryShirtLabelCard.Text, category, 250, FourthyOneAnniversaryShirtImageCard.BackgroundImage);

        //Shs PE Shirt Handler
        private void ShsPEShirtImageCard_Click(object sender, EventArgs e) => HandleItemSelection(ShsPEShirtLabelCard.Text, category, 250, ShsPEShirtImageCard.BackgroundImage);
        private void ShsPEShirtLabelCard_Click(object sender, EventArgs e) => HandleItemSelection(ShsPEShirtLabelCard.Text, category, 250, ShsPEShirtImageCard.BackgroundImage);
        private void ShsPEShirtPictureCard_Click(object sender, EventArgs e) => HandleItemSelection(ShsPEShirtLabelCard.Text, category, 250, ShsPEShirtImageCard.BackgroundImage);

        //Shs PE Pants Handler
        private void ShsPEPantsImageCard_Click(object sender, EventArgs e) => HandleItemSelection(ShsPEPantsLabelCard.Text, category, 250, ShsPEPantsImageCard.BackgroundImage);
        private void ShsPEPantsLabelCard_Click(object sender, EventArgs e) => HandleItemSelection(ShsPEPantsLabelCard.Text, category, 250, ShsPEPantsImageCard.BackgroundImage);
        private void ShsPEPantsPictureCard_Click(object sender, EventArgs e) => HandleItemSelection(ShsPEPantsLabelCard.Text, category, 250, ShsPEPantsImageCard.BackgroundImage);

        //Shs PE Set Handler
        private void ShsPESetImageCard_Click(object sender, EventArgs e) => HandleItemSelection(ShsPESetLabelCard.Text, category, 250, ShsPESetImageCard.BackgroundImage);
        private void ShsPESetLabelCard_Click(object sender, EventArgs e) => HandleItemSelection(ShsPESetLabelCard.Text, category, 250, ShsPESetImageCard.BackgroundImage);
        private void ShsPESetPictureCard_Click(object sender, EventArgs e) => HandleItemSelection(ShsPESetLabelCard.Text, category, 250, ShsPESetImageCard.BackgroundImage);

        //Tertiary PE Shirt Handler
        private void TertiaryPEShirtImageCard_Click(object sender, EventArgs e) => HandleItemSelection(TertiaryPEPantsLabelCard.Text, category, 250, TertiaryPEShirtImageCard.BackgroundImage);
        private void TertiaryPEShirtLabelCard_Click(object sender, EventArgs e) => HandleItemSelection(TertiaryPEPantsLabelCard.Text, category, 250, TertiaryPEShirtImageCard.BackgroundImage);
        private void TertiaryPEShirtPictureCard_Click(object sender, EventArgs e) => HandleItemSelection(TertiaryPEPantsLabelCard.Text, category, 250, TertiaryPEShirtImageCard.BackgroundImage);

        //Tertiary PE Pants Handler
        private void TertiaryPEPantsImageCard_Click(object sender, EventArgs e) => HandleItemSelection(TertiaryPEPantsLabelCard.Text, category, 250, TertiaryPEPantsImageCard.BackgroundImage);
        private void TertiaryPEPantsLabelCard_Click(object sender, EventArgs e) => HandleItemSelection(TertiaryPEPantsLabelCard.Text, category, 250, TertiaryPEPantsImageCard.BackgroundImage);
        private void TertiaryPEPantsPictureCard_Click(object sender, EventArgs e) => HandleItemSelection(TertiaryPEPantsLabelCard.Text, category, 250, TertiaryPEPantsImageCard.BackgroundImage);

        //Tertiary PE Set Handler
        private void TertiaryPESetImageCard_Click(object sender, EventArgs e) => HandleItemSelection(TertiaryPESetLabelCard.Text, category, 250, TertiaryPESetImageCard.BackgroundImage);
        private void TertiaryPESetLabelCard_Click(object sender, EventArgs e) => HandleItemSelection(TertiaryPESetLabelCard.Text, category, 250, TertiaryPESetImageCard.BackgroundImage);
        private void TertiaryPESetPictureCard_Click(object sender, EventArgs e) => HandleItemSelection(TertiaryPESetLabelCard.Text, category, 250, TertiaryPESetImageCard.BackgroundImage);

        //NSTP Shirt Handler
        private void NstpShirtImageCard_Click(object sender, EventArgs e) => HandleItemSelection(NstpShirtLabelCard.Text, category, 250, NstpShirtImageCard.BackgroundImage);
        private void NstpShirtLabelCard_Click(object sender, EventArgs e) => HandleItemSelection(NstpShirtLabelCard.Text, category, 250, NstpShirtImageCard.BackgroundImage);
        private void NstpShirtPictureCard_Click(object sender, EventArgs e) => HandleItemSelection(NstpShirtLabelCard.Text, category, 250, NstpShirtImageCard.BackgroundImage);

        private void HandleCategorySelection(string newCategory, string lastForm)
        {
            Console.WriteLine("User choosen a Category and will proceed to Gender Checkpoint...");
            genderCheckpoint = new GenderCheckpoint(newCategory, lastForm);
            genderCheckpoint.Show();
            this.Close();
        }
        //SHS
        private void SHSLabelCard_Click(object sender, EventArgs e) => HandleCategorySelection("SHS", "Proware");
        private void SHSimageCard_Click(object sender, EventArgs e) => HandleCategorySelection("SHS", "Proware");
        //TM
        private void TMLabelCard_Click(object sender, EventArgs e) => HandleCategorySelection("TM", "Proware");
        private void TMimageCard_Click(object sender, EventArgs e) => HandleCategorySelection("TM", "Proware");
        //IT
        private void ITLabelCard_Click(object sender, EventArgs e) => HandleCategorySelection("IT", "Proware");
        private void ITimageCard_Click(object sender, EventArgs e) => HandleCategorySelection("IT", "Proware");
        //HM
        private void HMLabelCard_Click(object sender, EventArgs e) => HandleCategorySelection("HM", "Proware");
        private void HMimageCard_Click(object sender, EventArgs e) => HandleCategorySelection("HM", "Proware");

        private void CartIcon_Click(object sender, EventArgs e)
        {
            var cart = new Cart("Proware");
            cart.Show();
            this.Close();
        }

        private void PaymentButton_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment("FemaleHM");
            payment.Show();
            this.Close();
        }
    }
}
