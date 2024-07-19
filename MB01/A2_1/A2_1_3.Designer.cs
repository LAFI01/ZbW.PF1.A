namespace MB01.A2_1
{
    partial class A2_1_3
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
            this.LblValue1 = new System.Windows.Forms.Label();
            this.LblValue2 = new System.Windows.Forms.Label();
            this.TxtValue1 = new System.Windows.Forms.TextBox();
            this.TxtValue2 = new System.Windows.Forms.TextBox();
            this.CmdAdd = new System.Windows.Forms.Button();
            this.CmdSub = new System.Windows.Forms.Button();
            this.CmdMult = new System.Windows.Forms.Button();
            this.CmdDiv = new System.Windows.Forms.Button();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.LblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblValue1
            // 
            this.LblValue1.AutoSize = true;
            this.LblValue1.Location = new System.Drawing.Point(13, 13);
            this.LblValue1.Name = "LblValue1";
            this.LblValue1.Size = new System.Drawing.Size(40, 13);
            this.LblValue1.TabIndex = 0;
            this.LblValue1.Text = "Zahl 1:";
            // 
            // LblValue2
            // 
            this.LblValue2.AutoSize = true;
            this.LblValue2.Location = new System.Drawing.Point(13, 42);
            this.LblValue2.Name = "LblValue2";
            this.LblValue2.Size = new System.Drawing.Size(40, 13);
            this.LblValue2.TabIndex = 1;
            this.LblValue2.Text = "Zahl 2:";
            // 
            // TxtValue1
            // 
            this.TxtValue1.Location = new System.Drawing.Point(62, 10);
            this.TxtValue1.Name = "TxtValue1";
            this.TxtValue1.Size = new System.Drawing.Size(180, 20);
            this.TxtValue1.TabIndex = 2;
            // 
            // TxtValue2
            // 
            this.TxtValue2.Location = new System.Drawing.Point(63, 39);
            this.TxtValue2.Name = "TxtValue2";
            this.TxtValue2.Size = new System.Drawing.Size(179, 20);
            this.TxtValue2.TabIndex = 3;
            // 
            // CmdAdd
            // 
            this.CmdAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdAdd.Location = new System.Drawing.Point(16, 127);
            this.CmdAdd.Name = "CmdAdd";
            this.CmdAdd.Size = new System.Drawing.Size(40, 40);
            this.CmdAdd.TabIndex = 4;
            this.CmdAdd.Text = "+";
            this.CmdAdd.UseVisualStyleBackColor = true;
            this.CmdAdd.Click += new System.EventHandler(this.CmdAdd_Click);
            // 
            // CmdSub
            // 
            this.CmdSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdSub.Location = new System.Drawing.Point(78, 127);
            this.CmdSub.Name = "CmdSub";
            this.CmdSub.Size = new System.Drawing.Size(40, 40);
            this.CmdSub.TabIndex = 5;
            this.CmdSub.Text = "-";
            this.CmdSub.UseVisualStyleBackColor = true;
            this.CmdSub.Click += new System.EventHandler(this.CmdSub_Click);
            // 
            // CmdMult
            // 
            this.CmdMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdMult.Location = new System.Drawing.Point(140, 127);
            this.CmdMult.Name = "CmdMult";
            this.CmdMult.Size = new System.Drawing.Size(40, 40);
            this.CmdMult.TabIndex = 6;
            this.CmdMult.Text = "*";
            this.CmdMult.UseVisualStyleBackColor = true;
            this.CmdMult.Click += new System.EventHandler(this.CmdMult_Click);
            // 
            // CmdDiv
            // 
            this.CmdDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdDiv.Location = new System.Drawing.Point(202, 127);
            this.CmdDiv.Name = "CmdDiv";
            this.CmdDiv.Size = new System.Drawing.Size(40, 40);
            this.CmdDiv.TabIndex = 7;
            this.CmdDiv.Text = "/";
            this.CmdDiv.UseVisualStyleBackColor = true;
            this.CmdDiv.Click += new System.EventHandler(this.CmdDiv_Click);
            // 
            // TxtResult
            // 
            this.TxtResult.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.TxtResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtResult.Enabled = false;
            this.TxtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtResult.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtResult.Location = new System.Drawing.Point(63, 81);
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(179, 23);
            this.TxtResult.TabIndex = 8;
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Location = new System.Drawing.Point(14, 84);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(49, 13);
            this.LblResult.TabIndex = 9;
            this.LblResult.Text = "Resultat:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 197);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.CmdDiv);
            this.Controls.Add(this.CmdMult);
            this.Controls.Add(this.CmdSub);
            this.Controls.Add(this.CmdAdd);
            this.Controls.Add(this.TxtValue2);
            this.Controls.Add(this.TxtValue1);
            this.Controls.Add(this.LblValue2);
            this.Controls.Add(this.LblValue1);
            this.Name = "Form1";
            this.Text = "Einfacher Rechner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblValue1;
        private System.Windows.Forms.Label LblValue2;
        private System.Windows.Forms.TextBox TxtValue1;
        private System.Windows.Forms.TextBox TxtValue2;
        private System.Windows.Forms.Button CmdAdd;
        private System.Windows.Forms.Button CmdSub;
        private System.Windows.Forms.Button CmdMult;
        private System.Windows.Forms.Button CmdDiv;
        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.Label LblResult;
    }
}

