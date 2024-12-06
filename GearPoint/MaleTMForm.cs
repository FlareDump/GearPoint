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
    public partial class MaleTMForm : Form
    {
        char gender;
        string category;
        double price;
        string lastForm;

        Cart cart;
        AddOrder addOrder;
        GenderCheckpoint genderCheckpoint;
        ProwareForm prowareForm;

        public MaleTMForm(char gender, string lastForm)
        {
            this.lastForm = lastForm;
            this.gender = gender;
            InitializeComponent();
        }

        private void HandleItemSelection(string ItemName, double Itemprice)
        {
            price = Itemprice;
            var addOrder = new AddOrder(ItemName, gender, price, "MaleTM");
            addOrder.Show();
            this.Close();
        }

        //TM Polo Handler
        private void TMPoloLabel_Click(object sender, EventArgs e) => HandleItemSelection(TMPoloLabelCard.Text, 250);
        private void TMPoloImage_Click(object sender, EventArgs e) => HandleItemSelection(TMPoloImageCard.Text, 250);
        private void TMPoloBackCard_Click(object sender, EventArgs e) => HandleItemSelection(TMPoloBackCard.Text, 250);

        //TM Blazer
        private void TMBlazerLabel_Click(object sender, EventArgs e) => HandleItemSelection(TMBlazerLabelCard.Text, 250);
        private void TMBlazerImage_Click(object sender, EventArgs e) => HandleItemSelection(TMBlazerImageCard.Text, 250);
        private void TMBlazerBackCard_Click(object sender, EventArgs e) => HandleItemSelection(TMBlazerBackCard.Text, 250);

        //TM Pants
        private void TMPantsLabel_Click(object sender, EventArgs e) => HandleItemSelection(TMPantsLabelCard.Text, 250);
        private void TMPantsIamge_Click(object sender, EventArgs e) => HandleItemSelection(TMPantsImageCard.Text, 250);
        private void TMPantsBackCard_Click(object sender, EventArgs e) => HandleItemSelection(TMPantsBackCard.Text, 250);

        //PROWARE Handler
        private void HandleProwareNavigation()
        {
            var ProwareForm = new ProwareForm(category, lastForm);
            prowareForm.Show();
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

        //SHS Handler
        private void ShsLabelCard_Click(object sender, EventArgs e) => HandleCategorySelection("SHS");
        private void ShsPictureCard_Click(object sender, EventArgs e) => HandleCategorySelection("SHS");

        //IT Handler
        private void ITLabelCard_Click(object sender, EventArgs e) => HandleCategorySelection("IT");
        private void ITPictureCard_Click(object sender, EventArgs e) => HandleCategorySelection("IT");

        //HM Handler
        private void HMPictureCard_Click(object sender, EventArgs e) => HandleCategorySelection("HM");
        private void HMLabelCard_Click(object sender, EventArgs e) => HandleCategorySelection("HM");

        private void MaleTMForm_Load(object sender, EventArgs e)
        {

        }
    }
}
