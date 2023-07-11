namespace MB01.A1_2
{
    partial class A1_2_1
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
            this.CmdYellow = new System.Windows.Forms.Button();
            this.CmdRed = new System.Windows.Forms.Button();
            this.CmdGreen = new System.Windows.Forms.Button();
            this.CmdBlue = new System.Windows.Forms.Button();
            this.LblYellow = new System.Windows.Forms.Label();
            this.LblRed = new System.Windows.Forms.Label();
            this.LblGreen = new System.Windows.Forms.Label();
            this.LblBlue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdYellow
            // 
            this.CmdYellow.Location = new System.Drawing.Point(13, 13);
            this.CmdYellow.Name = "CmdYellow";
            this.CmdYellow.Size = new System.Drawing.Size(75, 23);
            this.CmdYellow.TabIndex = 0;
            this.CmdYellow.Text = "Gelb";
            this.CmdYellow.UseVisualStyleBackColor = true;
            this.CmdYellow.Click += new System.EventHandler(this.CmdYellow_Click);
            // 
            // CmdRed
            // 
            this.CmdRed.Location = new System.Drawing.Point(13, 43);
            this.CmdRed.Name = "CmdRed";
            this.CmdRed.Size = new System.Drawing.Size(75, 23);
            this.CmdRed.TabIndex = 1;
            this.CmdRed.Text = "Rot";
            this.CmdRed.UseVisualStyleBackColor = true;
            this.CmdRed.Click += new System.EventHandler(this.CmdRed_Click);
            // 
            // CmdGreen
            // 
            this.CmdGreen.Location = new System.Drawing.Point(13, 73);
            this.CmdGreen.Name = "CmdGreen";
            this.CmdGreen.Size = new System.Drawing.Size(75, 23);
            this.CmdGreen.TabIndex = 2;
            this.CmdGreen.Text = "Grün";
            this.CmdGreen.UseVisualStyleBackColor = true;
            this.CmdGreen.Click += new System.EventHandler(this.CmdGreen_Click);
            // 
            // CmdBlue
            // 
            this.CmdBlue.Location = new System.Drawing.Point(13, 103);
            this.CmdBlue.Name = "CmdBlue";
            this.CmdBlue.Size = new System.Drawing.Size(75, 23);
            this.CmdBlue.TabIndex = 3;
            this.CmdBlue.Text = "Blau";
            this.CmdBlue.UseVisualStyleBackColor = true;
            this.CmdBlue.Click += new System.EventHandler(this.CmdBlue_Click);
            // 
            // LblYellow
            // 
            this.LblYellow.AutoSize = true;
            this.LblYellow.Location = new System.Drawing.Point(147, 23);
            this.LblYellow.Name = "LblYellow";
            this.LblYellow.Size = new System.Drawing.Size(0, 13);
            this.LblYellow.TabIndex = 4;
            // 
            // LblRed
            // 
            this.LblRed.AutoSize = true;
            this.LblRed.Location = new System.Drawing.Point(147, 53);
            this.LblRed.Name = "LblRed";
            this.LblRed.Size = new System.Drawing.Size(0, 13);
            this.LblRed.TabIndex = 5;
            // 
            // LblGreen
            // 
            this.LblGreen.AutoSize = true;
            this.LblGreen.Location = new System.Drawing.Point(147, 83);
            this.LblGreen.Name = "LblGreen";
            this.LblGreen.Size = new System.Drawing.Size(0, 13);
            this.LblGreen.TabIndex = 6;
            // 
            // LblBlue
            // 
            this.LblBlue.AutoSize = true;
            this.LblBlue.Location = new System.Drawing.Point(146, 113);
            this.LblBlue.Name = "LblBlue";
            this.LblBlue.Size = new System.Drawing.Size(0, 13);
            this.LblBlue.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.LblBlue);
            this.Controls.Add(this.LblGreen);
            this.Controls.Add(this.LblRed);
            this.Controls.Add(this.LblYellow);
            this.Controls.Add(this.CmdBlue);
            this.Controls.Add(this.CmdGreen);
            this.Controls.Add(this.CmdRed);
            this.Controls.Add(this.CmdYellow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdYellow;
        private System.Windows.Forms.Button CmdRed;
        private System.Windows.Forms.Button CmdGreen;
        private System.Windows.Forms.Button CmdBlue;
        private System.Windows.Forms.Label LblYellow;
        private System.Windows.Forms.Label LblRed;
        private System.Windows.Forms.Label LblGreen;
        private System.Windows.Forms.Label LblBlue;
    }
}

