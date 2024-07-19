namespace MB02.A5_1
{
    partial class A5_1_1
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
            this.Trk1 = new System.Windows.Forms.TrackBar();
            this.Trk2 = new System.Windows.Forms.TrackBar();
            this.Trk3 = new System.Windows.Forms.TrackBar();
            this.PnlColor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.LblRgb = new System.Windows.Forms.Label();
            this.ChkRed = new System.Windows.Forms.CheckBox();
            this.ChkGreen = new System.Windows.Forms.CheckBox();
            this.ChkBlue = new System.Windows.Forms.CheckBox();
            this.RadHex = new System.Windows.Forms.RadioButton();
            this.RadDezimal = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Trk1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trk2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trk3)).BeginInit();
            this.SuspendLayout();
            // 
            // Trk1
            // 
            this.Trk1.Location = new System.Drawing.Point(48, 12);
            this.Trk1.Maximum = 255;
            this.Trk1.Name = "Trk1";
            this.Trk1.Size = new System.Drawing.Size(260, 45);
            this.Trk1.TabIndex = 0;
            this.Trk1.Scroll += new System.EventHandler(this.Color_Scroll);
            // 
            // Trk2
            // 
            this.Trk2.Location = new System.Drawing.Point(48, 63);
            this.Trk2.Maximum = 255;
            this.Trk2.Name = "Trk2";
            this.Trk2.Size = new System.Drawing.Size(260, 45);
            this.Trk2.TabIndex = 1;
            this.Trk2.Scroll += new System.EventHandler(this.Color_Scroll);
            // 
            // Trk3
            // 
            this.Trk3.Location = new System.Drawing.Point(48, 114);
            this.Trk3.Maximum = 255;
            this.Trk3.Name = "Trk3";
            this.Trk3.Size = new System.Drawing.Size(260, 45);
            this.Trk3.TabIndex = 2;
            this.Trk3.Scroll += new System.EventHandler(this.Color_Scroll);
            // 
            // PnlColor
            // 
            this.PnlColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PnlColor.Location = new System.Drawing.Point(60, 174);
            this.PnlColor.Name = "PnlColor";
            this.PnlColor.Size = new System.Drawing.Size(270, 87);
            this.PnlColor.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rot:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Grün:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Blau:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "128";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "255";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "255";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(172, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "128";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(283, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "255";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(172, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "128";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(57, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "0";
            // 
            // LblRgb
            // 
            this.LblRgb.AutoSize = true;
            this.LblRgb.Location = new System.Drawing.Point(57, 264);
            this.LblRgb.Name = "LblRgb";
            this.LblRgb.Size = new System.Drawing.Size(50, 13);
            this.LblRgb.TabIndex = 16;
            this.LblRgb.Text = "#000000";
            // 
            // ChkRed
            // 
            this.ChkRed.AutoSize = true;
            this.ChkRed.Checked = true;
            this.ChkRed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkRed.Location = new System.Drawing.Point(314, 21);
            this.ChkRed.Name = "ChkRed";
            this.ChkRed.Size = new System.Drawing.Size(15, 14);
            this.ChkRed.TabIndex = 17;
            this.ChkRed.UseVisualStyleBackColor = true;
            this.ChkRed.CheckedChanged += new System.EventHandler(this.ChkRed_CheckedChanged);
            // 
            // ChkGreen
            // 
            this.ChkGreen.AutoSize = true;
            this.ChkGreen.Checked = true;
            this.ChkGreen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkGreen.Location = new System.Drawing.Point(315, 73);
            this.ChkGreen.Name = "ChkGreen";
            this.ChkGreen.Size = new System.Drawing.Size(15, 14);
            this.ChkGreen.TabIndex = 18;
            this.ChkGreen.UseVisualStyleBackColor = true;
            this.ChkGreen.CheckedChanged += new System.EventHandler(this.ChkGreen_CheckedChanged);
            // 
            // ChkBlue
            // 
            this.ChkBlue.AutoSize = true;
            this.ChkBlue.Checked = true;
            this.ChkBlue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkBlue.Location = new System.Drawing.Point(315, 125);
            this.ChkBlue.Name = "ChkBlue";
            this.ChkBlue.Size = new System.Drawing.Size(15, 14);
            this.ChkBlue.TabIndex = 19;
            this.ChkBlue.UseVisualStyleBackColor = true;
            this.ChkBlue.CheckedChanged += new System.EventHandler(this.ChkBlue_CheckedChanged);
            // 
            // RadHex
            // 
            this.RadHex.AutoSize = true;
            this.RadHex.Checked = true;
            this.RadHex.Location = new System.Drawing.Point(60, 295);
            this.RadHex.Name = "RadHex";
            this.RadHex.Size = new System.Drawing.Size(85, 17);
            this.RadHex.TabIndex = 20;
            this.RadHex.TabStop = true;
            this.RadHex.Text = "Hexadezimal";
            this.RadHex.UseVisualStyleBackColor = true;
            this.RadHex.CheckedChanged += new System.EventHandler(this.Color_Scroll);
            // 
            // RadDezimal
            // 
            this.RadDezimal.AutoSize = true;
            this.RadDezimal.Location = new System.Drawing.Point(151, 295);
            this.RadDezimal.Name = "RadDezimal";
            this.RadDezimal.Size = new System.Drawing.Size(62, 17);
            this.RadDezimal.TabIndex = 21;
            this.RadDezimal.Text = "Dezimal";
            this.RadDezimal.UseVisualStyleBackColor = true;
            this.RadDezimal.CheckedChanged += new System.EventHandler(this.Color_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 324);
            this.Controls.Add(this.RadDezimal);
            this.Controls.Add(this.RadHex);
            this.Controls.Add(this.ChkBlue);
            this.Controls.Add(this.ChkGreen);
            this.Controls.Add(this.ChkRed);
            this.Controls.Add(this.LblRgb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PnlColor);
            this.Controls.Add(this.Trk3);
            this.Controls.Add(this.Trk2);
            this.Controls.Add(this.Trk1);
            this.Name = "Form1";
            this.Text = "Aufgabe_A5-1-1";
            ((System.ComponentModel.ISupportInitialize)(this.Trk1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trk2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trk3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar Trk1;
        private System.Windows.Forms.TrackBar Trk2;
        private System.Windows.Forms.TrackBar Trk3;
        private System.Windows.Forms.Panel PnlColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label LblRgb;
        private System.Windows.Forms.CheckBox ChkRed;
        private System.Windows.Forms.CheckBox ChkGreen;
        private System.Windows.Forms.CheckBox ChkBlue;
        private System.Windows.Forms.RadioButton RadHex;
        private System.Windows.Forms.RadioButton RadDezimal;
    }
}

