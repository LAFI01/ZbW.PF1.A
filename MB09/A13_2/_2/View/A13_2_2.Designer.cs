namespace MB09.A13_2._2.View
{
    partial class A13_2_2
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
            this.TxtCDList = new System.Windows.Forms.TextBox();
            this.TxtDVDList = new System.Windows.Forms.TextBox();
            this.CmdShowCDs = new System.Windows.Forms.Button();
            this.CmdShowDVDs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtCDList
            // 
            this.TxtCDList.Location = new System.Drawing.Point(242, 46);
            this.TxtCDList.Margin = new System.Windows.Forms.Padding(6);
            this.TxtCDList.Multiline = true;
            this.TxtCDList.Name = "TxtCDList";
            this.TxtCDList.Size = new System.Drawing.Size(1278, 369);
            this.TxtCDList.TabIndex = 0;
            // 
            // TxtDVDList
            // 
            this.TxtDVDList.Location = new System.Drawing.Point(242, 483);
            this.TxtDVDList.Margin = new System.Windows.Forms.Padding(6);
            this.TxtDVDList.Multiline = true;
            this.TxtDVDList.Name = "TxtDVDList";
            this.TxtDVDList.Size = new System.Drawing.Size(1278, 356);
            this.TxtDVDList.TabIndex = 1;
            // 
            // CmdShowCDs
            // 
            this.CmdShowCDs.Location = new System.Drawing.Point(80, 46);
            this.CmdShowCDs.Margin = new System.Windows.Forms.Padding(6);
            this.CmdShowCDs.Name = "CmdShowCDs";
            this.CmdShowCDs.Size = new System.Drawing.Size(150, 44);
            this.CmdShowCDs.TabIndex = 2;
            this.CmdShowCDs.Text = "Zeige CDs";
            this.CmdShowCDs.UseVisualStyleBackColor = true;
            this.CmdShowCDs.Click += new System.EventHandler(this.CmdShowCDs_Click);
            // 
            // CmdShowDVDs
            // 
            this.CmdShowDVDs.Location = new System.Drawing.Point(80, 483);
            this.CmdShowDVDs.Margin = new System.Windows.Forms.Padding(6);
            this.CmdShowDVDs.Name = "CmdShowDVDs";
            this.CmdShowDVDs.Size = new System.Drawing.Size(150, 44);
            this.CmdShowDVDs.TabIndex = 3;
            this.CmdShowDVDs.Text = "ZeigeDVDs";
            this.CmdShowDVDs.UseVisualStyleBackColor = true;
            this.CmdShowDVDs.Click += new System.EventHandler(this.CmdShowDVDs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1595, 919);
            this.Controls.Add(this.CmdShowDVDs);
            this.Controls.Add(this.CmdShowCDs);
            this.Controls.Add(this.TxtDVDList);
            this.Controls.Add(this.TxtCDList);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Aufgabe_A13-2-2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCDList;
        private System.Windows.Forms.TextBox TxtDVDList;
        private System.Windows.Forms.Button CmdShowCDs;
        private System.Windows.Forms.Button CmdShowDVDs;
    }
}

