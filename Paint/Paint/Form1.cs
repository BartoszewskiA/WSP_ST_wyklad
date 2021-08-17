using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        Graphics g;
        Brush b = Brushes.Red;
        Color kTla=Color.Red, kRys = Color.Black;
        Pen p;
        bool rys = false;
        int px, py;

        private void button1_Click(object sender, EventArgs e)
        {
       
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

            if (rys)
            {
                g.DrawLine(p, new Point(px, py), new Point(e.X, e.Y));
                //g.DrawEllipse(p, e.X, e.X+5, e.Y+1, e.Y+1);
                px = e.X;
                py = e.Y;
            }
                

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
                rys = true;
                px = e.X;
                py = e.Y;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            p = new Pen(b, hScrollBar1.Value);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            rys = false;
        }

        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            p = new Pen(b, 10);


        }
    }
}
