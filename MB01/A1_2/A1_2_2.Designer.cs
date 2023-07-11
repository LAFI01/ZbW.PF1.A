namespace MB01.A1_2 
{
    partial class A1_2_2
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
            this.Cmd1ner = new System.Windows.Forms.Button();
            this.Cmd2er = new System.Windows.Forms.Button();
            this.Cmd3er = new System.Windows.Forms.Button();
            this.LblPunkte = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cmd1ner
            // 
            this.Cmd1ner.Location = new System.Drawing.Point(13, 13);
            this.Cmd1ner.Name = "Cmd1ner";
            this.Cmd1ner.Size = new System.Drawing.Size(75, 23);
            this.Cmd1ner.TabIndex = 0;
            this.Cmd1ner.Text = "1ner";
            this.Cmd1ner.UseVisualStyleBackColor = true;
            this.Cmd1ner.Click += new System.EventHandler(this.Cmd1ner_Click);
            // 
            // Cmd2er
            // 
            this.Cmd2er.Location = new System.Drawing.Point(95, 12);
            this.Cmd2er.Name = "Cmd2er";
            this.Cmd2er.Size = new System.Drawing.Size(75, 23);
            this.Cmd2er.TabIndex = 1;
            this.Cmd2er.Text = "2er";
            this.Cmd2er.UseVisualStyleBackColor = true;
            this.Cmd2er.Click += new System.EventHandler(this.Cmd2er_Click);
            // 
            // Cmd3er
            // 
            this.Cmd3er.Location = new System.Drawing.Point(177, 12);
            this.Cmd3er.Name = "Cmd3er";
            this.Cmd3er.Size = new System.Drawing.Size(75, 23);
            this.Cmd3er.TabIndex = 2;
            this.Cmd3er.Text = "3er";
            this.Cmd3er.UseVisualStyleBackColor = true;
            this.Cmd3er.Click += new System.EventHandler(this.Cmd3er_Click);
            // 
            // LblPunkte
            // 
            this.LblPunkte.AutoSize = true;
            this.LblPunkte.Location = new System.Drawing.Point(13, 76);
            this.LblPunkte.Name = "LblPunkte";
            this.LblPunkte.Size = new System.Drawing.Size(10, 13);
            this.LblPunkte.TabIndex = 3;
            this.LblPunkte.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.LblPunkte);
            this.Controls.Add(this.Cmd3er);
            this.Controls.Add(this.Cmd2er);
            this.Controls.Add(this.Cmd1ner);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cmd1ner;
        private System.Windows.Forms.Button Cmd2er;
        private System.Windows.Forms.Button Cmd3er;
        private System.Windows.Forms.Label LblPunkte;
    }
}

