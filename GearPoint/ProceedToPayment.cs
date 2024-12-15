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
    public partial class ProceedToPayment : Form
    {

        private string lastForm;
        private string total;
        private string totalPrice;


        Cart cart; MaleShsForm maleShsForm;
        FemaleShsForm femaleShsForm;
        MaleITForm maleITForm;
        FemaleITForm femaleITForm;
        MaleTMForm maleTMForm;
        FemaleTMForm femaleTMForm;
        MaleHMForm maleHMForm;
        FemaleHMForm femaleHMForm;
        ProwareForm prowareForm;
        Main_Menu menu = new Main_Menu();
        public ProceedToPayment()
        {
            InitializeComponent();
        }

        //private void BackButton_Click(object sender, EventArgs e)
        //{
        //    switch (lastForm)
        //    {
        //        case "cart":
        //            cart = new Cart("N/A","/NA","N/A","N/A","N/A","N/A", lastForm);
        //            cart.Show();
        //            break;
        //        case "MainMenu":
        //            menu = new Main_Menu(lastForm, total, totalPrice);
        //            menu.Show();
        //            break;
        //    }
        //}

        private void BackButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}
