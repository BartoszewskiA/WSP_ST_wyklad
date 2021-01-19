using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuObrazkóWieleOkien
{
    public partial class Form2 : Form
    {
        Form1 rodzic;
        public Form2(Form1 f)
        {
            InitializeComponent();
            rodzic = f;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            rodzic.pictureBox1.Image = this.pictureBox1.Image;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            rodzic.pictureBox1.Image = this.pictureBox2.Image;
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
           if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
