using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RozmiariPolorzenieOkna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Move(object sender, EventArgs e)
        {
           
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
          
        }

        private void Form1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
           // label1.Text = "X= " + e.X.ToString();
           // label2.Text = "Y= " + e.Y.ToString();
           // label3.Text = "Przyciks: " + e.Button.ToString();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            //label1.Text = "X= " + e.X.ToString();
           // label2.Text = "Y= " + e.Y.ToString();
           // label3.Text = "Przyciks: " + e.Button.ToString();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = "X= " + e.X.ToString();
            label2.Text = "Y= " + e.Y.ToString();
            label3.Text = "Przyciks: " + e.Button.ToString();
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Green;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Red;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                panel3.BackColor = Color.Green;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            panel3.BackColor = Color.Black;
        }
    }
}
