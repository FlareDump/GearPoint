using System;
using System.Windows.Forms;

namespace GearPoint
{

    public partial class ProwareForm : Form
    {

        string category;
        double price;
        string lastForm;
        Cart cart;

        AddOrder addOrder;

        GenderCheckpoint genderCheckpoint;

        public ProwareForm(string category, string lastForm)
        {
            this.category = category;
            InitializeComponent();
            this.lastForm = lastForm;
        }

        public ProwareForm()
        {
            InitializeComponent();
        }

        private void HandleItemSelection(string itemName, double itemPrice)
        {
            price = itemPrice;
            var addOrder = new AddOrder(itemName, price, "Proware");
            addOrder.Show();
            this.Close();

        }
        private void ProwareForm_Load(object sender, EventArgs e)
        {
            
        }

        //39th Anniversary Shirt Handler
        private void ThirtyNineAnniversaryShirtImageCard_Click(object sender, EventArgs e) => HandleItemSelection(ThirtyNineAnniversaryShirtImageCard.Text, 250);
        private void ThirtyNineAnniversaryShirtPictureCard_Click(object sender, EventArgs e) => HandleItemSelection(ThirtyNineAnniversaryShirtPictureCard.Text, 250);
        private void ThirtyNineAnniversaryShirtLabelCard_Click(object sender, EventArgs e) => HandleItemSelection(ThirtyNineAnniversaryShirtLabelCard.Text, 250);

        //40th Anniversary Shirt Handler
        private void FourthyAnniversaryShirtImageCard_Click(object sender, EventArgs e) => HandleItemSelection(FourthyAnniversaryShirtImageCard.Text, 250);
        private void FourthyAnniversaryShirtLabelCard_Click(object sender, EventArgs e) => HandleItemSelection(FourthyAnniversaryShirtLabelCard.Text, 250);
        private void FourthyAnniversaryShirtPictureCard_Click(object sender, EventArgs e) => HandleItemSelection(FourthyAnniversaryShirtPictureCard.Text, 250);

        //41th Anniversary Shirt Handler
        private void FourthyOneAnniversaryShirtImageCard_Click(object sender, EventArgs e) => HandleItemSelection(FourthyOneAnniversaryShirtImageCard.Text, 250);
        private void FourthyOneAnniversaryShirtLabelCard_Click(object sender, EventArgs e) => HandleItemSelection(FourthyOneAnniversaryShirtLabelCard.Text, 250);
        private void FourthyOneAnniversaryShirtPictureCard_Click(object sender, EventArgs e) => HandleItemSelection(FourthyOneAnniversaryShirtPictureCard.Text, 250);

        //Shs PE Shirt Handler
        private void ShsPEShirtImageCard_Click(object sender, EventArgs e) => HandleItemSelection(ShsPEShirtImageCard.Text, 250);
        private void ShsPEShirtLabelCard_Click(object sender, EventArgs e) => HandleItemSelection(ShsPEShirtLabelCard.Text, 250);
        private void ShsPEShirtPictureCard_Click(object sender, EventArgs e) => HandleItemSelection(ShsPEShirtPictureCard.Text, 250);

        //Shs PE Pants Handler
        private void ShsPEPantsImageCard_Click(object sender, EventArgs e) => HandleItemSelection(ShsPEPantsImageCard.Text, 250);
        private void ShsPEPantsLabelCard_Click(object sender, EventArgs e) => HandleItemSelection(ShsPEPantsLabelCard.Text, 250);
        private void ShsPEPantsPictureCard_Click(object sender, EventArgs e) => HandleItemSelection(ShsPEPantsPictureCard.Text, 250);

        //Shs PE Set Handler
        private void ShsPESetImageCard_Click(object sender, EventArgs e) => HandleItemSelection(ShsPESetImageCard.Text, 250);
        private void ShsPESetLabelCard_Click(object sender, EventArgs e) => HandleItemSelection(ShsPESetLabelCard.Text, 250);
        private void ShsPESetPictureCard_Click(object sender, EventArgs e) => HandleItemSelection(ShsPESetPictureCard.Text, 250);

        //Tertiary PE Shirt Handler
        private void TertiaryPEShirtImageCard_Click(object sender, EventArgs e) => HandleItemSelection(TertiaryPEPantsImageCard.Text, 250);
        private void TertiaryPEShirtLabelCard_Click(object sender, EventArgs e) => HandleItemSelection(TertiaryPEPantsLabelCard.Text, 250);
        private void TertiaryPEShirtPictureCard_Click(object sender, EventArgs e) => HandleItemSelection(TertiaryPEPantsPictureCard.Text, 250);

        //Tertiary PE Pants Handler
        private void TertiaryPEPantsImageCard_Click(object sender, EventArgs e) => HandleItemSelection(TertiaryPEPantsImageCard.Text, 250);
        private void TertiaryPEPantsLabelCard_Click(object sender, EventArgs e) => HandleItemSelection(TertiaryPEPantsLabelCard.Text, 250);
        private void TertiaryPEPantsPictureCard_Click(object sender, EventArgs e) => HandleItemSelection(TertiaryPEPantsPictureCard.Text, 250);

        //Tertiary PE Set Handler
        private void TertiaryPESetImageCard_Click(object sender, EventArgs e) => HandleItemSelection(TertiaryPESetImageCard.Text, 250);
        private void TertiaryPESetLabelCard_Click(object sender, EventArgs e) => HandleItemSelection(TertiaryPESetLabelCard.Text, 250);
        private void TertiaryPESetPictureCard_Click(object sender, EventArgs e) => HandleItemSelection(TertiaryPESetPictureCard.Text, 250);

        //NSTP Shirt Handler
        private void NstpShirtImageCard_Click(object sender, EventArgs e) => HandleItemSelection(NstpShirtImageCard.Text, 250);
        private void NstpShirtLabelCard_Click(object sender, EventArgs e) => HandleItemSelection(NstpShirtLabelCard.Text, 250);
        private void NstpShirtPictureCard_Click(object sender, EventArgs e) => HandleItemSelection(NstpShirtPictureCard.Text, 250);

        private void HandleCategorySelection(string newCategory, string lastForm)
        {
            category = newCategory;
            genderCheckpoint = new GenderCheckpoint(category, lastForm);
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



    }
}
