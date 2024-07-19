namespace MB08.A12_1._5.View
{
    partial class A12_1_5
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
            this.LblSeparator1 = new System.Windows.Forms.Label();
            this.TxtSecond = new System.Windows.Forms.TextBox();
            this.LblSeconds = new System.Windows.Forms.Label();
            this.LblSeparator2 = new System.Windows.Forms.Label();
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
            this.TxtMinute.Location = new System.Drawing.Point(115, 37);
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
            this.CmdTick.Location = new System.Drawing.Point(49, 76);
            this.CmdTick.Name = "CmdTick";
            this.CmdTick.Size = new System.Drawing.Size(176, 23);
            this.CmdTick.TabIndex = 4;
            this.CmdTick.Text = "Schalten";
            this.CmdTick.UseVisualStyleBackColor = true;
            this.CmdTick.Click += new System.EventHandler(this.CmdTick_Click);
            // 
            // CmdStartTimer
            // 
            this.CmdStartTimer.Location = new System.Drawing.Point(49, 106);
            this.CmdStartTimer.Name = "CmdStartTimer";
            this.CmdStartTimer.Size = new System.Drawing.Size(176, 23);
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
            // LblSeparator1
            // 
            this.LblSeparator1.AutoSize = true;
            this.LblSeparator1.Location = new System.Drawing.Point(100, 40);
            this.LblSeparator1.Name = "LblSeparator1";
            this.LblSeparator1.Size = new System.Drawing.Size(10, 13);
            this.LblSeparator1.TabIndex = 6;
            this.LblSeparator1.Text = ":";
            // 
            // TxtSecond
            // 
            this.TxtSecond.Location = new System.Drawing.Point(180, 37);
            this.TxtSecond.Name = "TxtSecond";
            this.TxtSecond.Size = new System.Drawing.Size(45, 20);
            this.TxtSecond.TabIndex = 7;
            // 
            // LblSeconds
            // 
            this.LblSeconds.AutoSize = true;
            this.LblSeconds.Location = new System.Drawing.Point(177, 21);
            this.LblSeconds.Name = "LblSeconds";
            this.LblSeconds.Size = new System.Drawing.Size(56, 13);
            this.LblSeconds.TabIndex = 8;
            this.LblSeconds.Text = "Sekunden";
            // 
            // LblSeparator2
            // 
            this.LblSeparator2.AutoSize = true;
            this.LblSeparator2.Location = new System.Drawing.Point(165, 40);
            this.LblSeparator2.Name = "LblSeparator2";
            this.LblSeparator2.Size = new System.Drawing.Size(10, 13);
            this.LblSeparator2.TabIndex = 9;
            this.LblSeparator2.Text = ":";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 146);
            this.Controls.Add(this.LblSeparator2);
            this.Controls.Add(this.LblSeconds);
            this.Controls.Add(this.TxtSecond);
            this.Controls.Add(this.LblSeparator1);
            this.Controls.Add(this.CmdStartTimer);
            this.Controls.Add(this.CmdTick);
            this.Controls.Add(this.LblMinute);
            this.Controls.Add(this.LblHour);
            this.Controls.Add(this.TxtMinute);
            this.Controls.Add(this.TxtHour);
            this.Name = "Form1";
            this.Text = "Aufgabe_A12-1-5";
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
        private System.Windows.Forms.Label LblSeparator1;
        private System.Windows.Forms.TextBox TxtSecond;
        private System.Windows.Forms.Label LblSeconds;
        private System.Windows.Forms.Label LblSeparator2;
    }
}

