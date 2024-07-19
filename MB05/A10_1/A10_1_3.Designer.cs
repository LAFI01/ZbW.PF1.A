namespace MB05.A10_1
{
    partial class A10_1_3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtValue1 = new System.Windows.Forms.TextBox();
            this.TxtValue2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LblMax = new System.Windows.Forms.Label();
            this.CmdMax1 = new System.Windows.Forms.Button();
            this.TxtValue3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CmdMax2 = new System.Windows.Forms.Button();
            this.CmdMax3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bestimme Maximum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Erste Zahl:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Zweite Zahl:";
            // 
            // TxtValue1
            // 
            this.TxtValue1.Location = new System.Drawing.Point(102, 56);
            this.TxtValue1.Name = "TxtValue1";
            this.TxtValue1.Size = new System.Drawing.Size(128, 20);
            this.TxtValue1.TabIndex = 3;
            // 
            // TxtValue2
            // 
            this.TxtValue2.Location = new System.Drawing.Point(102, 87);
            this.TxtValue2.Name = "TxtValue2";
            this.TxtValue2.Size = new System.Drawing.Size(128, 20);
            this.TxtValue2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Maximum:";
            // 
            // LblMax
            // 
            this.LblMax.AutoSize = true;
            this.LblMax.Location = new System.Drawing.Point(99, 155);
            this.LblMax.Name = "LblMax";
            this.LblMax.Size = new System.Drawing.Size(16, 13);
            this.LblMax.TabIndex = 6;
            this.LblMax.Text = ",,,";
            // 
            // CmdMax1
            // 
            this.CmdMax1.Location = new System.Drawing.Point(18, 180);
            this.CmdMax1.Name = "CmdMax1";
            this.CmdMax1.Size = new System.Drawing.Size(212, 23);
            this.CmdMax1.TabIndex = 7;
            this.CmdMax1.Text = "Maximum 1. und 2. Zahl";
            this.CmdMax1.UseVisualStyleBackColor = true;
            this.CmdMax1.Click += new System.EventHandler(this.CmdMax1_Click);
            // 
            // TxtValue3
            // 
            this.TxtValue3.Location = new System.Drawing.Point(102, 118);
            this.TxtValue3.Name = "TxtValue3";
            this.TxtValue3.Size = new System.Drawing.Size(128, 20);
            this.TxtValue3.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dritte Zahl:";
            // 
            // CmdMax2
            // 
            this.CmdMax2.Location = new System.Drawing.Point(18, 209);
            this.CmdMax2.Name = "CmdMax2";
            this.CmdMax2.Size = new System.Drawing.Size(212, 23);
            this.CmdMax2.TabIndex = 10;
            this.CmdMax2.Text = "Maximum 2. und 3. Zahl";
            this.CmdMax2.UseVisualStyleBackColor = true;
            this.CmdMax2.Click += new System.EventHandler(this.CmdMax2_Click);
            // 
            // CmdMax3
            // 
            this.CmdMax3.Location = new System.Drawing.Point(18, 240);
            this.CmdMax3.Name = "CmdMax3";
            this.CmdMax3.Size = new System.Drawing.Size(212, 23);
            this.CmdMax3.TabIndex = 11;
            this.CmdMax3.Text = "Maximum 1. und 3. Zahl";
            this.CmdMax3.UseVisualStyleBackColor = true;
            this.CmdMax3.Click += new System.EventHandler(this.CmdMax3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 275);
            this.Controls.Add(this.CmdMax3);
            this.Controls.Add(this.CmdMax2);
            this.Controls.Add(this.TxtValue3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CmdMax1);
            this.Controls.Add(this.LblMax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtValue2);
            this.Controls.Add(this.TxtValue1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Aufgabe_10-1-1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtValue1;
        private System.Windows.Forms.TextBox TxtValue2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblMax;
        private System.Windows.Forms.Button CmdMax1;
        private System.Windows.Forms.TextBox TxtValue3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CmdMax2;
        private System.Windows.Forms.Button CmdMax3;
    }
}

