using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W04p01_rgb
{
    public partial class Form1 : Form
    {
        string s = "";
        public Form1()
        {
            InitializeComponent();
            this.hScrollBar1_Scroll(this, null);
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            ustawKolor();
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            ustawKolor();
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            ustawKolor();
        }

        private void ustawKolor()
        {
            panel1.BackColor = Color.FromArgb(255, hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            s = "R=" + hScrollBar1.Value.ToString() +
                "  G=" + hScrollBar2.Value.ToString() +
                "  B=" + hScrollBar3.Value.ToString();
            label1.Text = s;
        }
    }
}
