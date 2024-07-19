namespace MB02.A5_1
{
    partial class A5_1_3
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
            this.PnlShelf = new System.Windows.Forms.Panel();
            this.PnlBall = new System.Windows.Forms.Panel();
            this.TrkbShelf = new System.Windows.Forms.TrackBar();
            this.TmrBall = new System.Windows.Forms.Timer(this.components);
            this.LblLives = new System.Windows.Forms.Label();
            this.LblPoints = new System.Windows.Forms.Label();
            this.LblGoal = new System.Windows.Forms.Label();
            this.CmdStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TrkbShelf)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlShelf
            // 
            this.PnlShelf.BackColor = System.Drawing.Color.Maroon;
            this.PnlShelf.Location = new System.Drawing.Point(220, 200);
            this.PnlShelf.Name = "PnlShelf";
            this.PnlShelf.Size = new System.Drawing.Size(16, 60);
            this.PnlShelf.TabIndex = 2;
            // 
            // PnlBall
            // 
            this.PnlBall.BackColor = System.Drawing.Color.SteelBlue;
            this.PnlBall.Location = new System.Drawing.Point(0, 240);
            this.PnlBall.Name = "PnlBall";
            this.PnlBall.Size = new System.Drawing.Size(20, 20);
            this.PnlBall.TabIndex = 1;
            // 
            // TrkbShelf
            // 
            this.TrkbShelf.Location = new System.Drawing.Point(239, 0);
            this.TrkbShelf.Maximum = 20;
            this.TrkbShelf.Name = "TrkbShelf";
            this.TrkbShelf.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrkbShelf.Size = new System.Drawing.Size(45, 261);
            this.TrkbShelf.TabIndex = 2;
            this.TrkbShelf.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TrkbShelf.Scroll += new System.EventHandler(this.TrkbShelf_Scroll);
            // 
            // TmrBall
            // 
            this.TmrBall.Interval = 30;
            this.TmrBall.Tick += new System.EventHandler(this.TmrBall_Tick);
            // 
            // LblLives
            // 
            this.LblLives.AutoSize = true;
            this.LblLives.Location = new System.Drawing.Point(12, 9);
            this.LblLives.Name = "LblLives";
            this.LblLives.Size = new System.Drawing.Size(43, 13);
            this.LblLives.TabIndex = 3;
            this.LblLives.Text = "Leben: ";
            // 
            // LblPoints
            // 
            this.LblPoints.AutoSize = true;
            this.LblPoints.Location = new System.Drawing.Point(61, 9);
            this.LblPoints.Name = "LblPoints";
            this.LblPoints.Size = new System.Drawing.Size(44, 13);
            this.LblPoints.TabIndex = 4;
            this.LblPoints.Text = "Punkte:";
            // 
            // LblGoal
            // 
            this.LblGoal.AutoSize = true;
            this.LblGoal.Location = new System.Drawing.Point(134, 9);
            this.LblGoal.Name = "LblGoal";
            this.LblGoal.Size = new System.Drawing.Size(30, 13);
            this.LblGoal.TabIndex = 5;
            this.LblGoal.Text = "Ziel: ";
            // 
            // CmdStart
            // 
            this.CmdStart.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.CmdStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmdStart.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.CmdStart.FlatAppearance.BorderSize = 0;
            this.CmdStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdStart.Location = new System.Drawing.Point(55, 81);
            this.CmdStart.Name = "CmdStart";
            this.CmdStart.Size = new System.Drawing.Size(161, 87);
            this.CmdStart.TabIndex = 6;
            this.CmdStart.Text = "Spiel starten!";
            this.CmdStart.UseVisualStyleBackColor = false;
            this.CmdStart.Click += new System.EventHandler(this.CmdStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CmdStart);
            this.Controls.Add(this.LblGoal);
            this.Controls.Add(this.LblPoints);
            this.Controls.Add(this.LblLives);
            this.Controls.Add(this.PnlShelf);
            this.Controls.Add(this.TrkbShelf);
            this.Controls.Add(this.PnlBall);
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aufgabe_A5-1-3";
            ((System.ComponentModel.ISupportInitialize)(this.TrkbShelf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlShelf;
        private System.Windows.Forms.Panel PnlBall;
        private System.Windows.Forms.TrackBar TrkbShelf;
        private System.Windows.Forms.Timer TmrBall;
        private System.Windows.Forms.Label LblLives;
        private System.Windows.Forms.Label LblPoints;
        private System.Windows.Forms.Label LblGoal;
        private System.Windows.Forms.Button CmdStart;
    }
}

