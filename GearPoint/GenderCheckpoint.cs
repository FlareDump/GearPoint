using System;
using System.Windows.Forms;

namespace GearPoint
{
    public partial class GenderCheckpoint : Form
    {
        private Main_Menu mainMenu = new Main_Menu();

        MaleShsForm maleShsForm;
        FemaleShsForm femaleShsForm;
        MaleITForm maleITForm;
        FemaleITForm femaleITForm;
        MaleTMForm maleTMForm;
        FemaleTMForm femaleTMForm;
        MaleHMForm maleHMForm;
        FemaleHMForm femaleHMForm;
        ProwareForm prowareForm;

        public string lastForm;

        public string Category { get; }
        public char Gender { get; private set; }

        public GenderCheckpoint(string category, string lastForm)
        {
            this.lastForm = lastForm;
            Category = category;
            InitializeComponent();
        }

        private void BACKButton4_Click(object sender, EventArgs e)
        {
            switch (lastForm)
            {
                case "MaleSHS":
                    maleShsForm = new MaleShsForm(Gender, lastForm);
                    maleShsForm.Show();
                    break;
                case "FemaleSHS":
                    femaleShsForm = new FemaleShsForm(Gender, lastForm);
                    femaleShsForm.Show();
                    break;
                case "MaleIT":
                    maleITForm = new MaleITForm(Gender, lastForm);
                    maleITForm.Show();
                    break;
                case "FemaleIT":
                    femaleITForm = new FemaleITForm(Gender, lastForm);
                    femaleITForm.Show();
                    break;
                case "MaleTM":
                    maleTMForm = new MaleTMForm(Gender, lastForm);
                    maleTMForm.Show();
                    break;
                case "FemaleTM":
                    femaleTMForm = new FemaleTMForm(Gender, lastForm);
                    femaleTMForm.Show();
                    break;
                case "MaleHM":
                    maleHMForm = new MaleHMForm(Gender, lastForm);
                    maleHMForm.Show();
                    break;
                case "FemaleHM":
                    femaleHMForm = new FemaleHMForm(Gender, lastForm);
                    femaleHMForm.Show();
                    break;
                case "Proware":
                    prowareForm = new ProwareForm(Category, lastForm);
                    prowareForm.Show();
                    break;
                case "MainMenu":
                    mainMenu.Show();
                    break;
            }
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
                            return new FemaleShsForm(gender, lastForm);
                        case "IT":
                            return new FemaleITForm(gender, lastForm);
                        case "TM":
                            return new FemaleTMForm(gender, lastForm);
                        case "HM":
                            return new FemaleHMForm(gender, lastForm);
                        default:
                            return null;
                    }

                case 'M':
                    switch (category)
                    {
                        case "SHS":
                            return new MaleShsForm(gender, lastForm);
                        case "IT":
                            return new MaleITForm(gender, lastForm);
                        case "TM":
                            return new MaleTMForm(gender, lastForm);
                        case "HM":
                            return new MaleHMForm(gender, lastForm);
                        default:
                            return null;
                    }

                default:
                    return null;
            }
        }

        private void GenderCheckpoint_Load(object sender, EventArgs e)
        {

        }
    }
}
