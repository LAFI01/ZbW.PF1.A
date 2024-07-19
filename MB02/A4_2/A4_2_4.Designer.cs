namespace MB02.A4_2
{
    partial class A4_2_4
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
            this.LblOperation = new System.Windows.Forms.Label();
            this.TxtOperation = new System.Windows.Forms.TextBox();
            this.LblResult = new System.Windows.Forms.Label();
            this.TxTResult = new System.Windows.Forms.TextBox();
            this.CmdCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblValue1
            // 
            this.LblValue1.AutoSize = true;
            this.LblValue1.Location = new System.Drawing.Point(18, 18);
            this.LblValue1.Name = "LblValue1";
            this.LblValue1.Size = new System.Drawing.Size(46, 13);
            this.LblValue1.TabIndex = 0;
            this.LblValue1.Text = "1. Zahl: ";
            // 
            // LblValue2
            // 
            this.LblValue2.AutoSize = true;
            this.LblValue2.Location = new System.Drawing.Point(18, 54);
            this.LblValue2.Name = "LblValue2";
            this.LblValue2.Size = new System.Drawing.Size(46, 13);
            this.LblValue2.TabIndex = 1;
            this.LblValue2.Text = "2. Zahl: ";
            // 
            // TxtValue1
            // 
            this.TxtValue1.Location = new System.Drawing.Point(64, 16);
            this.TxtValue1.Name = "TxtValue1";
            this.TxtValue1.Size = new System.Drawing.Size(206, 20);
            this.TxtValue1.TabIndex = 2;
            // 
            // TxtValue2
            // 
            this.TxtValue2.Location = new System.Drawing.Point(64, 51);
            this.TxtValue2.Name = "TxtValue2";
            this.TxtValue2.Size = new System.Drawing.Size(206, 20);
            this.TxtValue2.TabIndex = 3;
            // 
            // LblOperation
            // 
            this.LblOperation.AutoSize = true;
            this.LblOperation.Location = new System.Drawing.Point(18, 87);
            this.LblOperation.Name = "LblOperation";
            this.LblOperation.Size = new System.Drawing.Size(164, 13);
            this.LblOperation.TabIndex = 4;
            this.LblOperation.Text = "Gewünschte Operation (+, -, *, /):";
            // 
            // TxtOperation
            // 
            this.TxtOperation.Location = new System.Drawing.Point(188, 84);
            this.TxtOperation.Name = "TxtOperation";
            this.TxtOperation.Size = new System.Drawing.Size(82, 20);
            this.TxtOperation.TabIndex = 5;
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Location = new System.Drawing.Point(18, 133);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(131, 13);
            this.LblResult.TabIndex = 6;
            this.LblResult.Text = "Resultat der Berechnung: ";
            // 
            // TxTResult
            // 
            this.TxTResult.BackColor = System.Drawing.Color.White;
            this.TxTResult.Enabled = false;
            this.TxTResult.Location = new System.Drawing.Point(21, 149);
            this.TxTResult.Name = "TxTResult";
            this.TxTResult.Size = new System.Drawing.Size(246, 20);
            this.TxTResult.TabIndex = 7;
            // 
            // CmdCalculate
            // 
            this.CmdCalculate.Location = new System.Drawing.Point(21, 185);
            this.CmdCalculate.Name = "CmdCalculate";
            this.CmdCalculate.Size = new System.Drawing.Size(246, 23);
            this.CmdCalculate.TabIndex = 8;
            this.CmdCalculate.Text = "Berechnung durchführen";
            this.CmdCalculate.UseVisualStyleBackColor = true;
            this.CmdCalculate.Click += new System.EventHandler(this.CmdCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 234);
            this.Controls.Add(this.CmdCalculate);
            this.Controls.Add(this.TxTResult);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.TxtOperation);
            this.Controls.Add(this.LblOperation);
            this.Controls.Add(this.TxtValue2);
            this.Controls.Add(this.TxtValue1);
            this.Controls.Add(this.LblValue2);
            this.Controls.Add(this.LblValue1);
            this.Name = "Form1";
            this.Text = "Aufgabe_A4-2-4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblValue1;
        private System.Windows.Forms.Label LblValue2;
        private System.Windows.Forms.TextBox TxtValue1;
        private System.Windows.Forms.TextBox TxtValue2;
        private System.Windows.Forms.Label LblOperation;
        private System.Windows.Forms.TextBox TxtOperation;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.TextBox TxTResult;
        private System.Windows.Forms.Button CmdCalculate;
    }
}

