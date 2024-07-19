namespace MB02.A4_2
{
    partial class A4_2_3
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
            this.PnlGeometric = new System.Windows.Forms.Panel();
            this.LblComment = new System.Windows.Forms.Label();
            this.LblLength = new System.Windows.Forms.Label();
            this.LblHeight = new System.Windows.Forms.Label();
            this.CmdPaint = new System.Windows.Forms.Button();
            this.LblSquare = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblValue1
            // 
            this.LblValue1.AutoSize = true;
            this.LblValue1.Location = new System.Drawing.Point(13, 43);
            this.LblValue1.Name = "LblValue1";
            this.LblValue1.Size = new System.Drawing.Size(43, 13);
            this.LblValue1.TabIndex = 0;
            this.LblValue1.Text = "Länge: ";
            // 
            // LblValue2
            // 
            this.LblValue2.AutoSize = true;
            this.LblValue2.Location = new System.Drawing.Point(13, 84);
            this.LblValue2.Name = "LblValue2";
            this.LblValue2.Size = new System.Drawing.Size(40, 13);
            this.LblValue2.TabIndex = 1;
            this.LblValue2.Text = "Breite: ";
            // 
            // TxtValue1
            // 
            this.TxtValue1.Location = new System.Drawing.Point(62, 40);
            this.TxtValue1.Name = "TxtValue1";
            this.TxtValue1.Size = new System.Drawing.Size(100, 20);
            this.TxtValue1.TabIndex = 2;
            this.TxtValue1.Text = "200";
            // 
            // TxtValue2
            // 
            this.TxtValue2.Location = new System.Drawing.Point(62, 80);
            this.TxtValue2.Name = "TxtValue2";
            this.TxtValue2.Size = new System.Drawing.Size(100, 20);
            this.TxtValue2.TabIndex = 3;
            this.TxtValue2.Text = "100";
            // 
            // PnlGeometric
            // 
            this.PnlGeometric.BackColor = System.Drawing.Color.SkyBlue;
            this.PnlGeometric.Location = new System.Drawing.Point(240, 40);
            this.PnlGeometric.Name = "PnlGeometric";
            this.PnlGeometric.Size = new System.Drawing.Size(200, 100);
            this.PnlGeometric.TabIndex = 4;
            // 
            // LblComment
            // 
            this.LblComment.AutoSize = true;
            this.LblComment.Location = new System.Drawing.Point(13, 127);
            this.LblComment.Name = "LblComment";
            this.LblComment.Size = new System.Drawing.Size(178, 13);
            this.LblComment.TabIndex = 5;
            this.LblComment.Text = "Werte zwischen 50 und 200 erlaubt:";
            // 
            // LblLength
            // 
            this.LblLength.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblLength.Location = new System.Drawing.Point(315, 20);
            this.LblLength.MinimumSize = new System.Drawing.Size(50, 20);
            this.LblLength.Name = "LblLength";
            this.LblLength.Size = new System.Drawing.Size(50, 20);
            this.LblLength.TabIndex = 6;
            this.LblLength.Text = "200 cm";
            this.LblLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblHeight
            // 
            this.LblHeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblHeight.AutoSize = true;
            this.LblHeight.Location = new System.Drawing.Point(440, 80);
            this.LblHeight.MinimumSize = new System.Drawing.Size(40, 20);
            this.LblHeight.Name = "LblHeight";
            this.LblHeight.Size = new System.Drawing.Size(42, 20);
            this.LblHeight.TabIndex = 7;
            this.LblHeight.Text = "100 cm";
            this.LblHeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CmdPaint
            // 
            this.CmdPaint.Location = new System.Drawing.Point(62, 165);
            this.CmdPaint.Name = "CmdPaint";
            this.CmdPaint.Size = new System.Drawing.Size(100, 23);
            this.CmdPaint.TabIndex = 8;
            this.CmdPaint.Text = "Zeichne";
            this.CmdPaint.UseVisualStyleBackColor = true;
            this.CmdPaint.Click += new System.EventHandler(this.CmdPaint_Click);
            // 
            // LblSquare
            // 
            this.LblSquare.AutoSize = true;
            this.LblSquare.Location = new System.Drawing.Point(320, 147);
            this.LblSquare.MinimumSize = new System.Drawing.Size(50, 0);
            this.LblSquare.Name = "LblSquare";
            this.LblSquare.Size = new System.Drawing.Size(50, 13);
            this.LblSquare.TabIndex = 9;
            this.LblSquare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 266);
            this.Controls.Add(this.LblSquare);
            this.Controls.Add(this.CmdPaint);
            this.Controls.Add(this.LblHeight);
            this.Controls.Add(this.LblLength);
            this.Controls.Add(this.LblComment);
            this.Controls.Add(this.PnlGeometric);
            this.Controls.Add(this.TxtValue2);
            this.Controls.Add(this.TxtValue1);
            this.Controls.Add(this.LblValue2);
            this.Controls.Add(this.LblValue1);
            this.Name = "Form1";
            this.Text = "Aufgabe_A4-1-3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblValue1;
        private System.Windows.Forms.Label LblValue2;
        private System.Windows.Forms.TextBox TxtValue1;
        private System.Windows.Forms.TextBox TxtValue2;
        private System.Windows.Forms.Panel PnlGeometric;
        private System.Windows.Forms.Label LblComment;
        private System.Windows.Forms.Label LblLength;
        private System.Windows.Forms.Label LblHeight;
        private System.Windows.Forms.Button CmdPaint;
        private System.Windows.Forms.Label LblSquare;
    }
}

