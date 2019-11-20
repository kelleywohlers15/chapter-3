using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total;
            double avg;

            total = Convert.ToInt32(txtScore1.Text) + Convert.ToInt32(txtScore2.Text) +
                Convert.ToInt32(txtScore3.Text) + Convert.ToInt32(txtScore4.Text) +
                Convert.ToInt32(txtScore5.Text);

            avg = total / 5;

                lblresult.Text = "Average score is: " + avg;




        }
    }
}
