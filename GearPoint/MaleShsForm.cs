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
    public partial class MaleShsForm : Form
    {
        char gender;

        public MaleShsForm(string category, char gender)
        {
            this.gender = gender;
            InitializeComponent();
        }

        AddOrder addOrder;

        private void MaleShsForm_Load(object sender, EventArgs e)
        { 

        }

        private void SHSMenTopImage_Click(object sender, EventArgs e)
        {
            addOrder = new AddOrder(SHSMenTopLbl.Text, gender);
            addOrder.Show();
            this.Close();
        }

        private void SHSMenTopLbl_Click(object sender, EventArgs e)
        {
            addOrder = new AddOrder(SHSMenTopLbl.Text, gender);
            addOrder.Show();
            this.Close();
        }

        private void SHSMentopCard_Click(object sender, EventArgs e)
        {
            addOrder = new AddOrder(SHSMenTopLbl.Text, gender);
            addOrder.Show();
            this.Close();
        }
    }
}
