namespace MB09.A13_1._2
{
    partial class A13_1_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtYear = new System.Windows.Forms.TextBox();
            this.LblAnswer = new System.Windows.Forms.Label();
            this.CmdStart = new System.Windows.Forms.Button();
            this.LblCount = new System.Windows.Forms.Label();
            this.LblShowCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jahreszahl eingeben (vierstellig):";
            // 
            // TxtYear
            // 
            this.TxtYear.Location = new System.Drawing.Point(195, 27);
            this.TxtYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtYear.Name = "TxtYear";
            this.TxtYear.Size = new System.Drawing.Size(88, 20);
            this.TxtYear.TabIndex = 1;
            // 
            // LblAnswer
            // 
            this.LblAnswer.AutoSize = true;
            this.LblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAnswer.Location = new System.Drawing.Point(26, 65);
            this.LblAnswer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblAnswer.Name = "LblAnswer";
            this.LblAnswer.Size = new System.Drawing.Size(25, 24);
            this.LblAnswer.TabIndex = 2;
            this.LblAnswer.Text = "...";
            // 
            // CmdStart
            // 
            this.CmdStart.Location = new System.Drawing.Point(294, 23);
            this.CmdStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmdStart.Name = "CmdStart";
            this.CmdStart.Size = new System.Drawing.Size(74, 22);
            this.CmdStart.TabIndex = 3;
            this.CmdStart.Text = "Schaltjahr?";
            this.CmdStart.UseVisualStyleBackColor = true;
            this.CmdStart.Click += new System.EventHandler(this.CmdStart_Click);
            // 
            // LblCount
            // 
            this.LblCount.AutoSize = true;
            this.LblCount.Location = new System.Drawing.Point(192, 108);
            this.LblCount.Name = "LblCount";
            this.LblCount.Size = new System.Drawing.Size(98, 13);
            this.LblCount.TabIndex = 4;
            this.LblCount.Text = "Wie oft aufgerufen:";
            // 
            // LblShowCount
            // 
            this.LblShowCount.AutoSize = true;
            this.LblShowCount.Location = new System.Drawing.Point(294, 108);
            this.LblShowCount.Name = "LblShowCount";
            this.LblShowCount.Size = new System.Drawing.Size(16, 13);
            this.LblShowCount.TabIndex = 5;
            this.LblShowCount.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 144);
            this.Controls.Add(this.LblShowCount);
            this.Controls.Add(this.LblCount);
            this.Controls.Add(this.CmdStart);
            this.Controls.Add(this.LblAnswer);
            this.Controls.Add(this.TxtYear);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Aufgabe_A13-1-2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtYear;
        private System.Windows.Forms.Label LblAnswer;
        private System.Windows.Forms.Button CmdStart;
        private System.Windows.Forms.Label LblCount;
        private System.Windows.Forms.Label LblShowCount;
    }
}

