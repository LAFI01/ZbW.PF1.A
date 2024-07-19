namespace MB05.A10_1
{
    partial class A10_1_7
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
            this.CmdGenerateRandomValues = new System.Windows.Forms.Button();
            this.TxtValues = new System.Windows.Forms.TextBox();
            this.CmdLargestNumber = new System.Windows.Forms.Button();
            this.CmdSmallestNumber = new System.Windows.Forms.Button();
            this.CmdAverage = new System.Windows.Forms.Button();
            this.LblLargestNumber = new System.Windows.Forms.Label();
            this.LblSmallestNumber = new System.Windows.Forms.Label();
            this.LblAverage = new System.Windows.Forms.Label();
            this.CmdDeltaMax = new System.Windows.Forms.Button();
            this.CmdDeltaMin = new System.Windows.Forms.Button();
            this.LblDeltaMax = new System.Windows.Forms.Label();
            this.LblDeltaMin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdGenerateRandomValues
            // 
            this.CmdGenerateRandomValues.Location = new System.Drawing.Point(12, 133);
            this.CmdGenerateRandomValues.Name = "CmdGenerateRandomValues";
            this.CmdGenerateRandomValues.Size = new System.Drawing.Size(402, 23);
            this.CmdGenerateRandomValues.TabIndex = 0;
            this.CmdGenerateRandomValues.Text = "Generiere Zufallszahlen";
            this.CmdGenerateRandomValues.UseVisualStyleBackColor = true;
            this.CmdGenerateRandomValues.Click += new System.EventHandler(this.CmdGenerateRandomValues_Click);
            // 
            // TxtValues
            // 
            this.TxtValues.Location = new System.Drawing.Point(10, 12);
            this.TxtValues.Multiline = true;
            this.TxtValues.Name = "TxtValues";
            this.TxtValues.Size = new System.Drawing.Size(404, 109);
            this.TxtValues.TabIndex = 1;
            // 
            // CmdLargestNumber
            // 
            this.CmdLargestNumber.Location = new System.Drawing.Point(12, 177);
            this.CmdLargestNumber.Name = "CmdLargestNumber";
            this.CmdLargestNumber.Size = new System.Drawing.Size(109, 23);
            this.CmdLargestNumber.TabIndex = 2;
            this.CmdLargestNumber.Text = "Grösster Wert";
            this.CmdLargestNumber.UseVisualStyleBackColor = true;
            this.CmdLargestNumber.Click += new System.EventHandler(this.CmdLargestNumber_Click);
            // 
            // CmdSmallestNumber
            // 
            this.CmdSmallestNumber.Location = new System.Drawing.Point(12, 215);
            this.CmdSmallestNumber.Name = "CmdSmallestNumber";
            this.CmdSmallestNumber.Size = new System.Drawing.Size(109, 23);
            this.CmdSmallestNumber.TabIndex = 3;
            this.CmdSmallestNumber.Text = "Kleinster Wert";
            this.CmdSmallestNumber.UseVisualStyleBackColor = true;
            this.CmdSmallestNumber.Click += new System.EventHandler(this.CmdSmallestNumber_Click);
            // 
            // CmdAverage
            // 
            this.CmdAverage.Location = new System.Drawing.Point(12, 253);
            this.CmdAverage.Name = "CmdAverage";
            this.CmdAverage.Size = new System.Drawing.Size(109, 23);
            this.CmdAverage.TabIndex = 4;
            this.CmdAverage.Text = "Mittelwert";
            this.CmdAverage.UseVisualStyleBackColor = true;
            this.CmdAverage.Click += new System.EventHandler(this.CmdAverage_Click);
            // 
            // LblLargestNumber
            // 
            this.LblLargestNumber.AutoSize = true;
            this.LblLargestNumber.Location = new System.Drawing.Point(127, 182);
            this.LblLargestNumber.Name = "LblLargestNumber";
            this.LblLargestNumber.Size = new System.Drawing.Size(16, 13);
            this.LblLargestNumber.TabIndex = 5;
            this.LblLargestNumber.Text = "...";
            // 
            // LblSmallestNumber
            // 
            this.LblSmallestNumber.AutoSize = true;
            this.LblSmallestNumber.Location = new System.Drawing.Point(127, 220);
            this.LblSmallestNumber.Name = "LblSmallestNumber";
            this.LblSmallestNumber.Size = new System.Drawing.Size(16, 13);
            this.LblSmallestNumber.TabIndex = 6;
            this.LblSmallestNumber.Text = "...";
            // 
            // LblAverage
            // 
            this.LblAverage.AutoSize = true;
            this.LblAverage.Location = new System.Drawing.Point(127, 258);
            this.LblAverage.Name = "LblAverage";
            this.LblAverage.Size = new System.Drawing.Size(16, 13);
            this.LblAverage.TabIndex = 7;
            this.LblAverage.Text = "...";
            // 
            // CmdDeltaMax
            // 
            this.CmdDeltaMax.Location = new System.Drawing.Point(13, 292);
            this.CmdDeltaMax.Name = "CmdDeltaMax";
            this.CmdDeltaMax.Size = new System.Drawing.Size(108, 23);
            this.CmdDeltaMax.TabIndex = 8;
            this.CmdDeltaMax.Text = "Grösstes Delta";
            this.CmdDeltaMax.UseVisualStyleBackColor = true;
            this.CmdDeltaMax.Click += new System.EventHandler(this.CmdDeltaMax_Click);
            // 
            // CmdDeltaMin
            // 
            this.CmdDeltaMin.Location = new System.Drawing.Point(13, 332);
            this.CmdDeltaMin.Name = "CmdDeltaMin";
            this.CmdDeltaMin.Size = new System.Drawing.Size(108, 23);
            this.CmdDeltaMin.TabIndex = 9;
            this.CmdDeltaMin.Text = "Kleinstes Delta";
            this.CmdDeltaMin.UseVisualStyleBackColor = true;
            this.CmdDeltaMin.Click += new System.EventHandler(this.CmdDeltaMin_Click);
            // 
            // LblDeltaMax
            // 
            this.LblDeltaMax.AutoSize = true;
            this.LblDeltaMax.Location = new System.Drawing.Point(127, 297);
            this.LblDeltaMax.Name = "LblDeltaMax";
            this.LblDeltaMax.Size = new System.Drawing.Size(16, 13);
            this.LblDeltaMax.TabIndex = 10;
            this.LblDeltaMax.Text = "...";
            // 
            // LblDeltaMin
            // 
            this.LblDeltaMin.AutoSize = true;
            this.LblDeltaMin.Location = new System.Drawing.Point(127, 337);
            this.LblDeltaMin.Name = "LblDeltaMin";
            this.LblDeltaMin.Size = new System.Drawing.Size(16, 13);
            this.LblDeltaMin.TabIndex = 11;
            this.LblDeltaMin.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 382);
            this.Controls.Add(this.LblDeltaMin);
            this.Controls.Add(this.LblDeltaMax);
            this.Controls.Add(this.CmdDeltaMin);
            this.Controls.Add(this.CmdDeltaMax);
            this.Controls.Add(this.LblAverage);
            this.Controls.Add(this.LblSmallestNumber);
            this.Controls.Add(this.LblLargestNumber);
            this.Controls.Add(this.CmdAverage);
            this.Controls.Add(this.CmdSmallestNumber);
            this.Controls.Add(this.CmdLargestNumber);
            this.Controls.Add(this.TxtValues);
            this.Controls.Add(this.CmdGenerateRandomValues);
            this.Name = "Form1";
            this.Text = "Aufgabe_A10-1-7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdGenerateRandomValues;
        private System.Windows.Forms.TextBox TxtValues;
        private System.Windows.Forms.Button CmdLargestNumber;
        private System.Windows.Forms.Button CmdSmallestNumber;
        private System.Windows.Forms.Button CmdAverage;
        private System.Windows.Forms.Label LblLargestNumber;
        private System.Windows.Forms.Label LblSmallestNumber;
        private System.Windows.Forms.Label LblAverage;
        private System.Windows.Forms.Button CmdDeltaMax;
        private System.Windows.Forms.Button CmdDeltaMin;
        private System.Windows.Forms.Label LblDeltaMax;
        private System.Windows.Forms.Label LblDeltaMin;
    }
}

