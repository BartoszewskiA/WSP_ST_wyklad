using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W06p01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program testowy", "Info");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
                
                statusStrip1.Items[0].Text = openFileDialog1.FileName;

           

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
      

        }

        private void button1_Click(object sender, EventArgs e)
        {
            statusStrip1.Items.Add("nowa pozycja");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ile = statusStrip1.Items.Count;
            if (ile>0)
                statusStrip1.Items.RemoveAt(ile - 1);
        }
    }
}
