using System;
using System.Windows.Forms;

namespace GearPoint
{
    public partial class FemaleHMForm : Form
    {
        private string category;
        private char gender;
        private string lastForm;

        private Cart cart;
        private AddOrder addOrder;
        private ProwareForm prowareForm;
        private GenderCheckpoint genderCheckpoint;

        public FemaleHMForm(char gender, string lastForm)
        {
            this.gender = gender;
            InitializeComponent();
            this.lastForm = lastForm;
        }

        private void OpenAddOrder(Label label, double price)
        {
            addOrder = new AddOrder(label.Text, gender, price, "FemaleHM");
            addOrder.Show();
            this.Close();
        }

        private void OpenGenderCheckpoint(string category)
        {
            genderCheckpoint = new GenderCheckpoint(category, lastForm);
            genderCheckpoint.Show();
            this.Close();
        }

        private void OpenProwareForm()
        {
            prowareForm = new ProwareForm(category, lastForm);
            prowareForm.Show();
            this.Close();
        }

        // HM Blouse
        private void HMBlouseLabel_Click(object sender, EventArgs e) => OpenAddOrder(HMBlouseLabel, 450);
        private void HMBlouseImage_Click(object sender, EventArgs e) => OpenAddOrder(HMBlouseLabel, 450);
        private void HMBlouseBackCard_Click(object sender, EventArgs e) => OpenAddOrder(HMBlouseLabel, 450);

        // HM Blazer
        private void HMBlazerLabelCard_Click(object sender, EventArgs e) => OpenAddOrder(HMBlazerLabelCard, 75);
        private void HMBlazerImageCard_Click(object sender, EventArgs e) => OpenAddOrder(HMBlazerLabelCard, 750);
        private void HMBlazerBackCard_Click(object sender, EventArgs e) => OpenAddOrder(HMBlazerLabelCard, 750);

        // HM Pants
        private void HMPantsLabel_Click(object sender, EventArgs e) => OpenAddOrder(HMPantsLabel, 450);
        private void HMPantsImage_Click(object sender, EventArgs e) => OpenAddOrder(HMPantsLabel, 450);
        private void HMPantsBackCard_Click(object sender, EventArgs e) => OpenAddOrder(HMPantsLabel, 450);

        // HM Skirt
        private void HMSkirtLabel_Click(object sender, EventArgs e) => OpenAddOrder(HMSkirtLabel, 450);
        private void HMSkirtImage_Click(object sender, EventArgs e) => OpenAddOrder(HMSkirtLabel, 450);
        private void HMSkirtBackCard_Click(object sender, EventArgs e) => OpenAddOrder(HMSkirtLabel, 450);

        // HM Uniform Set
        private void HMFemaleUniformSetLabel_Click(object sender, EventArgs e) => OpenAddOrder(HMFemaleUniformSetLabel, 2100);
        private void HMFemaleUniformSetImage_Click(object sender, EventArgs e) => OpenAddOrder(HMFemaleUniformSetLabel, 2100);
        private void HMFemaleUniformSetBackCard_Click(object sender, EventArgs e) => OpenAddOrder(HMFemaleUniformSetLabel, 2100);

        // HM Skull Cap
        private void HMGraySkullCapLabel_Click(object sender, EventArgs e) => OpenAddOrder(HMGraySkullCapLabel, 120);
        private void HMGraySkullCapImage_Click(object sender, EventArgs e) => OpenAddOrder(HMGraySkullCapLabel, 120);
        private void HMGraySkullCapBackCard_Click(object sender, EventArgs e) => OpenAddOrder(HMGraySkullCapLabel, 120);

        // HM Chef Polo
        private void HMGrayChefPoloLabel_Click(object sender, EventArgs e) => OpenAddOrder(HMGrayChefPoloLabel, 500);
        private void HMGrayChefPoloImage_Click(object sender, EventArgs e) => OpenAddOrder(HMGrayChefPoloLabel, 500);
        private void HMGrayChefPoloBackCard_Click(object sender, EventArgs e) => OpenAddOrder(HMGrayChefPoloLabel, 500);

        // HM Chef Pants
        private void HMChefPantsLabel_Click(object sender, EventArgs e) => OpenAddOrder(HMChefPantsLabel, 600);
        private void HMChefPantsImage_Click(object sender, EventArgs e) => OpenAddOrder(HMChefPantsLabel, 600);
        private void HMChefPantsBackCard_Click(object sender, EventArgs e) => OpenAddOrder(HMChefPantsLabel, 600);

        // HM Kitchen Set
        private void KitchenSetLabel_Click(object sender, EventArgs e) => OpenAddOrder(KitchenSetLabel, 1220);
        private void KitchenSetImage_Click(object sender, EventArgs e) => OpenAddOrder(KitchenSetLabel, 1220);
        private void KitchenSetBackCard_Click(object sender, EventArgs e) => OpenAddOrder(KitchenSetLabel, 1220);

        // Cart
        private void CartIcon_Click(object sender, EventArgs e)
        {
            cart = new Cart("N/A", "N/A", "N/A", "N/A", "N/A");
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
    }
}
