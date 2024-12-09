﻿using System;
using System.Windows.Forms;

namespace GearPoint
{
    public partial class MaleITForm : Form
    {
        private char gender;
        private string category;
        private double price;
        string lastForm;
        public string totalPrice;

        public MaleITForm(char gender, string lastForm, string totalPrice)
        {
            this.gender = gender;
            this.lastForm = lastForm;
            InitializeComponent();
            this.totalPrice = totalPrice;
        }

        // Reusable method for adding orders
        private void AddOrderItem(string itemName, double itemPrice)
        {
            price = itemPrice;
            var addOrder = new AddOrder(itemName, gender, price, "MaleIT");
            addOrder.Show();
            this.Close();
        }

        // Reusable method for navigating to other forms
        private void NavigateToForm(string selectedCategory, bool isProware = false)
        {
            if (isProware)
            {
                var prowareForm = new ProwareForm(selectedCategory, "MaleIT", totalPrice);
                prowareForm.Show();
            }
            else
            {
                var genderCheckpoint = new GenderCheckpoint(selectedCategory, "MaleIT", totalPrice);
                genderCheckpoint.Show();
            }
            this.Close();
        }

        // IT Top Handlers
        private void ITMenTopImage_Click(object sender, EventArgs e) => AddOrderItem(ITMenTopLbl.Text, 350);
        private void ITMenTopLbl_Click(object sender, EventArgs e) => AddOrderItem(ITMenTopLbl.Text, 350);
        private void ICTMentopCard_Click(object sender, EventArgs e) => AddOrderItem(ITMenTopLbl.Text, 350);

        // IT Pants Handlers
        private void ITMenPantsLabel_Click(object sender, EventArgs e) => AddOrderItem(ITMenPantsLabel.Text, 400);
        private void ITMenPantsImage_Click(object sender, EventArgs e) => AddOrderItem(ITMenPantsLabel.Text, 400);
        private void ITMenPantsBackCard_Click(object sender, EventArgs e) => AddOrderItem(ITMenPantsLabel.Text, 400);

        // IT Uniform Set Handlers
        private void ITMenUniformSetLabel_Click(object sender, EventArgs e) => AddOrderItem(ITMenUniformSetLabel.Text, 750);
        private void ITmenUniformSetImage_Click(object sender, EventArgs e) => AddOrderItem(ITMenUniformSetLabel.Text, 750);
        private void ITmenUniformSetBackCard_Click(object sender, EventArgs e) => AddOrderItem(ITMenUniformSetLabel.Text, 750);

        // Navigation Handlers
        private void ProwareLabelCard_Click(object sender, EventArgs e) => NavigateToForm(category, true);
        private void ProwareImageCard_Click(object sender, EventArgs e) => NavigateToForm(category, true);

        private void ShsLabel_Click(object sender, EventArgs e) => NavigateToForm("SHS");
        private void SHSImageCard_Click(object sender, EventArgs e) => NavigateToForm("SHS");

        private void TMLabel_Click(object sender, EventArgs e) => NavigateToForm("TM");
        private void TMImageCard_Click(object sender, EventArgs e) => NavigateToForm("TM");

        private void HMLabelCard_Click(object sender, EventArgs e) => NavigateToForm("HM");
        private void HMImageCard_Click(object sender, EventArgs e) => NavigateToForm("HM");

        private void MaleITForm_Load(object sender, EventArgs e)
        {
            TotalOutputLbl.Text = totalPrice;
        }
    }
}
