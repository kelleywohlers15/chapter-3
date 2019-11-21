using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MadLibsGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            double num;
            num = Convert.ToDouble(txtpicknumber1.Text) - Convert.ToDouble(txtpicknumber2.Text);

            lblresult.Text = "The " + txtcolor.Text + " Dragon is the " + txtwordest.Text +
                " Dragon of all. It has " + num + " " + txtbodypartsplural.Text +
                ", and a " + txtanimal.Text + " shaped like a " + txtbodypartsplural.Text +
                ", although it well feast on nearly anything.";


        }
   }
}
