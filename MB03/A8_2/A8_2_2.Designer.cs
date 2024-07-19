namespace MB03.A8_2
{
    partial class CmdCalculate
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
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblBodySize = new System.Windows.Forms.Label();
            this.NumBodySize = new System.Windows.Forms.NumericUpDown();
            this.LblMetric1 = new System.Windows.Forms.Label();
            this.LblMetric2 = new System.Windows.Forms.Label();
            this.NumBodyWeight = new System.Windows.Forms.NumericUpDown();
            this.LblBodyWeight = new System.Windows.Forms.Label();
            this.LblBMI = new System.Windows.Forms.Label();
            this.TxtBMI = new System.Windows.Forms.TextBox();
            this.CmdCalculateBMI = new System.Windows.Forms.Button();
            this.LblDescription = new System.Windows.Forms.Label();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.RadMale = new System.Windows.Forms.RadioButton();
            this.RadFemale = new System.Windows.Forms.RadioButton();
            this.LblSex = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumBodySize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumBodyWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(9, 9);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(235, 42);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "BMI Rechner";
            // 
            // LblBodySize
            // 
            this.LblBodySize.AutoSize = true;
            this.LblBodySize.Location = new System.Drawing.Point(14, 81);
            this.LblBodySize.Name = "LblBodySize";
            this.LblBodySize.Size = new System.Drawing.Size(72, 13);
            this.LblBodySize.TabIndex = 1;
            this.LblBodySize.Text = "Körpergrösse:";
            // 
            // NumBodySize
            // 
            this.NumBodySize.Location = new System.Drawing.Point(92, 79);
            this.NumBodySize.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.NumBodySize.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.NumBodySize.Name = "NumBodySize";
            this.NumBodySize.Size = new System.Drawing.Size(152, 20);
            this.NumBodySize.TabIndex = 2;
            this.NumBodySize.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // LblMetric1
            // 
            this.LblMetric1.AutoSize = true;
            this.LblMetric1.Location = new System.Drawing.Point(250, 81);
            this.LblMetric1.Name = "LblMetric1";
            this.LblMetric1.Size = new System.Drawing.Size(21, 13);
            this.LblMetric1.TabIndex = 3;
            this.LblMetric1.Text = "cm";
            // 
            // LblMetric2
            // 
            this.LblMetric2.AutoSize = true;
            this.LblMetric2.Location = new System.Drawing.Point(248, 118);
            this.LblMetric2.Name = "LblMetric2";
            this.LblMetric2.Size = new System.Drawing.Size(19, 13);
            this.LblMetric2.TabIndex = 6;
            this.LblMetric2.Text = "kg";
            // 
            // NumBodyWeight
            // 
            this.NumBodyWeight.Location = new System.Drawing.Point(90, 116);
            this.NumBodyWeight.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.NumBodyWeight.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumBodyWeight.Name = "NumBodyWeight";
            this.NumBodyWeight.Size = new System.Drawing.Size(152, 20);
            this.NumBodyWeight.TabIndex = 5;
            this.NumBodyWeight.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // LblBodyWeight
            // 
            this.LblBodyWeight.AutoSize = true;
            this.LblBodyWeight.Location = new System.Drawing.Point(15, 118);
            this.LblBodyWeight.Name = "LblBodyWeight";
            this.LblBodyWeight.Size = new System.Drawing.Size(49, 13);
            this.LblBodyWeight.TabIndex = 4;
            this.LblBodyWeight.Text = "Gewicht:";
            // 
            // LblBMI
            // 
            this.LblBMI.AutoSize = true;
            this.LblBMI.Location = new System.Drawing.Point(12, 189);
            this.LblBMI.Name = "LblBMI";
            this.LblBMI.Size = new System.Drawing.Size(91, 13);
            this.LblBMI.TabIndex = 7;
            this.LblBMI.Text = "Body Mass Index:";
            // 
            // TxtBMI
            // 
            this.TxtBMI.Enabled = false;
            this.TxtBMI.Location = new System.Drawing.Point(109, 186);
            this.TxtBMI.Name = "TxtBMI";
            this.TxtBMI.Size = new System.Drawing.Size(133, 20);
            this.TxtBMI.TabIndex = 8;
            // 
            // CmdCalculateBMI
            // 
            this.CmdCalculateBMI.Location = new System.Drawing.Point(15, 218);
            this.CmdCalculateBMI.Name = "CmdCalculateBMI";
            this.CmdCalculateBMI.Size = new System.Drawing.Size(229, 23);
            this.CmdCalculateBMI.TabIndex = 9;
            this.CmdCalculateBMI.Text = "Berechne meinen BMI";
            this.CmdCalculateBMI.UseVisualStyleBackColor = true;
            this.CmdCalculateBMI.Click += new System.EventHandler(this.Click_CmdCalculateBMI);
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new System.Drawing.Point(15, 248);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(64, 13);
            this.LblDescription.TabIndex = 10;
            this.LblDescription.Text = "Erläuterung:";
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(15, 265);
            this.TxtDescription.Multiline = true;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(227, 94);
            this.TxtDescription.TabIndex = 11;
            // 
            // RadMale
            // 
            this.RadMale.AutoSize = true;
            this.RadMale.Location = new System.Drawing.Point(92, 147);
            this.RadMale.Name = "RadMale";
            this.RadMale.Size = new System.Drawing.Size(67, 17);
            this.RadMale.TabIndex = 12;
            this.RadMale.TabStop = true;
            this.RadMale.Text = "männlich";
            this.RadMale.UseVisualStyleBackColor = true;
            // 
            // RadFemale
            // 
            this.RadFemale.AutoSize = true;
            this.RadFemale.Location = new System.Drawing.Point(175, 147);
            this.RadFemale.Name = "RadFemale";
            this.RadFemale.Size = new System.Drawing.Size(63, 17);
            this.RadFemale.TabIndex = 13;
            this.RadFemale.TabStop = true;
            this.RadFemale.Text = "weiblich";
            this.RadFemale.UseVisualStyleBackColor = true;
            // 
            // LblSex
            // 
            this.LblSex.AutoSize = true;
            this.LblSex.Location = new System.Drawing.Point(15, 149);
            this.LblSex.Name = "LblSex";
            this.LblSex.Size = new System.Drawing.Size(64, 13);
            this.LblSex.TabIndex = 14;
            this.LblSex.Text = "Geschlecht:";
            // 
            // CmdCalculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 407);
            this.Controls.Add(this.LblSex);
            this.Controls.Add(this.RadFemale);
            this.Controls.Add(this.RadMale);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.CmdCalculateBMI);
            this.Controls.Add(this.TxtBMI);
            this.Controls.Add(this.LblBMI);
            this.Controls.Add(this.LblMetric2);
            this.Controls.Add(this.NumBodyWeight);
            this.Controls.Add(this.LblBodyWeight);
            this.Controls.Add(this.LblMetric1);
            this.Controls.Add(this.NumBodySize);
            this.Controls.Add(this.LblBodySize);
            this.Controls.Add(this.LblTitle);
            this.Name = "CmdCalculate";
            this.Text = "Aufgabe_A8-2-2";
            ((System.ComponentModel.ISupportInitialize)(this.NumBodySize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumBodyWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblBodySize;
        private System.Windows.Forms.NumericUpDown NumBodySize;
        private System.Windows.Forms.Label LblMetric1;
        private System.Windows.Forms.Label LblMetric2;
        private System.Windows.Forms.NumericUpDown NumBodyWeight;
        private System.Windows.Forms.Label LblBodyWeight;
        private System.Windows.Forms.Label LblBMI;
        private System.Windows.Forms.TextBox TxtBMI;
        private System.Windows.Forms.Button CmdCalculateBMI;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.RadioButton RadMale;
        private System.Windows.Forms.RadioButton RadFemale;
        private System.Windows.Forms.Label LblSex;
    }
}

