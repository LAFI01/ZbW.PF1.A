namespace MB02
{
    partial class A3_1_2
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
            this.NumMonths = new System.Windows.Forms.NumericUpDown();
            this.LabelMonths = new System.Windows.Forms.Label();
            this.LblMonth = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumMonths)).BeginInit();
            this.SuspendLayout();
            // 
            // NumMonths
            // 
            this.NumMonths.Location = new System.Drawing.Point(131, 46);
            this.NumMonths.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.NumMonths.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumMonths.Name = "NumMonths";
            this.NumMonths.Size = new System.Drawing.Size(122, 20);
            this.NumMonths.TabIndex = 0;
            this.NumMonths.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumMonths.ValueChanged += new System.EventHandler(this.NumMonths_ValueChanged);
            // 
            // LabelMonths
            // 
            this.LabelMonths.AutoSize = true;
            this.LabelMonths.Location = new System.Drawing.Point(13, 48);
            this.LabelMonths.Name = "LabelMonths";
            this.LabelMonths.Size = new System.Drawing.Size(112, 13);
            this.LabelMonths.TabIndex = 1;
            this.LabelMonths.Text = "Wählen Sie eine Zahl:";
            // 
            // LblMonth
            // 
            this.LblMonth.AutoSize = true;
            this.LblMonth.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblMonth.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblMonth.Location = new System.Drawing.Point(19, 111);
            this.LblMonth.MinimumSize = new System.Drawing.Size(230, 20);
            this.LblMonth.Name = "LblMonth";
            this.LblMonth.Size = new System.Drawing.Size(230, 20);
            this.LblMonth.TabIndex = 2;
            this.LblMonth.Text = "Januar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.LblMonth);
            this.Controls.Add(this.LabelMonths);
            this.Controls.Add(this.NumMonths);
            this.Name = "Form1";
            this.Text = "Aufgabe_A3-1-2";
            ((System.ComponentModel.ISupportInitialize)(this.NumMonths)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumMonths;
        private System.Windows.Forms.Label LabelMonths;
        private System.Windows.Forms.Label LblMonth;
    }
}

