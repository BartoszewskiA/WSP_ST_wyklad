using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w04p02_radio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) label1.Text = "Wybrano opcję 1";
            else if (radioButton2.Checked == true) label1.Text = "Wybrano opcję 2";
            else if (radioButton3.Checked == true) label1.Text = "Wybrano opcję 3";


        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            label1.Text = "Wybrano opcję 1";
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            label1.Text = "Wybrano opcję 2";
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            label1.Text = "Wybrano opcję 3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
