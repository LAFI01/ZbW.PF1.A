namespace MB02.A4_2
{
    partial class A4_2_2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.PnlGreen = new System.Windows.Forms.Panel();
            this.PnlOrange = new System.Windows.Forms.Panel();
            this.PnlRed = new System.Windows.Forms.Panel();
            this.CmdStep = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.PnlGreen);
            this.panel1.Controls.Add(this.PnlOrange);
            this.panel1.Controls.Add(this.PnlRed);
            this.panel1.Location = new System.Drawing.Point(65, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(88, 148);
            this.panel1.TabIndex = 0;
            // 
            // PnlGreen
            // 
            this.PnlGreen.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PnlGreen.Location = new System.Drawing.Point(26, 94);
            this.PnlGreen.Name = "PnlGreen";
            this.PnlGreen.Size = new System.Drawing.Size(35, 35);
            this.PnlGreen.TabIndex = 1;
            // 
            // PnlOrange
            // 
            this.PnlOrange.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PnlOrange.Location = new System.Drawing.Point(26, 53);
            this.PnlOrange.Name = "PnlOrange";
            this.PnlOrange.Size = new System.Drawing.Size(35, 35);
            this.PnlOrange.TabIndex = 1;
            // 
            // PnlRed
            // 
            this.PnlRed.BackColor = System.Drawing.Color.Red;
            this.PnlRed.Location = new System.Drawing.Point(26, 12);
            this.PnlRed.Name = "PnlRed";
            this.PnlRed.Size = new System.Drawing.Size(35, 35);
            this.PnlRed.TabIndex = 0;
            this.PnlRed.Tag = "";
            // 
            // CmdStep
            // 
            this.CmdStep.Location = new System.Drawing.Point(65, 189);
            this.CmdStep.Name = "CmdStep";
            this.CmdStep.Size = new System.Drawing.Size(88, 42);
            this.CmdStep.TabIndex = 1;
            this.CmdStep.Text = "Schalten";
            this.CmdStep.UseVisualStyleBackColor = true;
            this.CmdStep.Click += new System.EventHandler(this.CmdStep_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 276);
            this.Controls.Add(this.CmdStep);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Aufgabe_A4-1-2";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PnlGreen;
        private System.Windows.Forms.Panel PnlOrange;
        private System.Windows.Forms.Panel PnlRed;
        private System.Windows.Forms.Button CmdStep;
    }
}

