namespace W05p01_oknaDialogowe
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button7 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pozycja1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.podpunktAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.podpunktBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pozycja2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Okno komunikatu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(270, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Przechwycenie odpowiedzi okna";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Odpowiedź okna: ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 119);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(270, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Przechwycenie odpoweidzi okna (3 odp)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Odpowiedź okna: ";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 415);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(270, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "EXIT";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(16, 176);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(267, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Kolor";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(16, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 21);
            this.panel1.TabIndex = 7;
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.Red;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(16, 234);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(267, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "Font";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Testowy napis";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Pliki tekstowe(*.txt)| *.txt|Programy c# (*.cs)| *.cs| Wszystkie pliki(*.*) | *.*" +
    "";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(13, 281);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(270, 23);
            this.button7.TabIndex = 10;
            this.button7.Text = "Otwieranie pliku";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 11;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(16, 331);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(267, 23);
            this.button8.TabIndex = 12;
            this.button8.Text = "Zapis Pliku";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 13;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "Pliki tekstowe(*.txt)| *.txt|Programy c# (*.cs)| *.cs| Wszystkie pliki(*.*) | *.*" +
    "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pozycja1ToolStripMenuItem,
            this.pozycja2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(295, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // pozycja1ToolStripMenuItem
            // 
            this.pozycja1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.podpunktAToolStripMenuItem,
            this.podpunktBToolStripMenuItem});
            this.pozycja1ToolStripMenuItem.Name = "pozycja1ToolStripMenuItem";
            this.pozycja1ToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.pozycja1ToolStripMenuItem.Text = "Pozycja 1";
            // 
            // podpunktAToolStripMenuItem
            // 
            this.podpunktAToolStripMenuItem.Name = "podpunktAToolStripMenuItem";
            this.podpunktAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.podpunktAToolStripMenuItem.Text = "Podpunkt a";
            this.podpunktAToolStripMenuItem.Click += new System.EventHandler(this.podpunktAToolStripMenuItem_Click);
            // 
            // podpunktBToolStripMenuItem
            // 
            this.podpunktBToolStripMenuItem.Name = "podpunktBToolStripMenuItem";
            this.podpunktBToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.podpunktBToolStripMenuItem.Text = "Podpunkt b";
            // 
            // pozycja2ToolStripMenuItem
            // 
            this.pozycja2ToolStripMenuItem.Name = "pozycja2ToolStripMenuItem";
            this.pozycja2ToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.pozycja2ToolStripMenuItem.Text = "Pozycja 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pozycja1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem podpunktAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem podpunktBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pozycja2ToolStripMenuItem;
    }
}

