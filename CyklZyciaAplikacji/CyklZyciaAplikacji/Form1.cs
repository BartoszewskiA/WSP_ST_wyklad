using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyklZyciaAplikacji
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Load");
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            //MessageBox.Show("Activate");
            richTextBox1.Text = richTextBox1.Text + "\nActivate";
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //MessageBox.Show("Shown");
            richTextBox1.Text = richTextBox1.Text + "\nShown";
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\nDeactivate";
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\nResize";
        }

        private void Form1_ResizeBegin(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\nResizeBegin";
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\nResizeEnd";
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\nPaint";
        }
    }
}
