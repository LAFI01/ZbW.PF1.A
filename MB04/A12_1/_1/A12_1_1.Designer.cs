namespace MB04.A12_1._1
{
    partial class A12_1_1
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
            this.TxtHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHour.Location = new System.Drawing.Point(56, 190);
            this.TxtHour.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtHour.Name = "TxtHour";
            this.TxtHour.Size = new System.Drawing.Size(366, 62);
            this.TxtHour.TabIndex = 0;
            // 
            // TxtMinute
            // 
            this.TxtMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMinute.Location = new System.Drawing.Point(558, 190);
            this.TxtMinute.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtMinute.Name = "TxtMinute";
            this.TxtMinute.Size = new System.Drawing.Size(366, 62);
            this.TxtMinute.TabIndex = 1;
            // 
            // LblHour
            // 
            this.LblHour.AutoSize = true;
            this.LblHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHour.Location = new System.Drawing.Point(46, 79);
            this.LblHour.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblHour.Name = "LblHour";
            this.LblHour.Size = new System.Drawing.Size(204, 55);
            this.LblHour.TabIndex = 2;
            this.LblHour.Text = "Stunden";
            // 
            // LblMinute
            // 
            this.LblMinute.AutoSize = true;
            this.LblMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMinute.Location = new System.Drawing.Point(548, 79);
            this.LblMinute.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblMinute.Name = "LblMinute";
            this.LblMinute.Size = new System.Drawing.Size(195, 55);
            this.LblMinute.TabIndex = 3;
            this.LblMinute.Text = "Minuten";
            // 
            // CmdTick
            // 
            this.CmdTick.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdTick.Location = new System.Drawing.Point(56, 392);
            this.CmdTick.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CmdTick.Name = "CmdTick";
            this.CmdTick.Size = new System.Drawing.Size(872, 140);
            this.CmdTick.TabIndex = 4;
            this.CmdTick.Text = "Schalten";
            this.CmdTick.UseVisualStyleBackColor = true;
            this.CmdTick.Click += new System.EventHandler(this.CmdTick_Click);
            // 
            // CmdStartTimer
            // 
            this.CmdStartTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdStartTimer.Location = new System.Drawing.Point(56, 598);
            this.CmdStartTimer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CmdStartTimer.Name = "CmdStartTimer";
            this.CmdStartTimer.Size = new System.Drawing.Size(872, 140);
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
            this.LblSeparator.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSeparator.Location = new System.Drawing.Point(474, 190);
            this.LblSeparator.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblSeparator.Name = "LblSeparator";
            this.LblSeparator.Size = new System.Drawing.Size(37, 55);
            this.LblSeparator.TabIndex = 6;
            this.LblSeparator.Text = ":";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 853);
            this.Controls.Add(this.LblSeparator);
            this.Controls.Add(this.CmdStartTimer);
            this.Controls.Add(this.CmdTick);
            this.Controls.Add(this.LblMinute);
            this.Controls.Add(this.LblHour);
            this.Controls.Add(this.TxtMinute);
            this.Controls.Add(this.TxtHour);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Aufgabe_A12-A1";
            this.Load += new System.EventHandler(this.Form1_Load);
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

