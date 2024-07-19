namespace MB05.A10_1
{
    partial class A10_1_5
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
            this.Lbl2 = new System.Windows.Forms.Label();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.LblValueGlobalVal1 = new System.Windows.Forms.Label();
            this.LblValueGlobalVal2 = new System.Windows.Forms.Label();
            this.CmdCopyByValue = new System.Windows.Forms.Button();
            this.CmdCopyByReference = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblValueGlobalVal2_2 = new System.Windows.Forms.Label();
            this.LblValueGlobalVal1_1 = new System.Windows.Forms.Label();
            this.CmdClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.Location = new System.Drawing.Point(13, 18);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(268, 13);
            this.Lbl2.TabIndex = 0;
            this.Lbl2.Text = "Wert der globalen Variable global1 vor Methodenaufruf:";
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Location = new System.Drawing.Point(13, 41);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(268, 13);
            this.Lbl1.TabIndex = 1;
            this.Lbl1.Text = "Wert der globalen Variable global2 vor Methodenaufruf:";
            // 
            // LblValueGlobalVal1
            // 
            this.LblValueGlobalVal1.AutoSize = true;
            this.LblValueGlobalVal1.Location = new System.Drawing.Point(287, 18);
            this.LblValueGlobalVal1.Name = "LblValueGlobalVal1";
            this.LblValueGlobalVal1.Size = new System.Drawing.Size(16, 13);
            this.LblValueGlobalVal1.TabIndex = 2;
            this.LblValueGlobalVal1.Text = "...";
            // 
            // LblValueGlobalVal2
            // 
            this.LblValueGlobalVal2.AutoSize = true;
            this.LblValueGlobalVal2.Location = new System.Drawing.Point(287, 41);
            this.LblValueGlobalVal2.Name = "LblValueGlobalVal2";
            this.LblValueGlobalVal2.Size = new System.Drawing.Size(16, 13);
            this.LblValueGlobalVal2.TabIndex = 3;
            this.LblValueGlobalVal2.Text = "...";
            // 
            // CmdCopyByValue
            // 
            this.CmdCopyByValue.Location = new System.Drawing.Point(16, 74);
            this.CmdCopyByValue.Name = "CmdCopyByValue";
            this.CmdCopyByValue.Size = new System.Drawing.Size(139, 23);
            this.CmdCopyByValue.TabIndex = 4;
            this.CmdCopyByValue.Text = "Copy by value";
            this.CmdCopyByValue.UseVisualStyleBackColor = true;
            this.CmdCopyByValue.Click += new System.EventHandler(this.CmdCopyByValue_Click);
            // 
            // CmdCopyByReference
            // 
            this.CmdCopyByReference.Location = new System.Drawing.Point(16, 103);
            this.CmdCopyByReference.Name = "CmdCopyByReference";
            this.CmdCopyByReference.Size = new System.Drawing.Size(139, 23);
            this.CmdCopyByReference.TabIndex = 5;
            this.CmdCopyByReference.Text = "Copy by reference";
            this.CmdCopyByReference.UseVisualStyleBackColor = true;
            this.CmdCopyByReference.Click += new System.EventHandler(this.CmdCopyByReference_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Wert der globalen Variable global2 nach Methodenaufruf:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Wert der globalen Variable global1 nach Methodenaufruf:";
            // 
            // LblValueGlobalVal2_2
            // 
            this.LblValueGlobalVal2_2.AutoSize = true;
            this.LblValueGlobalVal2_2.Location = new System.Drawing.Point(287, 175);
            this.LblValueGlobalVal2_2.Name = "LblValueGlobalVal2_2";
            this.LblValueGlobalVal2_2.Size = new System.Drawing.Size(16, 13);
            this.LblValueGlobalVal2_2.TabIndex = 8;
            this.LblValueGlobalVal2_2.Text = "...";
            // 
            // LblValueGlobalVal1_1
            // 
            this.LblValueGlobalVal1_1.AutoSize = true;
            this.LblValueGlobalVal1_1.Location = new System.Drawing.Point(287, 147);
            this.LblValueGlobalVal1_1.Name = "LblValueGlobalVal1_1";
            this.LblValueGlobalVal1_1.Size = new System.Drawing.Size(16, 13);
            this.LblValueGlobalVal1_1.TabIndex = 9;
            this.LblValueGlobalVal1_1.Text = "...";
            // 
            // CmdClear
            // 
            this.CmdClear.Location = new System.Drawing.Point(168, 74);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(112, 51);
            this.CmdClear.TabIndex = 10;
            this.CmdClear.Text = "Reset";
            this.CmdClear.UseVisualStyleBackColor = true;
            this.CmdClear.Click += new System.EventHandler(this.CmdClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 217);
            this.Controls.Add(this.CmdClear);
            this.Controls.Add(this.LblValueGlobalVal1_1);
            this.Controls.Add(this.LblValueGlobalVal2_2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmdCopyByReference);
            this.Controls.Add(this.CmdCopyByValue);
            this.Controls.Add(this.LblValueGlobalVal2);
            this.Controls.Add(this.LblValueGlobalVal1);
            this.Controls.Add(this.Lbl1);
            this.Controls.Add(this.Lbl2);
            this.Name = "Form1";
            this.Text = "Aufgabe_A10-1-5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.Label LblValueGlobalVal1;
        private System.Windows.Forms.Label LblValueGlobalVal2;
        private System.Windows.Forms.Button CmdCopyByValue;
        private System.Windows.Forms.Button CmdCopyByReference;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblValueGlobalVal2_2;
        private System.Windows.Forms.Label LblValueGlobalVal1_1;
        private System.Windows.Forms.Button CmdClear;
    }
}

