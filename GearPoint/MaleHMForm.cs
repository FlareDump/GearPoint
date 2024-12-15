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
    public partial class MaleHMForm : Form
    {
        string category;
        string gender;
        double price;
        string lastForm;
        Cart cart;

        public MaleHMForm(string gender, string lastForm)
        {
            this.gender = gender;
            this.lastForm = lastForm;
            InitializeComponent();
            
        }

        public MaleHMForm(string lastForm)
        {
            this.lastForm = lastForm;
            InitializeComponent();

        }

        private void MaleHMForm_Load(object sender, EventArgs e)
        {
            DatabaseHandler dbHandler = new DatabaseHandler();
            DataTable cartData = dbHandler.GetCartData(); // This updates TotalPrice
            decimal TotalPrice = dbHandler.TotalPrice;

            TotalOutputLbl.Text = "₱" + TotalPrice.ToString("F2");
        }
        private void HandleItemSelection(string ItemName, double Itemprice, Image ItemImage)
        {
            price = Itemprice;
            var addOrder = new AddOrder(ItemName, gender, price, "MaleHM", ItemImage);
            addOrder.Show();
            this.Close();
        }

        //HM LongSleevePolo Handler
        private void HMMenLongSleevePoloImageCard_Click(object sender, EventArgs e) => HandleItemSelection(HMLongSleevePoloLabelCard.Text, 700, HMMenLongSleevePoloImageCard.BackgroundImage);
        private void HMLongSleevePoloLabelCard_Click(object sender, EventArgs e) => HandleItemSelection(HMLongSleevePoloLabelCard.Text, 700, HMMenLongSleevePoloImageCard.BackgroundImage);
        private void HMLongSleevePoloBackCard_Click(object sender, EventArgs e) => HandleItemSelection(HMLongSleevePoloLabelCard.Text, 700, HMMenLongSleevePoloImageCard.BackgroundImage);

        //HM Blazer Handler
        private void HMmenBlazerImageCard_Click(object sender, EventArgs e) => HandleItemSelection(HMMenBlazerLabelCard.Text, 800, HMmenBlazerImageCard.BackgroundImage);
        private void HMMenBlazerLabelCard_Click(object sender, EventArgs e) => HandleItemSelection(HMMenBlazerLabelCard.Text, 800, HMmenBlazerImageCard.BackgroundImage);
        private void HMMenBlazerBackCard_Click(object sender, EventArgs e) => HandleItemSelection(HMMenBlazerLabelCard.Text, 800, HMmenBlazerImageCard.BackgroundImage);

        //HM Pants Handler
        private void HMmenPantsImageCard_Click(object sender, EventArgs e) => HandleItemSelection(HMPantsLabelCard.Text, 700, HMmenPantsImageCard.BackgroundImage);
        private void HMPantsLabelCard_Click(object sender, EventArgs e) => HandleItemSelection(HMPantsLabelCard.Text, 700, HMmenPantsImageCard.BackgroundImage);
        private void HMPantBackCard_Click(object sender, EventArgs e) => HandleItemSelection(HMPantsLabelCard.Text, 700, HMmenPantsImageCard.BackgroundImage);

        //HM UniformSet Handler
        private void HMmenUniformSetImageCard_Click(object sender, EventArgs e) => HandleItemSelection(HMMenUniformSetLabelCard.Text, 2200, HMmenUniformSetImageCard.BackgroundImage);
        private void HMMenUniformSetLabelCard_Click(object sender, EventArgs e) => HandleItemSelection(HMMenUniformSetLabelCard.Text, 2200, HMmenUniformSetImageCard.BackgroundImage);
        private void HMMenUniformSetBackCard_Click(object sender, EventArgs e) => HandleItemSelection(HMMenUniformSetLabelCard.Text, 2200, HMmenUniformSetImageCard.BackgroundImage);

        private void HMGraySkullCapLabel_Click(object sender, EventArgs e) => HandleItemSelection(HMGraySkullCapLabel.Text, 120, HMGraySkullCapImage.BackgroundImage);
        private void HMGraySkullCapImage_Click(object sender, EventArgs e) => HandleItemSelection(HMGraySkullCapLabel.Text, 120, HMGraySkullCapImage.BackgroundImage);
        private void HMGraySkullCapBackCard_Click(object sender, EventArgs e) => HandleItemSelection(HMGraySkullCapLabel.Text, 120, HMGraySkullCapImage.BackgroundImage);


        //HM ChefsPolo
        private void HMmenChefsPoloImageCard_Click(object sender, EventArgs e) => HandleItemSelection(HMGrayChefsPoloLabelCard.Text, 650, HMGraymenChefsPoloImageCard.BackgroundImage);
        private void HMGrayChefsPoloLabelCard_Click(object sender, EventArgs e) => HandleItemSelection(HMGrayChefsPoloLabelCard.Text, 650, HMGraymenChefsPoloImageCard.BackgroundImage);
        private void HMGrayChefsPoloBackCard_Click(object sender, EventArgs e) => HandleItemSelection(HMGrayChefsPoloLabelCard.Text, 650, HMGraymenChefsPoloImageCard.BackgroundImage);

        //HM ChefsPants Handler
        private void HMmenChefsPantsImageCard_Click(object sender, EventArgs e) => HandleItemSelection(HMChefsPantsLabelCard.Text, 700, HMmenChefsPantsImageCard.BackgroundImage);
        private void HMChefsPantsLabelCard_Click(object sender, EventArgs e) => HandleItemSelection(HMChefsPantsLabelCard.Text, 700, HMmenChefsPantsImageCard.BackgroundImage);
        private void HMChefsPantBackCard_Click(object sender, EventArgs e) => HandleItemSelection(HMChefsPantsLabelCard.Text, 700, HMmenChefsPantsImageCard.BackgroundImage);

        //HM KitchenUniformSet Handler
        private void HMKitchenUniformSetImageCard_Click(object sender, EventArgs e) => HandleItemSelection(HMKitchenUniformSetLabelCard.Text, 1470, HMKitchenUniformSetImageCard.BackgroundImage);
        private void HMKitchenUniformSetLabelCard_Click(object sender, EventArgs e) => HandleItemSelection(HMKitchenUniformSetLabelCard.Text, 1470, HMKitchenUniformSetImageCard.BackgroundImage);
        private void HMKitchenUniformSetBackCard_Click(object sender, EventArgs e) => HandleItemSelection(HMKitchenUniformSetLabelCard.Text, 1470, HMKitchenUniformSetImageCard.BackgroundImage);

        //PROWARE Handler
        private void HandleProwareNavigation()
        {
            Console.WriteLine("User choosen Proware...");
            var Prowareform = new ProwareForm(category, "MaleHM");
            Prowareform.Show();
            this.Close();

        }

        private void ProwareLabelCard_Click(object sender, EventArgs e) => HandleProwareNavigation();

        private void ProwareImageCard_Click(object sender, EventArgs e) => HandleProwareNavigation();

        //Category Handler
        private void HandleCategorySelection(string newCategory)
        {
            Console.WriteLine("User choosen a Category and will proceed to Gender Checkpoint...");
            category = newCategory;
            var genderCheckpoint = new GenderCheckpoint(newCategory, "MaleHM");
            genderCheckpoint.Show();
            this.Close();
        }

        private void ShsLabelCard_Click(object sender, EventArgs e) => HandleCategorySelection("SHS");
       

        private void ShsImageCard_Click(object sender, EventArgs e) => HandleCategorySelection("SHS");


        private void ITLabelCard_Click(object sender, EventArgs e) => HandleCategorySelection("IT");


        private void ITImageCard_Click(object sender, EventArgs e) => HandleCategorySelection("IT");


        private void TMlabelCard_Click(object sender, EventArgs e) => HandleCategorySelection("TM");

        private void TMImageCard_Click(object sender, EventArgs e) => HandleCategorySelection("TM");

        private void CartIcon_Click(object sender, EventArgs e)
        {
            var cart = new Cart("FemaleHM");
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
