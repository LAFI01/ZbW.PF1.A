namespace MB03.A6_2
{
    partial class A6_2_2
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
            this.LblValue = new System.Windows.Forms.Label();
            this.NumValue = new System.Windows.Forms.NumericUpDown();
            this.CmdStart = new System.Windows.Forms.Button();
            this.TxtBinaryResult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumValue)).BeginInit();
            this.SuspendLayout();
            // 
            // LblValue
            // 
            this.LblValue.AutoSize = true;
            this.LblValue.Location = new System.Drawing.Point(13, 13);
            this.LblValue.Name = "LblValue";
            this.LblValue.Size = new System.Drawing.Size(112, 13);
            this.LblValue.TabIndex = 0;
            this.LblValue.Text = "Ganze Zahl eingeben:";
            // 
            // NumValue
            // 
            this.NumValue.Location = new System.Drawing.Point(131, 11);
            this.NumValue.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.NumValue.Name = "NumValue";
            this.NumValue.Size = new System.Drawing.Size(141, 20);
            this.NumValue.TabIndex = 1;
            // 
            // CmdStart
            // 
            this.CmdStart.Location = new System.Drawing.Point(16, 51);
            this.CmdStart.Name = "CmdStart";
            this.CmdStart.Size = new System.Drawing.Size(128, 23);
            this.CmdStart.TabIndex = 2;
            this.CmdStart.Text = "Binärwert berechnen";
            this.CmdStart.UseVisualStyleBackColor = true;
            this.CmdStart.Click += new System.EventHandler(this.CmdStart_Click);
            // 
            // TxtBinaryResult
            // 
            this.TxtBinaryResult.Location = new System.Drawing.Point(16, 105);
            this.TxtBinaryResult.Name = "TxtBinaryResult";
            this.TxtBinaryResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtBinaryResult.Size = new System.Drawing.Size(253, 20);
            this.TxtBinaryResult.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 151);
            this.Controls.Add(this.TxtBinaryResult);
            this.Controls.Add(this.CmdStart);
            this.Controls.Add(this.NumValue);
            this.Controls.Add(this.LblValue);
            this.Name = "Form1";
            this.Text = "Aufgabe_A6-2-2";
            ((System.ComponentModel.ISupportInitialize)(this.NumValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblValue;
        private System.Windows.Forms.NumericUpDown NumValue;
        private System.Windows.Forms.Button CmdStart;
        private System.Windows.Forms.TextBox TxtBinaryResult;
    }
}

