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
    public partial class AddOrder : Form
    {

        string item_name;
        char gender;
        string size;

        public AddOrder(string item_name, char gender)
        {
            this.item_name = item_name;
            this.gender = gender;
            InitializeComponent();
        }

        private void AddOrder_Load(object sender, EventArgs e)
        {
            string[] shirtSizes = { "XS", "S", "M", "L", "XL", "XXL", "XXXL" };

            for (int i = 0; i < shirtSizes.Length; i++)
            {
                SizesComboBox.Items.Add(shirtSizes[i]);
            }

            ItemNameLbl.Text = item_name.ToString();
            GenderLbl.Text = gender.ToString();;

        }

        private void OrderImageBox_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
