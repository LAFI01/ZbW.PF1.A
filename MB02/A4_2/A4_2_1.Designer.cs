namespace MB02.A4_2
{
    partial class A4_2_1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.NumNumber1 = new System.Windows.Forms.NumericUpDown();
            this.NumNumber2 = new System.Windows.Forms.NumericUpDown();
            this.LblForNumer1 = new System.Windows.Forms.Label();
            this.LblForNumer2 = new System.Windows.Forms.Label();
            this.LblMessage1 = new System.Windows.Forms.Label();
            this.LblMessage2 = new System.Windows.Forms.Label();
            this.CmdStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumNumber1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumNumber2)).BeginInit();
            this.SuspendLayout();
            // 
            // NumNumber1
            // 
            this.NumNumber1.Location = new System.Drawing.Point(66, 51);
            this.NumNumber1.Name = "NumNumber1";
            this.NumNumber1.Size = new System.Drawing.Size(192, 20);
            this.NumNumber1.TabIndex = 0;
            this.NumNumber1.ValueChanged += new System.EventHandler(this.NumNumber1_ValueChanged);
            // 
            // NumNumber2
            // 
            this.NumNumber2.Location = new System.Drawing.Point(66, 99);
            this.NumNumber2.Name = "NumNumber2";
            this.NumNumber2.Size = new System.Drawing.Size(192, 20);
            this.NumNumber2.TabIndex = 1;
            this.NumNumber2.ValueChanged += new System.EventHandler(this.NumNumber2_ValueChanged);
            // 
            // LblForNumer1
            // 
            this.LblForNumer1.AutoSize = true;
            this.LblForNumer1.Location = new System.Drawing.Point(13, 57);
            this.LblForNumer1.Name = "LblForNumer1";
            this.LblForNumer1.Size = new System.Drawing.Size(40, 13);
            this.LblForNumer1.TabIndex = 2;
            this.LblForNumer1.Text = "Zahl 1:";
            // 
            // LblForNumer2
            // 
            this.LblForNumer2.AutoSize = true;
            this.LblForNumer2.Location = new System.Drawing.Point(16, 105);
            this.LblForNumer2.Name = "LblForNumer2";
            this.LblForNumer2.Size = new System.Drawing.Size(40, 13);
            this.LblForNumer2.TabIndex = 3;
            this.LblForNumer2.Text = "Zahl 2:";
            // 
            // LblMessage1
            // 
            this.LblMessage1.AutoSize = true;
            this.LblMessage1.Location = new System.Drawing.Point(66, 32);
            this.LblMessage1.Name = "LblMessage1";
            this.LblMessage1.Size = new System.Drawing.Size(0, 13);
            this.LblMessage1.TabIndex = 4;
            // 
            // LblMessage2
            // 
            this.LblMessage2.AutoSize = true;
            this.LblMessage2.Location = new System.Drawing.Point(66, 78);
            this.LblMessage2.Name = "LblMessage2";
            this.LblMessage2.Size = new System.Drawing.Size(0, 13);
            this.LblMessage2.TabIndex = 5;
            // 
            // CmdStart
            // 
            this.CmdStart.Location = new System.Drawing.Point(66, 144);
            this.CmdStart.Name = "CmdStart";
            this.CmdStart.Size = new System.Drawing.Size(192, 23);
            this.CmdStart.TabIndex = 6;
            this.CmdStart.Text = "Bestimme die grössere Zahl";
            this.CmdStart.UseVisualStyleBackColor = true;
            this.CmdStart.Click += new System.EventHandler(this.CmdStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CmdStart);
            this.Controls.Add(this.LblMessage2);
            this.Controls.Add(this.LblMessage1);
            this.Controls.Add(this.LblForNumer2);
            this.Controls.Add(this.LblForNumer1);
            this.Controls.Add(this.NumNumber2);
            this.Controls.Add(this.NumNumber1);
            this.Name = "Form1";
            this.Text = "Aufgabe_A4-1-1";
            ((System.ComponentModel.ISupportInitialize)(this.NumNumber1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumNumber2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumNumber1;
        private System.Windows.Forms.NumericUpDown NumNumber2;
        private System.Windows.Forms.Label LblForNumer1;
        private System.Windows.Forms.Label LblForNumer2;
        private System.Windows.Forms.Label LblMessage1;
        private System.Windows.Forms.Label LblMessage2;
        private System.Windows.Forms.Button CmdStart;
    }
}

