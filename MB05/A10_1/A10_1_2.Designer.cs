namespace MB05.A10_1
{
    partial class A10_1_2
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
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblText1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtValue = new System.Windows.Forms.TextBox();
            this.LblAnswer = new System.Windows.Forms.Label();
            this.LblCounter = new System.Windows.Forms.Label();
            this.CmdRestart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(13, 13);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(281, 44);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Zahlenratespiel";
            // 
            // LblText1
            // 
            this.LblText1.AutoSize = true;
            this.LblText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblText1.Location = new System.Drawing.Point(12, 91);
            this.LblText1.Name = "LblText1";
            this.LblText1.Size = new System.Drawing.Size(548, 31);
            this.LblText1.TabIndex = 1;
            this.LblText1.Text = "Ich denke mir eine Zahl zwischen 1 und 100!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wie lautet die Zahl?";
            // 
            // TxtValue
            // 
            this.TxtValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValue.Location = new System.Drawing.Point(286, 175);
            this.TxtValue.Name = "TxtValue";
            this.TxtValue.Size = new System.Drawing.Size(134, 38);
            this.TxtValue.TabIndex = 3;
            this.TxtValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValue_KeyPress);
            // 
            // LblAnswer
            // 
            this.LblAnswer.AutoSize = true;
            this.LblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAnswer.Location = new System.Drawing.Point(14, 144);
            this.LblAnswer.Name = "LblAnswer";
            this.LblAnswer.Size = new System.Drawing.Size(0, 31);
            this.LblAnswer.TabIndex = 4;
            // 
            // LblCounter
            // 
            this.LblCounter.AutoSize = true;
            this.LblCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCounter.Location = new System.Drawing.Point(443, 178);
            this.LblCounter.Name = "LblCounter";
            this.LblCounter.Size = new System.Drawing.Size(207, 31);
            this.LblCounter.TabIndex = 5;
            this.LblCounter.Text = "Dein 1. Versuch";
            // 
            // CmdRestart
            // 
            this.CmdRestart.BackColor = System.Drawing.Color.DarkOrange;
            this.CmdRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdRestart.ForeColor = System.Drawing.Color.White;
            this.CmdRestart.Location = new System.Drawing.Point(427, 248);
            this.CmdRestart.Name = "CmdRestart";
            this.CmdRestart.Size = new System.Drawing.Size(223, 122);
            this.CmdRestart.TabIndex = 6;
            this.CmdRestart.Text = "Neues Spiel?";
            this.CmdRestart.UseVisualStyleBackColor = false;
            this.CmdRestart.Visible = false;
            this.CmdRestart.Click += new System.EventHandler(this.CmdRestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 543);
            this.Controls.Add(this.CmdRestart);
            this.Controls.Add(this.LblCounter);
            this.Controls.Add(this.LblAnswer);
            this.Controls.Add(this.TxtValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblText1);
            this.Controls.Add(this.LblTitle);
            this.Name = "Form1";
            this.Text = "Aufgabe_10-1-2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblText1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtValue;
        private System.Windows.Forms.Label LblAnswer;
        private System.Windows.Forms.Label LblCounter;
        private System.Windows.Forms.Button CmdRestart;
    }
}

