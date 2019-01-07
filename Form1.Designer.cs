namespace MT
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 36);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cos);
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.klik);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(624, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "START";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(624, 67);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 36);
            this.button3.TabIndex = 2;
            this.button3.Text = "RESTART";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(625, 145);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 35);
            this.button4.TabIndex = 3;
            this.button4.Text = "Poziom";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(625, 186);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 35);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(627, 359);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(114, 35);
            this.button6.TabIndex = 5;
            this.button6.Text = "ZAKOŃCZ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(469, 370);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(107, 38);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(356, 370);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(107, 38);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(243, 370);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(107, 38);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(130, 370);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(107, 38);
            this.button10.TabIndex = 9;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(17, 370);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(107, 38);
            this.button11.TabIndex = 10;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button12
            // 
            this.button12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button12.BackgroundImage")));
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button12.Location = new System.Drawing.Point(17, 297);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(558, 70);
            this.button12.TabIndex = 11;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Visible = false;
            // 
            // button13
            // 
            this.button13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button13.BackgroundImage")));
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button13.Location = new System.Drawing.Point(17, 221);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(555, 70);
            this.button13.TabIndex = 12;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Visible = false;
            // 
            // button14
            // 
            this.button14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button14.BackgroundImage")));
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button14.Location = new System.Drawing.Point(17, 145);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(551, 70);
            this.button14.TabIndex = 13;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Visible = false;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(627, 263);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(108, 28);
            this.button15.TabIndex = 14;
            this.button15.Text = "Liczba błędów";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(627, 297);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(108, 32);
            this.button16.TabIndex = 15;
            this.button16.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(761, 406);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.strzalki);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
    }
}

