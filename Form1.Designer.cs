namespace tetris3
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
            this.MENU = new System.Windows.Forms.Button();
            this.panelb = new System.Windows.Forms.Panel();
            this.panela = new System.Windows.Forms.Panel();
            this.panelc = new System.Windows.Forms.Panel();
            this.paneld = new System.Windows.Forms.Panel();
            this.panele = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.rownanie = new System.Windows.Forms.TextBox();
            this.textBoxa = new System.Windows.Forms.TextBox();
            this.textBoxb = new System.Windows.Forms.TextBox();
            this.textBoxc = new System.Windows.Forms.TextBox();
            this.textBoxd = new System.Windows.Forms.TextBox();
            this.textBoxe = new System.Windows.Forms.TextBox();
            this.buttonstart = new System.Windows.Forms.Button();
            this.panelc.SuspendLayout();
            this.SuspendLayout();
            // 
            // MENU
            // 
            this.MENU.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MENU.Location = new System.Drawing.Point(873, 27);
            this.MENU.Name = "MENU";
            this.MENU.Size = new System.Drawing.Size(107, 42);
            this.MENU.TabIndex = 0;
            this.MENU.Text = "MENU\r\n";
            this.MENU.UseVisualStyleBackColor = true;
            // 
            // panelb
            // 
            this.panelb.Location = new System.Drawing.Point(176, 0);
            this.panelb.Name = "panelb";
            this.panelb.Size = new System.Drawing.Size(160, 664);
            this.panelb.TabIndex = 1;
            // 
            // panela
            // 
            this.panela.Location = new System.Drawing.Point(1, 0);
            this.panela.Name = "panela";
            this.panela.Size = new System.Drawing.Size(169, 664);
            this.panela.TabIndex = 0;
            // 
            // panelc
            // 
            this.panelc.Controls.Add(this.rownanie);
            this.panelc.Location = new System.Drawing.Point(342, 0);
            this.panelc.Name = "panelc";
            this.panelc.Size = new System.Drawing.Size(158, 664);
            this.panelc.TabIndex = 2;
            // 
            // paneld
            // 
            this.paneld.Location = new System.Drawing.Point(506, 0);
            this.paneld.Name = "paneld";
            this.paneld.Size = new System.Drawing.Size(167, 664);
            this.paneld.TabIndex = 3;
            // 
            // panele
            // 
            this.panele.Location = new System.Drawing.Point(679, 0);
            this.panele.Name = "panele";
            this.panele.Size = new System.Drawing.Size(163, 664);
            this.panele.TabIndex = 4;
            this.panele.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(873, 595);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "ZAKOŃCZ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rownanie
            // 
            this.rownanie.Location = new System.Drawing.Point(0, 4);
            this.rownanie.Name = "rownanie";
            this.rownanie.Size = new System.Drawing.Size(157, 22);
            this.rownanie.TabIndex = 0;
            this.rownanie.Visible = false;
            this.rownanie.TextChanged += new System.EventHandler(this.rownanie_TextChanged);
            // 
            // textBoxa
            // 
            this.textBoxa.Enabled = false;
            this.textBoxa.Location = new System.Drawing.Point(5, 670);
            this.textBoxa.Name = "textBoxa";
            this.textBoxa.Size = new System.Drawing.Size(165, 22);
            this.textBoxa.TabIndex = 6;
            // 
            // textBoxb
            // 
            this.textBoxb.Enabled = false;
            this.textBoxb.Location = new System.Drawing.Point(176, 670);
            this.textBoxb.Name = "textBoxb";
            this.textBoxb.Size = new System.Drawing.Size(160, 22);
            this.textBoxb.TabIndex = 7;
            // 
            // textBoxc
            // 
            this.textBoxc.Enabled = false;
            this.textBoxc.Location = new System.Drawing.Point(342, 672);
            this.textBoxc.Name = "textBoxc";
            this.textBoxc.Size = new System.Drawing.Size(157, 22);
            this.textBoxc.TabIndex = 8;
            // 
            // textBoxd
            // 
            this.textBoxd.Enabled = false;
            this.textBoxd.Location = new System.Drawing.Point(506, 672);
            this.textBoxd.Name = "textBoxd";
            this.textBoxd.Size = new System.Drawing.Size(167, 22);
            this.textBoxd.TabIndex = 9;
            // 
            // textBoxe
            // 
            this.textBoxe.Enabled = false;
            this.textBoxe.Location = new System.Drawing.Point(679, 672);
            this.textBoxe.Name = "textBoxe";
            this.textBoxe.Size = new System.Drawing.Size(156, 22);
            this.textBoxe.TabIndex = 10;
            // 
            // buttonstart
            // 
            this.buttonstart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonstart.Location = new System.Drawing.Point(873, 447);
            this.buttonstart.Name = "buttonstart";
            this.buttonstart.Size = new System.Drawing.Size(107, 38);
            this.buttonstart.TabIndex = 11;
            this.buttonstart.Text = "START";
            this.buttonstart.UseVisualStyleBackColor = true;
            this.buttonstart.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.buttonstart);
            this.Controls.Add(this.textBoxe);
            this.Controls.Add(this.textBoxd);
            this.Controls.Add(this.textBoxc);
            this.Controls.Add(this.textBoxb);
            this.Controls.Add(this.textBoxa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panele);
            this.Controls.Add(this.paneld);
            this.Controls.Add(this.panelc);
            this.Controls.Add(this.panela);
            this.Controls.Add(this.panelb);
            this.Controls.Add(this.MENU);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelc.ResumeLayout(false);
            this.panelc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MENU;
        private System.Windows.Forms.Panel panelb;
        private System.Windows.Forms.Panel panela;
        private System.Windows.Forms.Panel panelc;
        private System.Windows.Forms.Panel paneld;
        private System.Windows.Forms.Panel panele;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox rownanie;
        private System.Windows.Forms.TextBox textBoxa;
        private System.Windows.Forms.TextBox textBoxb;
        private System.Windows.Forms.TextBox textBoxc;
        private System.Windows.Forms.TextBox textBoxd;
        private System.Windows.Forms.TextBox textBoxe;
        private System.Windows.Forms.Button buttonstart;
    }
}

