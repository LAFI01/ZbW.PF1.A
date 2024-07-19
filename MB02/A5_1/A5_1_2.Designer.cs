namespace MB02.A5_1
{
    partial class A5_1_2
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
            this.PnlAnim = new System.Windows.Forms.Panel();
            this.CmdStartStop = new System.Windows.Forms.Button();
            this.TrkbSpeed = new System.Windows.Forms.TrackBar();
            this.LblSpeed = new System.Windows.Forms.Label();
            this.TmrStep = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TrkbSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlAnim
            // 
            this.PnlAnim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PnlAnim.Location = new System.Drawing.Point(0, 200);
            this.PnlAnim.Name = "PnlAnim";
            this.PnlAnim.Size = new System.Drawing.Size(30, 30);
            this.PnlAnim.TabIndex = 0;
            // 
            // CmdStartStop
            // 
            this.CmdStartStop.Location = new System.Drawing.Point(12, 12);
            this.CmdStartStop.Name = "CmdStartStop";
            this.CmdStartStop.Size = new System.Drawing.Size(75, 23);
            this.CmdStartStop.TabIndex = 1;
            this.CmdStartStop.Text = "Start";
            this.CmdStartStop.UseVisualStyleBackColor = true;
            this.CmdStartStop.Click += new System.EventHandler(this.CmdStartStop_Click);
            // 
            // TrkbSpeed
            // 
            this.TrkbSpeed.LargeChange = 1;
            this.TrkbSpeed.Location = new System.Drawing.Point(12, 82);
            this.TrkbSpeed.Minimum = 1;
            this.TrkbSpeed.Name = "TrkbSpeed";
            this.TrkbSpeed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TrkbSpeed.Size = new System.Drawing.Size(260, 45);
            this.TrkbSpeed.TabIndex = 2;
            this.TrkbSpeed.Value = 1;
            this.TrkbSpeed.Scroll += new System.EventHandler(this.TrkbSpeed_Scroll);
            // 
            // LblSpeed
            // 
            this.LblSpeed.AutoSize = true;
            this.LblSpeed.Location = new System.Drawing.Point(13, 63);
            this.LblSpeed.Name = "LblSpeed";
            this.LblSpeed.Size = new System.Drawing.Size(85, 13);
            this.LblSpeed.TabIndex = 3;
            this.LblSpeed.Text = "Geschwindigkeit";
            // 
            // TmrStep
            // 
            this.TmrStep.Interval = 10;
            this.TmrStep.Tick += new System.EventHandler(this.TmrStep_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.LblSpeed);
            this.Controls.Add(this.TrkbSpeed);
            this.Controls.Add(this.CmdStartStop);
            this.Controls.Add(this.PnlAnim);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TrkbSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlAnim;
        private System.Windows.Forms.Button CmdStartStop;
        private System.Windows.Forms.TrackBar TrkbSpeed;
        private System.Windows.Forms.Label LblSpeed;
        private System.Windows.Forms.Timer TmrStep;
    }
}

