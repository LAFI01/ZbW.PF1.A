namespace MB04.A9_2
{
    partial class A9_2_3
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
            this.CmdGenerateValues = new System.Windows.Forms.Button();
            this.TxtOriginalValues = new System.Windows.Forms.TextBox();
            this.CmdCopyValues = new System.Windows.Forms.Button();
            this.TxtCopyValues = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CmdGenerateValues
            // 
            this.CmdGenerateValues.Location = new System.Drawing.Point(13, 13);
            this.CmdGenerateValues.Name = "CmdGenerateValues";
            this.CmdGenerateValues.Size = new System.Drawing.Size(193, 23);
            this.CmdGenerateValues.TabIndex = 0;
            this.CmdGenerateValues.Text = "Generiere Zahlen für Array data";
            this.CmdGenerateValues.UseVisualStyleBackColor = true;
            this.CmdGenerateValues.Click += new System.EventHandler(this.CmdGenerateValues_Click);
            // 
            // TxtOriginalValues
            // 
            this.TxtOriginalValues.Location = new System.Drawing.Point(13, 52);
            this.TxtOriginalValues.Name = "TxtOriginalValues";
            this.TxtOriginalValues.Size = new System.Drawing.Size(259, 20);
            this.TxtOriginalValues.TabIndex = 1;
            // 
            // CmdCopyValues
            // 
            this.CmdCopyValues.Location = new System.Drawing.Point(12, 97);
            this.CmdCopyValues.Name = "CmdCopyValues";
            this.CmdCopyValues.Size = new System.Drawing.Size(194, 23);
            this.CmdCopyValues.TabIndex = 2;
            this.CmdCopyValues.Text = "Kopiere Zahlen in Array dataCopy";
            this.CmdCopyValues.UseVisualStyleBackColor = true;
            this.CmdCopyValues.Click += new System.EventHandler(this.CmdCopyValues_Click);
            // 
            // TxtCopyValues
            // 
            this.TxtCopyValues.Location = new System.Drawing.Point(12, 137);
            this.TxtCopyValues.Name = "TxtCopyValues";
            this.TxtCopyValues.Size = new System.Drawing.Size(259, 20);
            this.TxtCopyValues.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.TxtCopyValues);
            this.Controls.Add(this.CmdCopyValues);
            this.Controls.Add(this.TxtOriginalValues);
            this.Controls.Add(this.CmdGenerateValues);
            this.Name = "Form1";
            this.Text = "Aufgabe_A9-2-3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdGenerateValues;
        private System.Windows.Forms.TextBox TxtOriginalValues;
        private System.Windows.Forms.Button CmdCopyValues;
        private System.Windows.Forms.TextBox TxtCopyValues;
    }
}

