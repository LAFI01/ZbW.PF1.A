namespace MB01.A8_2
{
    partial class A8_2_1
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
            this.GrpMath = new System.Windows.Forms.GroupBox();
            this.RadbDiv = new System.Windows.Forms.RadioButton();
            this.RadbMul = new System.Windows.Forms.RadioButton();
            this.RadbSub = new System.Windows.Forms.RadioButton();
            this.RadbAdd = new System.Windows.Forms.RadioButton();
            this.LblResult = new System.Windows.Forms.Label();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.CmdCalculate = new System.Windows.Forms.Button();
            this.GrpMath.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblValue1
            // 
            this.LblValue1.AutoSize = true;
            this.LblValue1.Location = new System.Drawing.Point(13, 16);
            this.LblValue1.Name = "LblValue1";
            this.LblValue1.Size = new System.Drawing.Size(43, 13);
            this.LblValue1.TabIndex = 0;
            this.LblValue1.Text = "1. Zahl:";
            // 
            // LblValue2
            // 
            this.LblValue2.AutoSize = true;
            this.LblValue2.Location = new System.Drawing.Point(13, 45);
            this.LblValue2.Name = "LblValue2";
            this.LblValue2.Size = new System.Drawing.Size(43, 13);
            this.LblValue2.TabIndex = 1;
            this.LblValue2.Text = "2. Zahl:";
            // 
            // TxtValue1
            // 
            this.TxtValue1.Location = new System.Drawing.Point(63, 13);
            this.TxtValue1.Name = "TxtValue1";
            this.TxtValue1.Size = new System.Drawing.Size(162, 20);
            this.TxtValue1.TabIndex = 2;
            // 
            // TxtValue2
            // 
            this.TxtValue2.Location = new System.Drawing.Point(63, 39);
            this.TxtValue2.Name = "TxtValue2";
            this.TxtValue2.Size = new System.Drawing.Size(162, 20);
            this.TxtValue2.TabIndex = 3;
            // 
            // GrpMath
            // 
            this.GrpMath.Controls.Add(this.RadbDiv);
            this.GrpMath.Controls.Add(this.RadbMul);
            this.GrpMath.Controls.Add(this.RadbSub);
            this.GrpMath.Controls.Add(this.RadbAdd);
            this.GrpMath.Location = new System.Drawing.Point(16, 88);
            this.GrpMath.Name = "GrpMath";
            this.GrpMath.Size = new System.Drawing.Size(209, 67);
            this.GrpMath.TabIndex = 4;
            this.GrpMath.TabStop = false;
            this.GrpMath.Text = "Mathematische Operationen";
            // 
            // RadbDiv
            // 
            this.RadbDiv.AutoSize = true;
            this.RadbDiv.Location = new System.Drawing.Point(173, 31);
            this.RadbDiv.Name = "RadbDiv";
            this.RadbDiv.Size = new System.Drawing.Size(30, 17);
            this.RadbDiv.TabIndex = 3;
            this.RadbDiv.TabStop = true;
            this.RadbDiv.Text = "/";
            this.RadbDiv.UseVisualStyleBackColor = true;
            // 
            // RadbMul
            // 
            this.RadbMul.AutoSize = true;
            this.RadbMul.Location = new System.Drawing.Point(118, 31);
            this.RadbMul.Name = "RadbMul";
            this.RadbMul.Size = new System.Drawing.Size(29, 17);
            this.RadbMul.TabIndex = 2;
            this.RadbMul.TabStop = true;
            this.RadbMul.Text = "*";
            this.RadbMul.UseVisualStyleBackColor = true;
            // 
            // RadbSub
            // 
            this.RadbSub.AutoSize = true;
            this.RadbSub.Location = new System.Drawing.Point(64, 31);
            this.RadbSub.Name = "RadbSub";
            this.RadbSub.Size = new System.Drawing.Size(28, 17);
            this.RadbSub.TabIndex = 1;
            this.RadbSub.TabStop = true;
            this.RadbSub.Text = "-";
            this.RadbSub.UseVisualStyleBackColor = true;
            // 
            // RadbAdd
            // 
            this.RadbAdd.AutoSize = true;
            this.RadbAdd.Location = new System.Drawing.Point(7, 31);
            this.RadbAdd.Name = "RadbAdd";
            this.RadbAdd.Size = new System.Drawing.Size(31, 17);
            this.RadbAdd.TabIndex = 0;
            this.RadbAdd.TabStop = true;
            this.RadbAdd.Text = "+";
            this.RadbAdd.UseVisualStyleBackColor = true;
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Location = new System.Drawing.Point(13, 169);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(49, 13);
            this.LblResult.TabIndex = 5;
            this.LblResult.Text = "Resultat:";
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(69, 166);
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(156, 20);
            this.TxtResult.TabIndex = 6;
            // 
            // CmdCalculate
            // 
            this.CmdCalculate.Location = new System.Drawing.Point(16, 202);
            this.CmdCalculate.Name = "CmdCalculate";
            this.CmdCalculate.Size = new System.Drawing.Size(209, 23);
            this.CmdCalculate.TabIndex = 7;
            this.CmdCalculate.Text = "Berechne";
            this.CmdCalculate.UseVisualStyleBackColor = true;
            this.CmdCalculate.Click += new System.EventHandler(this.CmdCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 264);
            this.Controls.Add(this.CmdCalculate);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.GrpMath);
            this.Controls.Add(this.TxtValue2);
            this.Controls.Add(this.TxtValue1);
            this.Controls.Add(this.LblValue2);
            this.Controls.Add(this.LblValue1);
            this.Name = "Form1";
            this.Text = "Aufgabe_A8-2-1";
            this.GrpMath.ResumeLayout(false);
            this.GrpMath.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblValue1;
        private System.Windows.Forms.Label LblValue2;
        private System.Windows.Forms.TextBox TxtValue1;
        private System.Windows.Forms.TextBox TxtValue2;
        private System.Windows.Forms.GroupBox GrpMath;
        private System.Windows.Forms.RadioButton RadbDiv;
        private System.Windows.Forms.RadioButton RadbMul;
        private System.Windows.Forms.RadioButton RadbSub;
        private System.Windows.Forms.RadioButton RadbAdd;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.Button CmdCalculate;
    }
}

