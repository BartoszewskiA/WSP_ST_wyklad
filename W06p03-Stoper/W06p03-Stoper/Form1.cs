using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W06p03_Stoper
{
    public partial class Form1 : Form
    {

        long czas=0;
        string doWyswietlenia="";
        public Form1()
        {
            InitializeComponent();
            doWyswietlenia = (czas / 6000).ToString() +
                            ":" + (czas / 100).ToString() +
                            ":" + (czas % 100).ToString();
            textBox1.Text = doWyswietlenia;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            if (timer1.Enabled == false) button1.Text = "START";
            else button1.Text = "STOP";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            czas++;
            doWyswietlenia = (czas / 6000).ToString()+
                             ":"+ (czas / 100).ToString() + 
                             ":" + (czas % 100).ToString();

            textBox1.Text = doWyswietlenia;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            czas = 0;
            doWyswietlenia = (czas / 6000).ToString() +
                             ":" + (czas / 100).ToString() +
                             ":" + (czas % 100).ToString();
            textBox1.Text = doWyswietlenia;
        }
    }
}
