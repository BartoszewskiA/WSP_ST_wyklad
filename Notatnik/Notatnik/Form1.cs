using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notatnik
{
    public partial class Form1 : Form
    {

        Boolean plikZapisany = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                toolStripStatusLabel1.Text = openFileDialog1.FileName;
                richTextBox1.Lines = otworzPlik(openFileDialog1.FileName);
                plikZapisany = true;
            }
        }

        private string[] otworzPlik(string fileName)
        {
            List<string> temp = new List<string>();
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            try
            {
                StreamReader sr = new StreamReader(fs);
                while (!sr.EndOfStream)
                {
                    temp.Add(sr.ReadLine());
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            return temp.ToArray();
        }

        private void zapiszjakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                toolStripStatusLabel1.Text = saveFileDialog1.FileName;
                zapiszDoPliku(saveFileDialog1.FileName, richTextBox1.Lines);
                plikZapisany = true;
            }
        }

        private void zapiszDoPliku(string fileName, string[] lines)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            try
            {
                StreamWriter sw = new StreamWriter(fs);
                for (int i=0; i<lines.Length; i++)
                {
                    sw.WriteLine(lines[i]);
                }
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(plikZapisany)
            {
                zapiszDoPliku(toolStripStatusLabel1.Text, richTextBox1.Lines);
            }
            else
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    toolStripStatusLabel1.Text = saveFileDialog1.FileName;
                    zapiszDoPliku(saveFileDialog1.FileName, richTextBox1.Lines);
                    plikZapisany = true;
                }
            }
        }

        private void wyczyśćToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
        }

        private void cofnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void kopiujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void wytnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void wklejToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void fontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void kolorFontówToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void kolorTłaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog2.Color;
            }
        }

        private void pomocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program Notatnik 2020 wykonany został w na wykładzie Wizualne Systemy Programowania UTH Rad",
                            "O programie");
        }
    }
}
