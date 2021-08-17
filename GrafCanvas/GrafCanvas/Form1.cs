using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrafCanvas
{
    public partial class Form1 : Form
    {
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Brush b = Brushes.Red;
            Pen p = new Pen(b, 3);
            Size obszar = this.ClientSize;
           // int szerokosc = obszar.Width;
            //int wysokosc = obszar.Height;
            g.DrawLine(p, new Point(0, 0), new Point(obszar.Width, obszar.Height));
            g.DrawEllipse(p, new Rectangle(0,0, obszar.Width, obszar.Height));
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
