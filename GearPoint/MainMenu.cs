using System;
using System.Windows.Forms;

namespace GearPoint
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void Main_Menu_Load(object sender, EventArgs e) { }

        // Reusable method for category navigation
        private void NavigateToCategory(string selectedCategory, bool isProware = false)
        {
            if (isProware)
            {
                var prowareForm = new ProwareForm(selectedCategory);
                prowareForm.Show();
            }
            else
            {
                var genderCheckpoint = new GenderCheckpoint(selectedCategory);
                genderCheckpoint.Show();
            }
            this.Close();
        }

        // SHS Card Handlers
        private void ShsImageCard_Click(object sender, EventArgs e) => NavigateToCategory("SHS");
        private void ShsLabelCard_Click(object sender, EventArgs e) => NavigateToCategory("SHS");
        private void ShsBackCard_Click(object sender, EventArgs e) => NavigateToCategory("SHS");

        // ICT Card Handlers
        private void ICTImageCard_Click(object sender, EventArgs e) => NavigateToCategory("IT");
        private void ICTLabelCard_Click(object sender, EventArgs e) => NavigateToCategory("IT");
        private void ICTBackCard_Click(object sender, EventArgs e) => NavigateToCategory("IT");

        // TM Card Handlers
        private void TMImageCard_Click(object sender, EventArgs e) => NavigateToCategory("TM");
        private void TMLabelCard_Click(object sender, EventArgs e) => NavigateToCategory("TM");
        private void TMBackCard_Click(object sender, EventArgs e) => NavigateToCategory("TM");

        // HM Card Handlers
        private void HMImageCard_Click(object sender, EventArgs e) => NavigateToCategory("HM");
        private void HMLabelCard_Click(object sender, EventArgs e) => NavigateToCategory("HM");
        private void HMBackCard_Click(object sender, EventArgs e) => NavigateToCategory("HM");

        // Proware Card Handlers
        private void ProwareImageCard_Click(object sender, EventArgs e) => NavigateToCategory("Proware", true);
        private void ProwareLabelCard_Click(object sender, EventArgs e) => NavigateToCategory("Proware", true);
        private void ProwareBackCard_Click(object sender, EventArgs e) => NavigateToCategory("Proware", true);
    }
}
