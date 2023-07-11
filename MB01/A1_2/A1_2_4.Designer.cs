namespace MB01.A1_2
{
    partial class A1_2_4
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
            this.CmdFhVergr = new System.Windows.Forms.Button();
            this.CmdFhVerkl = new System.Windows.Forms.Button();
            this.CmdFbVergr = new System.Windows.Forms.Button();
            this.CmdFbVerkl = new System.Windows.Forms.Button();
            this.LblPosition = new System.Windows.Forms.Label();
            this.LblDimension = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdFhVergr
            // 
            this.CmdFhVergr.Location = new System.Drawing.Point(29, 63);
            this.CmdFhVergr.Name = "CmdFhVergr";
            this.CmdFhVergr.Size = new System.Drawing.Size(222, 23);
            this.CmdFhVergr.TabIndex = 0;
            this.CmdFhVergr.Text = "Fensterhöhe vergrössern";
            this.CmdFhVergr.UseVisualStyleBackColor = true;
            this.CmdFhVergr.Click += new System.EventHandler(this.CmdFhVergr_Click);
            // 
            // CmdFhVerkl
            // 
            this.CmdFhVerkl.Location = new System.Drawing.Point(29, 92);
            this.CmdFhVerkl.Name = "CmdFhVerkl";
            this.CmdFhVerkl.Size = new System.Drawing.Size(222, 23);
            this.CmdFhVerkl.TabIndex = 1;
            this.CmdFhVerkl.Text = "Fensterhöhe verkleinern";
            this.CmdFhVerkl.UseVisualStyleBackColor = true;
            this.CmdFhVerkl.Click += new System.EventHandler(this.CmdFhVerkl_Click);
            // 
            // CmdFbVergr
            // 
            this.CmdFbVergr.Location = new System.Drawing.Point(29, 121);
            this.CmdFbVergr.Name = "CmdFbVergr";
            this.CmdFbVergr.Size = new System.Drawing.Size(222, 23);
            this.CmdFbVergr.TabIndex = 2;
            this.CmdFbVergr.Text = "Fensterbreite vergrössern";
            this.CmdFbVergr.UseVisualStyleBackColor = true;
            this.CmdFbVergr.Click += new System.EventHandler(this.CmdFbVergr_Click);
            // 
            // CmdFbVerkl
            // 
            this.CmdFbVerkl.Location = new System.Drawing.Point(29, 150);
            this.CmdFbVerkl.Name = "CmdFbVerkl";
            this.CmdFbVerkl.Size = new System.Drawing.Size(222, 23);
            this.CmdFbVerkl.TabIndex = 3;
            this.CmdFbVerkl.Text = "Fensterbreite verkleinern";
            this.CmdFbVerkl.UseVisualStyleBackColor = true;
            this.CmdFbVerkl.Click += new System.EventHandler(this.CmdFbVerkl_Click);
            // 
            // LblPosition
            // 
            this.LblPosition.AutoSize = true;
            this.LblPosition.Location = new System.Drawing.Point(13, 236);
            this.LblPosition.Name = "LblPosition";
            this.LblPosition.Size = new System.Drawing.Size(47, 13);
            this.LblPosition.TabIndex = 4;
            this.LblPosition.Text = "Position:";
            // 
            // LblDimension
            // 
            this.LblDimension.AutoSize = true;
            this.LblDimension.Location = new System.Drawing.Point(150, 236);
            this.LblDimension.Name = "LblDimension";
            this.LblDimension.Size = new System.Drawing.Size(59, 13);
            this.LblDimension.TabIndex = 5;
            this.LblDimension.Text = "Dimension:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.LblDimension);
            this.Controls.Add(this.LblPosition);
            this.Controls.Add(this.CmdFbVerkl);
            this.Controls.Add(this.CmdFbVergr);
            this.Controls.Add(this.CmdFhVerkl);
            this.Controls.Add(this.CmdFhVergr);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aufgabe_A1-2-4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdFhVergr;
        private System.Windows.Forms.Button CmdFhVerkl;
        private System.Windows.Forms.Button CmdFbVergr;
        private System.Windows.Forms.Button CmdFbVerkl;
        private System.Windows.Forms.Label LblPosition;
        private System.Windows.Forms.Label LblDimension;
    }
}

