namespace MB08.A12_1._4.View
{
    partial class A12_1_4
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
            this.components = new System.ComponentModel.Container();
            this.TxtHour = new System.Windows.Forms.TextBox();
            this.TxtMinute = new System.Windows.Forms.TextBox();
            this.LblHour = new System.Windows.Forms.Label();
            this.LblMinute = new System.Windows.Forms.Label();
            this.CmdTick = new System.Windows.Forms.Button();
            this.CmdStartTimer = new System.Windows.Forms.Button();
            this.TmrTick = new System.Windows.Forms.Timer(this.components);
            this.LblSeparator = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtHour
            // 
            this.TxtHour.Location = new System.Drawing.Point(49, 37);
            this.TxtHour.Name = "TxtHour";
            this.TxtHour.Size = new System.Drawing.Size(46, 20);
            this.TxtHour.TabIndex = 0;
            // 
            // TxtMinute
            // 
            this.TxtMinute.Location = new System.Drawing.Point(118, 37);
            this.TxtMinute.Name = "TxtMinute";
            this.TxtMinute.Size = new System.Drawing.Size(45, 20);
            this.TxtMinute.TabIndex = 1;
            // 
            // LblHour
            // 
            this.LblHour.AutoSize = true;
            this.LblHour.Location = new System.Drawing.Point(48, 21);
            this.LblHour.Name = "LblHour";
            this.LblHour.Size = new System.Drawing.Size(47, 13);
            this.LblHour.TabIndex = 2;
            this.LblHour.Text = "Stunden";
            // 
            // LblMinute
            // 
            this.LblMinute.AutoSize = true;
            this.LblMinute.Location = new System.Drawing.Point(115, 21);
            this.LblMinute.Name = "LblMinute";
            this.LblMinute.Size = new System.Drawing.Size(45, 13);
            this.LblMinute.TabIndex = 3;
            this.LblMinute.Text = "Minuten";
            // 
            // CmdTick
            // 
            this.CmdTick.Location = new System.Drawing.Point(53, 76);
            this.CmdTick.Name = "CmdTick";
            this.CmdTick.Size = new System.Drawing.Size(110, 23);
            this.CmdTick.TabIndex = 4;
            this.CmdTick.Text = "Schalten";
            this.CmdTick.UseVisualStyleBackColor = true;
            this.CmdTick.Click += new System.EventHandler(this.CmdTick_Click);
            // 
            // CmdStartTimer
            // 
            this.CmdStartTimer.Location = new System.Drawing.Point(53, 106);
            this.CmdStartTimer.Name = "CmdStartTimer";
            this.CmdStartTimer.Size = new System.Drawing.Size(110, 23);
            this.CmdStartTimer.TabIndex = 5;
            this.CmdStartTimer.Text = "Starte Automatik";
            this.CmdStartTimer.UseVisualStyleBackColor = true;
            this.CmdStartTimer.Click += new System.EventHandler(this.CmdStartTimer_Click);
            // 
            // TmrTick
            // 
            this.TmrTick.Interval = 1000;
            this.TmrTick.Tick += new System.EventHandler(this.CmdTick_Click);
            // 
            // LblSeparator
            // 
            this.LblSeparator.AutoSize = true;
            this.LblSeparator.Location = new System.Drawing.Point(101, 40);
            this.LblSeparator.Name = "LblSeparator";
            this.LblSeparator.Size = new System.Drawing.Size(10, 13);
            this.LblSeparator.TabIndex = 6;
            this.LblSeparator.Text = ":";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 144);
            this.Controls.Add(this.LblSeparator);
            this.Controls.Add(this.CmdStartTimer);
            this.Controls.Add(this.CmdTick);
            this.Controls.Add(this.LblMinute);
            this.Controls.Add(this.LblHour);
            this.Controls.Add(this.TxtMinute);
            this.Controls.Add(this.TxtHour);
            this.Name = "Form1";
            this.Text = "Aufgabe_A12-1-4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtHour;
        private System.Windows.Forms.TextBox TxtMinute;
        private System.Windows.Forms.Label LblHour;
        private System.Windows.Forms.Label LblMinute;
        private System.Windows.Forms.Button CmdTick;
        private System.Windows.Forms.Button CmdStartTimer;
        private System.Windows.Forms.Timer TmrTick;
        private System.Windows.Forms.Label LblSeparator;
    }
}

