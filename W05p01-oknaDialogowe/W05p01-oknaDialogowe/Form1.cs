using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W05p01_oknaDialogowe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To jest okno komunikatu",
                            "Tytuł okna",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ważne pytanie", "Okno pytania", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                label1.Text = "Odpowiedź okna: YES";
            else
                label1.Text ="Odpowiedź okna: NO";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult odp = MessageBox.Show("Pytanie", "okno pytania", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            switch(odp)
            {
                case DialogResult.Yes: label2.Text = "Odpowiedź okna YES"; break;
                case DialogResult.No: label2.Text = "Odpowiedź okna NO"; break;
                case DialogResult.Cancel: label2.Text = "Odpowiedź okna CANCEL"; break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           // if (MessageBox.Show("Jesteś pewien?", "pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
               Close();
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Zamknąć?", "Czy zamknąć?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        { 
     
              
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog()==DialogResult.OK)
                panel1.BackColor = colorDialog1.Color;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                label3.Font = fontDialog1.Font;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                label4.Text = openFileDialog1.FileName;

            //Pliki tekstowe(*.txt)| *.txt|Programy c# (*.cs)| *.cs| Wszystkie pliki(*.*) | *.*

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                label5.Text = saveFileDialog1.FileName;
        }

        private void podpunktAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("użyto menu");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
