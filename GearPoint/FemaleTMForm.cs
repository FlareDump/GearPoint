﻿using System;
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
    public partial class FemaleTMForm : Form
    {
        string category;
        char gender;
        double price;
        Cart cart;
        public FemaleTMForm(string category, char gender)
        {
            this.category = category;
            this.gender = gender;
            InitializeComponent();
        }

        
    }
}
