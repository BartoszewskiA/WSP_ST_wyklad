using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w02p02_dodawnie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // textBox3.Text = textBox1.Text + textBox2.Text;
            //int x = int.Parse(textBox1.Text);
            int wynik, x=0, y=0;
            if (int.TryParse(textBox1.Text, out wynik)) x = wynik;
            else x = 0;
            if (int.TryParse(textBox2.Text, out wynik)) y = wynik;
            else y = 0;
            double suma = x + y;
            
            //   int y = int.Parse(textBox2.Text);
            
            //int wynik = x + y;
            //textBox3.Text = wynik.ToString();
            textBox3.Text = (x + y).ToString();
        }
    }
}
