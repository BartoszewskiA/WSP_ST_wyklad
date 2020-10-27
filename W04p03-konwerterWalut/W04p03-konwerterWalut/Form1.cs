using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W04p03_konwerterWalut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x=0;
            if (double.TryParse(textBox1.Text, out x)) ;
            else x = 0;
            textBox2.Text = przelicz(x).ToString();
        }

        private double przelicz(double x)
        {
            double walutaPrzeliczeniowa = 0;
            double walutaDocelowa = 0;

            if (radioButton1.Checked == true) walutaPrzeliczeniowa = x;
            else if (radioButton2.Checked == true) walutaPrzeliczeniowa = x * 4.5;
            else if (radioButton3.Checked == true) walutaPrzeliczeniowa = x * 3.5;

            if (radioButton4.Checked == true) walutaDocelowa = walutaPrzeliczeniowa;
            else if (radioButton5.Checked == true) walutaDocelowa = walutaPrzeliczeniowa / 4.5;
            else if (radioButton6.Checked == true) walutaDocelowa = walutaPrzeliczeniowa / 3.5;

            //walutaDocelowa = Math.Round(walutaDocelowa*100)/100;
            return Math.Round(walutaDocelowa, 2);
        }
    }
}
