namespace MB06.A11_1._1
{
    partial class A11_1_1
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
            this.CmdCreateP1 = new System.Windows.Forms.Button();
            this.CmdCreateP2 = new System.Windows.Forms.Button();
            this.CmdCreateP3 = new System.Windows.Forms.Button();
            this.TxtOutputArea = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CmdCreateP1
            // 
            this.CmdCreateP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdCreateP1.Location = new System.Drawing.Point(12, 33);
            this.CmdCreateP1.Name = "CmdCreateP1";
            this.CmdCreateP1.Size = new System.Drawing.Size(546, 92);
            this.CmdCreateP1.TabIndex = 0;
            this.CmdCreateP1.Text = "Erzeuge erste Person";
            this.CmdCreateP1.UseVisualStyleBackColor = true;
            this.CmdCreateP1.Click += new System.EventHandler(this.CmdCreateP1_Click);
            // 
            // CmdCreateP2
            // 
            this.CmdCreateP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdCreateP2.Location = new System.Drawing.Point(12, 143);
            this.CmdCreateP2.Name = "CmdCreateP2";
            this.CmdCreateP2.Size = new System.Drawing.Size(546, 90);
            this.CmdCreateP2.TabIndex = 1;
            this.CmdCreateP2.Text = "Erzeuge zweite Person";
            this.CmdCreateP2.UseVisualStyleBackColor = true;
            this.CmdCreateP2.Click += new System.EventHandler(this.CmdCreateP2_Click);
            // 
            // CmdCreateP3
            // 
            this.CmdCreateP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdCreateP3.Location = new System.Drawing.Point(12, 255);
            this.CmdCreateP3.Name = "CmdCreateP3";
            this.CmdCreateP3.Size = new System.Drawing.Size(546, 102);
            this.CmdCreateP3.TabIndex = 2;
            this.CmdCreateP3.Text = "Erzeuge dritte Person";
            this.CmdCreateP3.UseVisualStyleBackColor = true;
            this.CmdCreateP3.Click += new System.EventHandler(this.CmdCreateP3_Click);
            // 
            // TxtOutputArea
            // 
            this.TxtOutputArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOutputArea.Location = new System.Drawing.Point(12, 379);
            this.TxtOutputArea.Multiline = true;
            this.TxtOutputArea.Name = "TxtOutputArea";
            this.TxtOutputArea.Size = new System.Drawing.Size(867, 302);
            this.TxtOutputArea.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 698);
            this.Controls.Add(this.TxtOutputArea);
            this.Controls.Add(this.CmdCreateP3);
            this.Controls.Add(this.CmdCreateP2);
            this.Controls.Add(this.CmdCreateP1);
            this.Name = "Form1";
            this.Text = "Aufgabe_A11-1-1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdCreateP1;
        private System.Windows.Forms.Button CmdCreateP2;
        private System.Windows.Forms.Button CmdCreateP3;
        private System.Windows.Forms.TextBox TxtOutputArea;
    }
}

