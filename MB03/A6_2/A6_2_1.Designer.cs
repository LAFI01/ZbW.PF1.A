namespace MB03.A6_2
{
    partial class A6_2_1
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
            this.TxtValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmdRandom = new System.Windows.Forms.Button();
            this.TxtShow = new System.Windows.Forms.TextBox();
            this.CmdStart = new System.Windows.Forms.Button();
            this.LblInfo = new System.Windows.Forms.Label();
            this.TxtCountLoops = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtValue
            // 
            this.TxtValue.Enabled = false;
            this.TxtValue.Location = new System.Drawing.Point(49, 11);
            this.TxtValue.Name = "TxtValue";
            this.TxtValue.Size = new System.Drawing.Size(146, 20);
            this.TxtValue.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zahl:";
            // 
            // CmdRandom
            // 
            this.CmdRandom.Location = new System.Drawing.Point(201, 10);
            this.CmdRandom.Name = "CmdRandom";
            this.CmdRandom.Size = new System.Drawing.Size(124, 23);
            this.CmdRandom.TabIndex = 2;
            this.CmdRandom.Text = "Generiere Zufallszahl";
            this.CmdRandom.UseVisualStyleBackColor = true;
            this.CmdRandom.Click += new System.EventHandler(this.CmdRandom_Click);
            // 
            // TxtShow
            // 
            this.TxtShow.Location = new System.Drawing.Point(12, 38);
            this.TxtShow.Multiline = true;
            this.TxtShow.Name = "TxtShow";
            this.TxtShow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtShow.Size = new System.Drawing.Size(395, 253);
            this.TxtShow.TabIndex = 3;
            // 
            // CmdStart
            // 
            this.CmdStart.Location = new System.Drawing.Point(332, 10);
            this.CmdStart.Name = "CmdStart";
            this.CmdStart.Size = new System.Drawing.Size(75, 23);
            this.CmdStart.TabIndex = 4;
            this.CmdStart.Text = "Start";
            this.CmdStart.UseVisualStyleBackColor = true;
            this.CmdStart.Click += new System.EventHandler(this.CmdStart_Click);
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.Location = new System.Drawing.Point(12, 298);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(164, 13);
            this.LblInfo.TabIndex = 5;
            this.LblInfo.Text = "Anzahl Schleifenwiederholungen:";
            // 
            // TxtCountLoops
            // 
            this.TxtCountLoops.Enabled = false;
            this.TxtCountLoops.Location = new System.Drawing.Point(182, 295);
            this.TxtCountLoops.Name = "TxtCountLoops";
            this.TxtCountLoops.Size = new System.Drawing.Size(100, 20);
            this.TxtCountLoops.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 331);
            this.Controls.Add(this.TxtCountLoops);
            this.Controls.Add(this.LblInfo);
            this.Controls.Add(this.CmdStart);
            this.Controls.Add(this.TxtShow);
            this.Controls.Add(this.CmdRandom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtValue);
            this.Name = "Form1";
            this.Text = "Aufgabe_A6-2-1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CmdRandom;
        private System.Windows.Forms.TextBox TxtShow;
        private System.Windows.Forms.Button CmdStart;
        private System.Windows.Forms.Label LblInfo;
        private System.Windows.Forms.TextBox TxtCountLoops;
    }
}

