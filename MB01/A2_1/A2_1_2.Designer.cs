namespace MB01.A2_1
{
    partial class A2_1_2
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
            this.TxtFirstname = new System.Windows.Forms.TextBox();
            this.TxtLastname = new System.Windows.Forms.TextBox();
            this.LblFirstname = new System.Windows.Forms.Label();
            this.LblLastname = new System.Windows.Forms.Label();
            this.CmdEnter = new System.Windows.Forms.Button();
            this.CmdClear = new System.Windows.Forms.Button();
            this.LblOutput = new System.Windows.Forms.Label();
            this.NumAge = new System.Windows.Forms.NumericUpDown();
            this.LblAge = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumAge)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtFirstname
            // 
            this.TxtFirstname.Location = new System.Drawing.Point(86, 12);
            this.TxtFirstname.Name = "TxtFirstname";
            this.TxtFirstname.Size = new System.Drawing.Size(186, 20);
            this.TxtFirstname.TabIndex = 0;
          
            // 
            // TxtLastname
            // 
            this.TxtLastname.Location = new System.Drawing.Point(86, 39);
            this.TxtLastname.Name = "TxtLastname";
            this.TxtLastname.Size = new System.Drawing.Size(186, 20);
            this.TxtLastname.TabIndex = 1;
            // 
            // LblFirstname
            // 
            this.LblFirstname.AutoSize = true;
            this.LblFirstname.Location = new System.Drawing.Point(12, 19);
            this.LblFirstname.Name = "LblFirstname";
            this.LblFirstname.Size = new System.Drawing.Size(55, 13);
            this.LblFirstname.TabIndex = 2;
            this.LblFirstname.Text = "Firstname:";
            // 
            // LblLastname
            // 
            this.LblLastname.AutoSize = true;
            this.LblLastname.Location = new System.Drawing.Point(12, 46);
            this.LblLastname.Name = "LblLastname";
            this.LblLastname.Size = new System.Drawing.Size(62, 13);
            this.LblLastname.TabIndex = 3;
            this.LblLastname.Text = "Nachname:";
            // 
            // CmdEnter
            // 
            this.CmdEnter.Location = new System.Drawing.Point(86, 107);
            this.CmdEnter.Name = "CmdEnter";
            this.CmdEnter.Size = new System.Drawing.Size(90, 23);
            this.CmdEnter.TabIndex = 4;
            this.CmdEnter.Text = "Ausgeben";
            this.CmdEnter.UseVisualStyleBackColor = true;
            this.CmdEnter.Click += new System.EventHandler(this.CmdEnter_Click);
            // 
            // CmdClear
            // 
            this.CmdClear.Location = new System.Drawing.Point(182, 107);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(90, 23);
            this.CmdClear.TabIndex = 5;
            this.CmdClear.Text = "Löschen";
            this.CmdClear.UseVisualStyleBackColor = true;
            this.CmdClear.Click += new System.EventHandler(this.CmdClear_Click);
            // 
            // LblOutput
            // 
            this.LblOutput.AutoSize = true;
            this.LblOutput.Location = new System.Drawing.Point(86, 145);
            this.LblOutput.Name = "LblOutput";
            this.LblOutput.Size = new System.Drawing.Size(16, 13);
            this.LblOutput.TabIndex = 6;
            this.LblOutput.Text = "...";
            // 
            // NumAge
            // 
            this.NumAge.Location = new System.Drawing.Point(86, 66);
            this.NumAge.Maximum = new decimal(new int[] {
            115,
            0,
            0,
            0});
            this.NumAge.Name = "NumAge";
            this.NumAge.Size = new System.Drawing.Size(186, 20);
            this.NumAge.TabIndex = 7;
            // 
            // LblAge
            // 
            this.LblAge.AutoSize = true;
            this.LblAge.Location = new System.Drawing.Point(12, 73);
            this.LblAge.Name = "LblAge";
            this.LblAge.Size = new System.Drawing.Size(34, 13);
            this.LblAge.TabIndex = 8;
            this.LblAge.Text = "Alter: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.LblAge);
            this.Controls.Add(this.NumAge);
            this.Controls.Add(this.LblOutput);
            this.Controls.Add(this.CmdClear);
            this.Controls.Add(this.CmdEnter);
            this.Controls.Add(this.LblLastname);
            this.Controls.Add(this.LblFirstname);
            this.Controls.Add(this.TxtLastname);
            this.Controls.Add(this.TxtFirstname);
            this.Name = "Form1";
            this.Text = "Beispiel Textfeld";
            ((System.ComponentModel.ISupportInitialize)(this.NumAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtFirstname;
        private System.Windows.Forms.TextBox TxtLastname;
        private System.Windows.Forms.Label LblFirstname;
        private System.Windows.Forms.Label LblLastname;
        private System.Windows.Forms.Button CmdEnter;
        private System.Windows.Forms.Button CmdClear;
        private System.Windows.Forms.Label LblOutput;
        private System.Windows.Forms.NumericUpDown NumAge;
        private System.Windows.Forms.Label LblAge;
    }
}

