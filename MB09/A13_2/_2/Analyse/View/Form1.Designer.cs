namespace MB09.A13_2._2.Analyse.View
{
    partial class Form1
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
            this.TxtCDList.Location = new System.Drawing.Point(121, 24);
            this.TxtCDList.Multiline = true;
            this.TxtCDList.Name = "TxtCDList";
            this.TxtCDList.Size = new System.Drawing.Size(641, 194);
            this.TxtCDList.TabIndex = 0;
            // 
            // TxtDVDList
            // 
            this.TxtDVDList.Location = new System.Drawing.Point(121, 251);
            this.TxtDVDList.Multiline = true;
            this.TxtDVDList.Name = "TxtDVDList";
            this.TxtDVDList.Size = new System.Drawing.Size(641, 187);
            this.TxtDVDList.TabIndex = 1;
            // 
            // CmdShowCDs
            // 
            this.CmdShowCDs.Location = new System.Drawing.Point(40, 22);
            this.CmdShowCDs.Name = "CmdShowCDs";
            this.CmdShowCDs.Size = new System.Drawing.Size(75, 23);
            this.CmdShowCDs.TabIndex = 2;
            this.CmdShowCDs.Text = "Zeige CDs";
            this.CmdShowCDs.UseVisualStyleBackColor = true;
            this.CmdShowCDs.Click += new System.EventHandler(this.CmdShowCDs_Click);
            // 
            // CmdShowDVDs
            // 
            this.CmdShowDVDs.Location = new System.Drawing.Point(40, 251);
            this.CmdShowDVDs.Name = "CmdShowDVDs";
            this.CmdShowDVDs.Size = new System.Drawing.Size(75, 23);
            this.CmdShowDVDs.TabIndex = 3;
            this.CmdShowDVDs.Text = "ZeigeDVDs";
            this.CmdShowDVDs.UseVisualStyleBackColor = true;
            this.CmdShowDVDs.Click += new System.EventHandler(this.CmdShowDVDs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmdShowDVDs);
            this.Controls.Add(this.CmdShowCDs);
            this.Controls.Add(this.TxtDVDList);
            this.Controls.Add(this.TxtCDList);
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

