using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W06p04
{
    public partial class Form1 : Form
    {
        int czas1 = 0, czas2=0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            czas2++;
            label2.Text = czas2.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            czas1++;
            label1.Text = czas1.ToString();
        }
    }
}
