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
        char gender;
        double price;
        string lastForm;
        Cart cart;

        public MaleHMForm(char gender, string lastForm)
        {

            this.gender = gender;
            InitializeComponent();
            this.lastForm = lastForm;
        }
        private void MaleHMForm_Load(object sender, EventArgs e)
        {

        }
        private void HandleItemSelection(string ItemName, double Itemprice)
        {
            price = Itemprice;
            var addOrder = new AddOrder(ItemName, gender, price, "MaleHM");
            addOrder.Show();
            this.Close();
        }

        //HM LongSleevePolo Handler
        private void HMMenLongSleevePoloImageCard_Click(object sender, EventArgs e) => HandleItemSelection(HMMenLongSleevePoloImageCard.Text, 250);
        private void HMLongSleevePoloLabelCard_Click(object sender, EventArgs e) => HandleItemSelection(HMLongSleevePoloLabelCard.Text, 250);
        private void HMLongSleevePoloBackCard_Click(object sender, EventArgs e) => HandleItemSelection(HMLongSleevePoloBackCard.Text, 250);

        //HM Blazer Handler
        private void HMmenBlazerImageCard_Click(object sender, EventArgs e) => HandleItemSelection(HMmenBlazerImageCard.Text, 250);
        private void HMMenBlazerLabelCard_Click(object sender, EventArgs e) => HandleItemSelection(HMMenBlazerLabelCard.Text, 250);
        private void HMMenBlazerBackCard_Click(object sender, EventArgs e) => HandleItemSelection(HMMenBlazerBackCard.Text, 250);

        //HM Pants Handler
        private void HMmenPantsImageCard_Click(object sender, EventArgs e) => HandleItemSelection(HMmenPantsImageCard.Text, 250);
        private void HMPantsLabelCard_Click(object sender, EventArgs e) => HandleItemSelection(HMPantsLabelCard.Text, 250);
        private void HMPantBackCard_Click(object sender, EventArgs e) => HandleItemSelection(HMPantBackCard.Text, 250);

        //HM UniformSet Handler
        private void HMmenUniformSetImageCard_Click(object sender, EventArgs e) => HandleItemSelection(HMmenUniformSetImageCard.Text, 250);
        private void HMMenUniformSetLabelCard_Click(object sender, EventArgs e) => HandleItemSelection(HMMenUniformSetLabelCard.Text, 250);
        private void HMMenUniformSetBackCard_Click(object sender, EventArgs e) => HandleItemSelection(HMMenUniformSetBackCard.Text, 250);

        //HM ChefsPolo
        private void HMmenChefsPoloImageCard_Click(object sender, EventArgs e) => HandleItemSelection(HMGraymenChefsPoloImageCard.Text, 250);
        private void HMGrayChefsPoloLabelCard_Click(object sender, EventArgs e) => HandleItemSelection(HMGrayChefsPoloLabelCard.Text, 250);
        private void HMGrayChefsPoloBackCard_Click(object sender, EventArgs e) => HandleItemSelection(HMGrayChefsPoloBackCard.Text, 250);

        //HM ChefsPants Handler
        private void HMmenChefsPantsImageCard_Click(object sender, EventArgs e) => HandleItemSelection(HMmenChefsPantsImageCard.Text, 250);
        private void HMChefsPantsLabelCard_Click(object sender, EventArgs e) => HandleItemSelection(HMChefsPantsLabelCard.Text, 250);
        private void HMChefsPantBackCard_Click(object sender, EventArgs e) => HandleItemSelection(HMChefsPantBackCard.Text, 250);

        //HM KitchenUniformSet Handler
        private void HMKitchenUniformSetImageCard_Click(object sender, EventArgs e) => HandleItemSelection(HMKitchenUniformSetImageCard.Text, 2500);
        private void HMKitchenUniformSetLabelCard_Click(object sender, EventArgs e) => HandleItemSelection(HMKitchenUniformSetLabelCard.Text, 250);
        private void HMKitchenUniformSetBackCard_Click(object sender, EventArgs e) => HandleItemSelection(HMKitchenUniformSetBackCard.Text, 250);

        //PROWARE Handler
        private void HandleProwareNavigation()
        {
            var Prowareform = new ProwareForm(category, lastForm);
            Prowareform.Show();
            this.Close();

        }

        private void ProwareLabelCard_Click(object sender, EventArgs e) => HandleProwareNavigation();

        private void ProwareImageCard_Click(object sender, EventArgs e) => HandleProwareNavigation();

        //Category Handler
        private void HandleCategorySelection(string newCategory)
        {
            category = newCategory;
            var genderCheckpoint = new GenderCheckpoint(newCategory, lastForm);
            genderCheckpoint.Show();
            this.Close();
        }

        private void ShsLabelCard_Click(object sender, EventArgs e) => HandleCategorySelection("SHS");
       

        private void ShsImageCard_Click(object sender, EventArgs e) => HandleCategorySelection("SHS");


        private void ITLabelCard_Click(object sender, EventArgs e) => HandleCategorySelection("IT");


        private void ITImageCard_Click(object sender, EventArgs e) => HandleCategorySelection("IT");


        private void TMlabelCard_Click(object sender, EventArgs e) => HandleCategorySelection("TM");

        private void TMImageCard_Click(object sender, EventArgs e) => HandleCategorySelection("TM");

    }
}
