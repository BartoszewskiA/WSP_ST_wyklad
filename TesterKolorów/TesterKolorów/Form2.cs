using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesterKolorów
{
    public partial class Form2 : Form
    {
        Form1 adresZwrotny;
        
        public Form2(Form1 f)
        {
            InitializeComponent();
            adresZwrotny = f;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            Color k = Color.FromArgb(255, hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            adresZwrotny.panel1.BackColor = k;
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            Color k = Color.FromArgb(255, hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            adresZwrotny.panel1.BackColor = k;
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            Color k = Color.FromArgb(255, hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            adresZwrotny.panel1.BackColor = k;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            adresZwrotny.okno = false;
        }
    }
}
