namespace MB04.A9_2
{
    partial class A9_2_4
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
            this.TxtValues = new System.Windows.Forms.TextBox();
            this.CmdLargestNumber = new System.Windows.Forms.Button();
            this.CmdSmallestNumber = new System.Windows.Forms.Button();
            this.CmdAverage = new System.Windows.Forms.Button();
            this.LblLargestNumber = new System.Windows.Forms.Label();
            this.LblSmallestNumber = new System.Windows.Forms.Label();
            this.LblAverage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtValues
            // 
            this.TxtValues.Location = new System.Drawing.Point(13, 13);
            this.TxtValues.Name = "TxtValues";
            this.TxtValues.Size = new System.Drawing.Size(259, 20);
            this.TxtValues.TabIndex = 0;
            // 
            // CmdLargestNumber
            // 
            this.CmdLargestNumber.Location = new System.Drawing.Point(13, 51);
            this.CmdLargestNumber.Name = "CmdLargestNumber";
            this.CmdLargestNumber.Size = new System.Drawing.Size(94, 23);
            this.CmdLargestNumber.TabIndex = 1;
            this.CmdLargestNumber.Text = "Grösste Zahl";
            this.CmdLargestNumber.UseVisualStyleBackColor = true;
            this.CmdLargestNumber.Click += new System.EventHandler(this.CmdLargestNumber_Click);
            // 
            // CmdSmallestNumber
            // 
            this.CmdSmallestNumber.Location = new System.Drawing.Point(13, 81);
            this.CmdSmallestNumber.Name = "CmdSmallestNumber";
            this.CmdSmallestNumber.Size = new System.Drawing.Size(94, 23);
            this.CmdSmallestNumber.TabIndex = 2;
            this.CmdSmallestNumber.Text = "Kleinste Zahl";
            this.CmdSmallestNumber.UseVisualStyleBackColor = true;
            this.CmdSmallestNumber.Click += new System.EventHandler(this.CmdSmallestNumber_Click);
            // 
            // CmdAverage
            // 
            this.CmdAverage.Location = new System.Drawing.Point(13, 111);
            this.CmdAverage.Name = "CmdAverage";
            this.CmdAverage.Size = new System.Drawing.Size(94, 23);
            this.CmdAverage.TabIndex = 3;
            this.CmdAverage.Text = "Durchschnitt";
            this.CmdAverage.UseVisualStyleBackColor = true;
            this.CmdAverage.Click += new System.EventHandler(this.CmdAverage_Click);
            // 
            // LblLargestNumber
            // 
            this.LblLargestNumber.AutoSize = true;
            this.LblLargestNumber.Location = new System.Drawing.Point(113, 56);
            this.LblLargestNumber.Name = "LblLargestNumber";
            this.LblLargestNumber.Size = new System.Drawing.Size(16, 13);
            this.LblLargestNumber.TabIndex = 4;
            this.LblLargestNumber.Text = "...";
            // 
            // LblSmallestNumber
            // 
            this.LblSmallestNumber.AutoSize = true;
            this.LblSmallestNumber.Location = new System.Drawing.Point(113, 86);
            this.LblSmallestNumber.Name = "LblSmallestNumber";
            this.LblSmallestNumber.Size = new System.Drawing.Size(16, 13);
            this.LblSmallestNumber.TabIndex = 5;
            this.LblSmallestNumber.Text = "...";
            // 
            // LblAverage
            // 
            this.LblAverage.AutoSize = true;
            this.LblAverage.Location = new System.Drawing.Point(113, 116);
            this.LblAverage.Name = "LblAverage";
            this.LblAverage.Size = new System.Drawing.Size(16, 13);
            this.LblAverage.TabIndex = 6;
            this.LblAverage.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 165);
            this.Controls.Add(this.LblAverage);
            this.Controls.Add(this.LblSmallestNumber);
            this.Controls.Add(this.LblLargestNumber);
            this.Controls.Add(this.CmdAverage);
            this.Controls.Add(this.CmdSmallestNumber);
            this.Controls.Add(this.CmdLargestNumber);
            this.Controls.Add(this.TxtValues);
            this.Name = "Form1";
            this.Text = "Aufgabe_A9-2-4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtValues;
        private System.Windows.Forms.Button CmdLargestNumber;
        private System.Windows.Forms.Button CmdSmallestNumber;
        private System.Windows.Forms.Button CmdAverage;
        private System.Windows.Forms.Label LblLargestNumber;
        private System.Windows.Forms.Label LblSmallestNumber;
        private System.Windows.Forms.Label LblAverage;
    }
}

