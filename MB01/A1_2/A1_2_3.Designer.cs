namespace MB01.A1_2
{
    partial class A1_2_3
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
            this.CmdRauf = new System.Windows.Forms.Button();
            this.CmdRunter = new System.Windows.Forms.Button();
            this.CmdLinks = new System.Windows.Forms.Button();
            this.CmdRechts = new System.Windows.Forms.Button();
            this.CmdPoint = new System.Windows.Forms.Button();
            this.CmdHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdRauf
            // 
            this.CmdRauf.Location = new System.Drawing.Point(123, 10);
            this.CmdRauf.Name = "CmdRauf";
            this.CmdRauf.Size = new System.Drawing.Size(50, 23);
            this.CmdRauf.TabIndex = 0;
            this.CmdRauf.Text = "rauf";
            this.CmdRauf.UseVisualStyleBackColor = true;
            this.CmdRauf.Click += new System.EventHandler(this.CmdRauf_Click);
            // 
            // CmdRunter
            // 
            this.CmdRunter.Location = new System.Drawing.Point(123, 68);
            this.CmdRunter.Name = "CmdRunter";
            this.CmdRunter.Size = new System.Drawing.Size(50, 23);
            this.CmdRunter.TabIndex = 1;
            this.CmdRunter.Text = "runter";
            this.CmdRunter.UseVisualStyleBackColor = true;
            this.CmdRunter.Click += new System.EventHandler(this.CmdRunter_Click);
            // 
            // CmdLinks
            // 
            this.CmdLinks.Location = new System.Drawing.Point(67, 39);
            this.CmdLinks.Name = "CmdLinks";
            this.CmdLinks.Size = new System.Drawing.Size(50, 23);
            this.CmdLinks.TabIndex = 2;
            this.CmdLinks.Text = "links";
            this.CmdLinks.UseVisualStyleBackColor = true;
            this.CmdLinks.Click += new System.EventHandler(this.CmdLinks_Click);
            // 
            // CmdRechts
            // 
            this.CmdRechts.Location = new System.Drawing.Point(179, 39);
            this.CmdRechts.Name = "CmdRechts";
            this.CmdRechts.Size = new System.Drawing.Size(50, 23);
            this.CmdRechts.TabIndex = 3;
            this.CmdRechts.Text = "rechts";
            this.CmdRechts.UseVisualStyleBackColor = true;
            this.CmdRechts.Click += new System.EventHandler(this.CmdRechts_Click);
            // 
            // CmdPoint
            // 
            this.CmdPoint.Enabled = false;
            this.CmdPoint.Location = new System.Drawing.Point(140, 230);
            this.CmdPoint.Name = "CmdPoint";
            this.CmdPoint.Size = new System.Drawing.Size(20, 20);
            this.CmdPoint.TabIndex = 4;
            this.CmdPoint.UseVisualStyleBackColor = true;
            // 
            // CmdHome
            // 
            this.CmdHome.Location = new System.Drawing.Point(123, 39);
            this.CmdHome.Name = "CmdHome";
            this.CmdHome.Size = new System.Drawing.Size(50, 23);
            this.CmdHome.TabIndex = 5;
            this.CmdHome.Text = "home";
            this.CmdHome.UseVisualStyleBackColor = true;
            this.CmdHome.Click += new System.EventHandler(this.CmdHome_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CmdHome);
            this.Controls.Add(this.CmdPoint);
            this.Controls.Add(this.CmdRechts);
            this.Controls.Add(this.CmdLinks);
            this.Controls.Add(this.CmdRunter);
            this.Controls.Add(this.CmdRauf);
            this.Name = "Form1";
            this.Text = "Aufgabe_A1-2-3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdRauf;
        private System.Windows.Forms.Button CmdRunter;
        private System.Windows.Forms.Button CmdLinks;
        private System.Windows.Forms.Button CmdRechts;
        private System.Windows.Forms.Button CmdPoint;
        private System.Windows.Forms.Button CmdHome;
    }
}

