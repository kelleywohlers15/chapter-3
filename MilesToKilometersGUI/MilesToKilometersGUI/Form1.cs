﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilesToKilometersGUI
{
    public partial class MilesToKilometers : Form
    {
        public MilesToKilometers()
        {
            InitializeComponent();
        }

        private void btn_Convert_Click(object sender, EventArgs e)
        {
            double milesEntered;
            double kilos;
            const double MILES_TO_KILOS = 1.6;

            milesEntered = Convert.ToDouble(txtMiles.Text);
            kilos = milesEntered * MILES_TO_KILOS;
            
            lblToKilos.Text = "Kilometers is" + kilos;
        }




    }

     
    
}
