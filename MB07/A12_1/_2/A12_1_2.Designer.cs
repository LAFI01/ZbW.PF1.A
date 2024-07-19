namespace MB07.A12_1._2
{
    partial class A12_1_2
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
            this.Lbl1 = new System.Windows.Forms.Label();
            this.CmdA = new System.Windows.Forms.Button();
            this.CmdB = new System.Windows.Forms.Button();
            this.CmdC = new System.Windows.Forms.Button();
            this.CmdD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Location = new System.Drawing.Point(60, 69);
            this.Lbl1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(30, 25);
            this.Lbl1.TabIndex = 0;
            this.Lbl1.Text = "...";
            // 
            // CmdA
            // 
            this.CmdA.Location = new System.Drawing.Point(66, 137);
            this.CmdA.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CmdA.Name = "CmdA";
            this.CmdA.Size = new System.Drawing.Size(150, 44);
            this.CmdA.TabIndex = 1;
            this.CmdA.Text = "Aufgabe A";
            this.CmdA.UseVisualStyleBackColor = true;
            this.CmdA.Click += new System.EventHandler(this.ButtonEvents_Click);
            // 
            // CmdB
            // 
            this.CmdB.Location = new System.Drawing.Point(246, 137);
            this.CmdB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CmdB.Name = "CmdB";
            this.CmdB.Size = new System.Drawing.Size(150, 44);
            this.CmdB.TabIndex = 2;
            this.CmdB.Text = "Aufgabe B";
            this.CmdB.UseVisualStyleBackColor = true;
            this.CmdB.Click += new System.EventHandler(this.ButtonEvents_Click);
            // 
            // CmdC
            // 
            this.CmdC.Location = new System.Drawing.Point(66, 215);
            this.CmdC.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CmdC.Name = "CmdC";
            this.CmdC.Size = new System.Drawing.Size(150, 44);
            this.CmdC.TabIndex = 3;
            this.CmdC.Text = "Aufgabe C";
            this.CmdC.UseVisualStyleBackColor = true;
            this.CmdC.Click += new System.EventHandler(this.ButtonEvents_Click);
            // 
            // CmdD
            // 
            this.CmdD.Location = new System.Drawing.Point(246, 215);
            this.CmdD.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CmdD.Name = "CmdD";
            this.CmdD.Size = new System.Drawing.Size(150, 44);
            this.CmdD.TabIndex = 4;
            this.CmdD.Text = "Aufgabe D";
            this.CmdD.UseVisualStyleBackColor = true;
            this.CmdD.Click += new System.EventHandler(this.ButtonEvents_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 331);
            this.Controls.Add(this.CmdD);
            this.Controls.Add(this.CmdC);
            this.Controls.Add(this.CmdB);
            this.Controls.Add(this.CmdA);
            this.Controls.Add(this.Lbl1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Aufgabe_A12-1-1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.Button CmdA;
        private System.Windows.Forms.Button CmdB;
        private System.Windows.Forms.Button CmdC;
        private System.Windows.Forms.Button CmdD;
    }
}

