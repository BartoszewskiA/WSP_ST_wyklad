using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesterKolorów
{
    public partial class Form1 : Form
    {
        Form2 form2;
        public Boolean okno = false;
        
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2(this);
            form2.Show();
            okno = true;

        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            if (!okno)
            {
                form2 = new Form2(this);
                form2.Show();
                okno = true;
            }
            
        }
    }
}
