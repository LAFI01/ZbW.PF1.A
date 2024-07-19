namespace MB03.A6_2
{
    partial class A6_2_4
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
            this.LblValue1 = new System.Windows.Forms.Label();
            this.NumValue1 = new System.Windows.Forms.NumericUpDown();
            this.NumValue2 = new System.Windows.Forms.NumericUpDown();
            this.LblValue2 = new System.Windows.Forms.Label();
            this.CmdKgv = new System.Windows.Forms.Button();
            this.TxtGgtResult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumValue1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumValue2)).BeginInit();
            this.SuspendLayout();
            // 
            // LblValue1
            // 
            this.LblValue1.AutoSize = true;
            this.LblValue1.Location = new System.Drawing.Point(13, 13);
            this.LblValue1.Name = "LblValue1";
            this.LblValue1.Size = new System.Drawing.Size(43, 13);
            this.LblValue1.TabIndex = 0;
            this.LblValue1.Text = "1. Zahl:";
            // 
            // NumValue1
            // 
            this.NumValue1.Location = new System.Drawing.Point(62, 11);
            this.NumValue1.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.NumValue1.Minimum = new decimal(new int[] {
            32000,
            0,
            0,
            -2147483648});
            this.NumValue1.Name = "NumValue1";
            this.NumValue1.Size = new System.Drawing.Size(200, 20);
            this.NumValue1.TabIndex = 1;
            // 
            // NumValue2
            // 
            this.NumValue2.Location = new System.Drawing.Point(62, 37);
            this.NumValue2.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.NumValue2.Minimum = new decimal(new int[] {
            32000,
            0,
            0,
            -2147483648});
            this.NumValue2.Name = "NumValue2";
            this.NumValue2.Size = new System.Drawing.Size(200, 20);
            this.NumValue2.TabIndex = 3;
            // 
            // LblValue2
            // 
            this.LblValue2.AutoSize = true;
            this.LblValue2.Location = new System.Drawing.Point(13, 39);
            this.LblValue2.Name = "LblValue2";
            this.LblValue2.Size = new System.Drawing.Size(43, 13);
            this.LblValue2.TabIndex = 2;
            this.LblValue2.Text = "2. Zahl:";
            // 
            // CmdKgv
            // 
            this.CmdKgv.Location = new System.Drawing.Point(16, 79);
            this.CmdKgv.Name = "CmdKgv";
            this.CmdKgv.Size = new System.Drawing.Size(97, 23);
            this.CmdKgv.TabIndex = 4;
            this.CmdKgv.Text = "Bestimme kgV";
            this.CmdKgv.UseVisualStyleBackColor = true;
            this.CmdKgv.Click += new System.EventHandler(this.CmdKgv_Click);
            // 
            // TxtGgtResult
            // 
            this.TxtGgtResult.Location = new System.Drawing.Point(120, 81);
            this.TxtGgtResult.Name = "TxtGgtResult";
            this.TxtGgtResult.Size = new System.Drawing.Size(142, 20);
            this.TxtGgtResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.TxtGgtResult);
            this.Controls.Add(this.CmdKgv);
            this.Controls.Add(this.NumValue2);
            this.Controls.Add(this.LblValue2);
            this.Controls.Add(this.NumValue1);
            this.Controls.Add(this.LblValue1);
            this.Name = "Form1";
            this.Text = "Aufgabe_A6-2-4";
            ((System.ComponentModel.ISupportInitialize)(this.NumValue1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumValue2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblValue1;
        private System.Windows.Forms.NumericUpDown NumValue1;
        private System.Windows.Forms.NumericUpDown NumValue2;
        private System.Windows.Forms.Label LblValue2;
        private System.Windows.Forms.Button CmdKgv;
        private System.Windows.Forms.TextBox TxtGgtResult;
    }
}

