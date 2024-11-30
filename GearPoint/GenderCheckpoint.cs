using System;
using System.Windows.Forms;

namespace GearPoint
{
    public partial class GenderCheckpoint : Form
    {
        private Main_Menu mainMenu = new Main_Menu();

        public string Category { get; }
        public char Gender { get; private set; }

        public GenderCheckpoint(string category)
        {
            Category = category;
            InitializeComponent();
        }

        private void BACKButton4_Click(object sender, EventArgs e)
        {
            mainMenu.Show();
            this.Close();
        }

        private void FEMALEButton2_Click(object sender, EventArgs e)
        {
            Gender = 'F';
            NavigateToForm();
        }

        private void MALEButton1_Click(object sender, EventArgs e)
        {
            Gender = 'M';
            NavigateToForm();
        }

        private void NavigateToForm()
        {
            Form targetForm = GetTargetForm(Category, Gender);

            if (targetForm != null)
            {
                targetForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Choices");
            }
        }

        private Form GetTargetForm(string category, char gender)
        {
            switch (gender)
            {
                case 'F':
                    switch (category)
                    {
                        case "SHS":
                            return new FemaleShsForm(gender);
                        case "IT":
                            return new FemaleITForm(gender);
                        case "TM":
                            return new FemaleTMForm(gender);
                        case "HM":
                            return new FemaleHMForm(gender);
                        default:
                            return null;
                    }

                case 'M':
                    switch (category)
                    {
                        case "SHS":
                            return new MaleShsForm(gender);
                        case "IT":
                            return new MaleITForm(gender);
                        case "TM":
                            return new MaleTMForm(gender);
                        case "HM":
                            return new MaleHMForm(gender);
                        default:
                            return null;
                    }

                default:
                    return null;
            }
        }
    }
}
