using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GearPoint
{
    public partial class Payment : Form
    {

        string lastForm, gender, category = "Proware";

        MaleShsForm maleShsForm;
        FemaleShsForm femaleShsForm;
        MaleITForm maleITForm;
        FemaleITForm femaleITForm;
        MaleTMForm maleTMForm;
        FemaleTMForm femaleTMForm;
        MaleHMForm maleHMForm;
        FemaleHMForm femaleHMForm;
        ProwareForm prowareForm;
        Main_Menu mainMenu;

        public Payment(string lastForm)
        {
            this.lastForm = lastForm;
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {

            DatabaseHandler dbHandler = new DatabaseHandler();
            DataTable cartData = dbHandler.GetCartData(); // This updates TotalPrice
            decimal updatedTotal = dbHandler.TotalPrice;

            TotalResultlabel.Text = "₱" + updatedTotal.ToString("F2");

            if (cartData.Rows.Count > 0)
            {
                CartListGrid1.DataSource = cartData;
                CartListGrid1.ColumnHeadersDefaultCellStyle.Font = new Font(CartListGrid1.Font, FontStyle.Bold);
                CartListGrid1.BorderStyle = BorderStyle.None;
                CartListGrid1.CellBorderStyle = DataGridViewCellBorderStyle.None;
                CartListGrid1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                CartListGrid1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

                CartListGrid1.Columns[0].Width = 85; // Item column
                CartListGrid1.Columns[1].Width = 50; // Gender column
                CartListGrid1.Columns[2].Width = 35; // Size column
                CartListGrid1.Columns[3].Width = 60;  // Quantity column
                CartListGrid1.Columns[4].Width = 80; // Price column
            }

        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            DatabaseHandler dbHandler = new DatabaseHandler();
            DataTable cartData = dbHandler.GetCartData(); // This updates TotalPrice
            decimal updatedTotal = dbHandler.TotalPrice;
            CartListGrid1.DataSource = cartData;

            if(CartListGrid1.RowCount == 1)
            {
                ConfirmBtn.Enabled = false;
                Console.WriteLine("Cart is empty, can't proceed to receipt...");
                MessageBox.Show("Cart is Empty.");
            }
            else
            {
                Console.WriteLine("Printing Receipt...");
                Console.WriteLine("Generating Reference Number");
                Receipt receipt = new Receipt();
                receipt.Show();
                this.Close();
            }
  
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            switch (lastForm)
            {
                case "MaleSHS":
                    maleShsForm = new MaleShsForm(gender, lastForm);
                    maleShsForm.Show();
                    break;
                case "FemaleSHS":
                    femaleShsForm = new FemaleShsForm(gender, lastForm);
                    femaleShsForm.Show();
                    break;
                case "MaleIT":
                    maleITForm = new MaleITForm(gender, lastForm);
                    maleITForm.Show();
                    break;
                case "FemaleIT":
                    femaleITForm = new FemaleITForm(gender, lastForm);
                    femaleITForm.Show();
                    break;
                case "MaleTM":
                    maleTMForm = new MaleTMForm(gender, lastForm);
                    maleTMForm.Show();
                    break;
                case "FemaleTM":
                    femaleTMForm = new FemaleTMForm(gender, lastForm);
                    femaleTMForm.Show();
                    break;
                case "MaleHM":
                    maleHMForm = new MaleHMForm(gender, lastForm);
                    maleHMForm.Show();
                    break;
                case "FemaleHM":
                    femaleHMForm = new FemaleHMForm(gender, lastForm);
                    femaleHMForm.Show();
                    break;
                case "Proware":
                    prowareForm = new ProwareForm(category, lastForm);
                    prowareForm.Show();
                    break;
                case "MainMenu":
                    mainMenu = new Main_Menu(lastForm);
                    mainMenu.Show();
                    break;
                case "Cart":
                    mainMenu = new Main_Menu(lastForm);
                    mainMenu.Show();
                    break;
            }
            this.Close();
        }
    }
}
