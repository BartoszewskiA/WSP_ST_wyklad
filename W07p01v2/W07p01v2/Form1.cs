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

namespace W07p01v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                if (!Directory.Exists(folderBrowserDialog1.SelectedPath + "test"))
                {
                    Directory.CreateDirectory(folderBrowserDialog1.SelectedPath + "test");
                }

            }
        }

        String src, dst;

        private void button3_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                dst = saveFileDialog1.FileName;
                label2.Text = dst;
                if(!File.Exists(dst))
                {
                    File.Copy(src, dst);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                if(!File.Exists(saveFileDialog1.FileName))  //jeżeli nie chcemy mieć możliwości nadpisania pliku
                {
                    StreamWriter sw = File.CreateText(saveFileDialog1.FileName);
                    sw.WriteLine("To jest tekst zapisany do pliku");
                    sw.Close();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                List<string> tekst = new List<string>();
                
                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                while (!sr.EndOfStream)
                {
                    tekst.Add(sr.ReadLine());
                }
                sr.Close();

                tekst.RemoveAt(0);

                richTextBox1.Lines = tekst.ToArray();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write);
                try
                {
                    StreamWriter sw = new StreamWriter(fs);
                    List<string> tekst = new List<string>(richTextBox1.Lines);
                    for (int i=0; i<tekst.Count(); i++)
                    {
                        if (tekst[i].Length>0)
                            sw.WriteLine(tekst[i]);
                    }
                    sw.Close();

                } catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                src = openFileDialog1.FileName;
                label1.Text = src;
            }
        }
    }
}
