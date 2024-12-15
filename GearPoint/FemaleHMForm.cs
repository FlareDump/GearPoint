using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace GearPoint
{
    public partial class FemaleHMForm : Form
    {
        private string gender;
        private string lastForm;
        string category = "Proware";

        private Cart cart;
        private AddOrder addOrder;
        private ProwareForm prowareForm;
        private GenderCheckpoint genderCheckpoint;

        public FemaleHMForm(string lastForm)
        {
            this.lastForm = lastForm;
            InitializeComponent();
        }

        public FemaleHMForm(string gender, string lastForm)
        {
            this.gender = gender;
            this.lastForm = lastForm;
            InitializeComponent();
        }

        private void OpenAddOrder(String label, double price, Image ItemImage)
        {
            addOrder = new AddOrder(label, gender, price, "FemaleHM", ItemImage);
            addOrder.Show();
            this.Close();
        }

        private void FemaleHMForm_Load(object sender, EventArgs e)
        {
            DatabaseHandler dbHandler = new DatabaseHandler();
            DataTable cartData = dbHandler.GetCartData(); // This updates TotalPrice
            decimal TotalPrice = dbHandler.TotalPrice;

            TotalOutputLbl.Text = "₱" + TotalPrice.ToString("F2");
        }

        private void OpenGenderCheckpoint(string category)
        {
            Console.WriteLine("User choosen a Category and will proceed to Gender Checkpoint...");
            genderCheckpoint = new GenderCheckpoint(category, "FemaleHM");
            genderCheckpoint.Show();
            this.Close();
        }

        private void OpenProwareForm()
        {
            prowareForm = new ProwareForm(category, "FemaleHM");
            prowareForm.Show();
            this.Close();
        }

        // HM Blouse
        private void HMBlouseLabel_Click(object sender, EventArgs e) => OpenAddOrder(HMBlouseLabel.Text, 500, HMBlouseImage.BackgroundImage);
        private void HMBlouseImage_Click(object sender, EventArgs e) => OpenAddOrder(HMBlouseLabel.Text, 500, HMBlouseImage.BackgroundImage);
        private void HMBlouseBackCard_Click(object sender, EventArgs e) => OpenAddOrder(HMBlouseLabel.Text, 500, HMBlouseImage.BackgroundImage);

        // HM Blazer
        private void HMBlazerLabelCard_Click(object sender, EventArgs e) => OpenAddOrder(HMBlazerLabelCard.Text, 750, HMBlazerImageCard.BackgroundImage);
        private void HMBlazerImageCard_Click(object sender, EventArgs e) => OpenAddOrder(HMBlazerLabelCard.Text, 750, HMBlazerImageCard.BackgroundImage);
        private void HMBlazerBackCard_Click(object sender, EventArgs e) => OpenAddOrder(HMBlazerLabelCard.Text, 750, HMBlazerImageCard.BackgroundImage);

        // HM Pants
        private void HMPantsLabel_Click(object sender, EventArgs e) => OpenAddOrder(HMPantsLabel.Text, 550, HMPantsImage.BackgroundImage);
        private void HMPantsImage_Click(object sender, EventArgs e) => OpenAddOrder(HMPantsLabel.Text, 550, HMPantsImage.BackgroundImage);
        private void HMPantsBackCard_Click(object sender, EventArgs e) => OpenAddOrder(HMPantsLabel.Text, 550, HMPantsImage.BackgroundImage);

        // HM Skirt
        private void HMSkirtLabel_Click(object sender, EventArgs e) => OpenAddOrder(HMSkirtLabel.Text, 450, HMSkirtImage.BackgroundImage);
        private void HMSkirtImage_Click(object sender, EventArgs e) => OpenAddOrder(HMSkirtLabel.Text, 450, HMSkirtImage.BackgroundImage);
        private void HMSkirtBackCard_Click(object sender, EventArgs e) => OpenAddOrder(HMSkirtLabel.Text, 450, HMSkirtImage.BackgroundImage);

        // HM Uniform Set
        private void HMFemaleUniformSetLabel_Click(object sender, EventArgs e) => OpenAddOrder(HMFemaleUniformSetLabel.Text, 2250, HMFemaleUniformSetImage.BackgroundImage);
        private void HMFemaleUniformSetImage_Click(object sender, EventArgs e) => OpenAddOrder(HMFemaleUniformSetLabel.Text, 2250, HMFemaleUniformSetImage.BackgroundImage);
        private void HMFemaleUniformSetBackCard_Click(object sender, EventArgs e) => OpenAddOrder(HMFemaleUniformSetLabel.Text, 2250, HMFemaleUniformSetImage.BackgroundImage);

        // HM Skull Cap
        private void HMGraySkullCapLabel_Click(object sender, EventArgs e) => OpenAddOrder(HMGraySkullCapLabel.Text, 120, HMGraySkullCapImage.BackgroundImage);
        private void HMGraySkullCapImage_Click(object sender, EventArgs e) => OpenAddOrder(HMGraySkullCapLabel.Text, 120, HMGraySkullCapImage.BackgroundImage);
        private void HMGraySkullCapBackCard_Click(object sender, EventArgs e) => OpenAddOrder(HMGraySkullCapLabel.Text, 120, HMGraySkullCapImage.BackgroundImage);

        // HM Chef Polo
        private void HMGrayChefPoloLabel_Click(object sender, EventArgs e) => OpenAddOrder(HMGrayChefPoloLabel.Text, 750, HMGrayChefPoloImage.BackgroundImage);
        private void HMGrayChefPoloImage_Click(object sender, EventArgs e) => OpenAddOrder(HMGrayChefPoloLabel.Text, 750, HMGrayChefPoloImage.BackgroundImage);
        private void HMGrayChefPoloBackCard_Click(object sender, EventArgs e) => OpenAddOrder(HMGrayChefPoloLabel.Text, 750, HMGrayChefPoloImage.BackgroundImage);

        // HM Chef Pants
        private void HMChefPantsLabel_Click(object sender, EventArgs e) => OpenAddOrder(HMChefPantsLabel.Text, 600, HMChefPantsImage.BackgroundImage);
        private void HMChefPantsImage_Click(object sender, EventArgs e) => OpenAddOrder(HMChefPantsLabel.Text, 600, HMChefPantsImage.BackgroundImage);
        private void HMChefPantsBackCard_Click(object sender, EventArgs e) => OpenAddOrder(HMChefPantsLabel.Text, 600, HMChefPantsImage.BackgroundImage);

        // HM Kitchen Set
        private void KitchenSetLabel_Click(object sender, EventArgs e) => OpenAddOrder(KitchenSetLabel.Text, 1470, KitchenSetImage.BackgroundImage);
        private void KitchenSetImage_Click(object sender, EventArgs e) => OpenAddOrder(KitchenSetLabel.Text, 1470, KitchenSetImage.BackgroundImage);
        private void KitchenSetBackCard_Click(object sender, EventArgs e) => OpenAddOrder(KitchenSetLabel.Text, 1470, KitchenSetImage.BackgroundImage);

        // Cart
        private void CartIcon_Click(object sender, EventArgs e)
        {
            var cart = new Cart("FemaleHM");
            cart.Show();
            this.Close();
        }

        // Category Navigation
        private void ShsLabelCard_Click(object sender, EventArgs e) => OpenGenderCheckpoint("SHS");
        private void ShsImageCard_Click(object sender, EventArgs e) => OpenGenderCheckpoint("SHS");
        private void ITLabelCard_Click(object sender, EventArgs e) => OpenGenderCheckpoint("IT");
        private void ITImageCard_Click(object sender, EventArgs e) => OpenGenderCheckpoint("IT");
        private void TMlabelCard_Click(object sender, EventArgs e) => OpenGenderCheckpoint("TM");
        private void TMImageCard_Click(object sender, EventArgs e) => OpenGenderCheckpoint("TM");
        private void ProwareLabelCard_Click(object sender, EventArgs e) => OpenProwareForm();
        private void ProwareImageCard_Click(object sender, EventArgs e) => OpenProwareForm();

        private void PaymentButton_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment("FemaleHM");
            payment.Show();
            this.Close();
        }
    }
}
