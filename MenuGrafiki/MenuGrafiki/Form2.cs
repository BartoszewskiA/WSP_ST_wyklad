using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuGrafiki
{
    public partial class Form2 : Form
    {
        Form1 rodzic;
        public Form2(Form1 f)
        {
            InitializeComponent();
            rodzic = f;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            rodzic.pictureBox1.Image = this.pictureBox4.Image;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            rodzic.pictureBox1.Image = this.pictureBox3.Image;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            rodzic.pictureBox1.Image = this.pictureBox2.Image;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            rodzic.pictureBox1.Image = this.pictureBox1.Image;
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox3.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void pictureBox4_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox4.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
