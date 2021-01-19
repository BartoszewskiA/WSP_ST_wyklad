using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatkiTablicaStringow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;

            backgroundWorker1.RunWorkerAsync(hScrollBar1.Value);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] tab = new string[100];
            int opuznienie = (int)e.Argument;
            for (int i = 0; i < 100; i++)
            {
                if (backgroundWorker1.CancellationPending == false)
                {
                    tab[i] = "Wiersz - " + i.ToString();
                    Thread.Sleep(opuznienie);
                    if (i % 10 == 0) backgroundWorker1.ReportProgress(i + 1);
                }
                else
                {
                    e.Cancel = true;
                    break;
                } 
            }
            e.Result = tab;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
           if (e.Cancelled)
                richTextBox1.Text = "Wątek przerwany przez użytkownika";
           else
                richTextBox1.Lines = (String[])e.Result;
        }

        private void h(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String[] czysta = new string[] { "" };
            richTextBox1.Lines = czysta;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }
    }
}
