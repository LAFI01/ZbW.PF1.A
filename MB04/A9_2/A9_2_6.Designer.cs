namespace MB04.A9_2
{
    partial class A9_2_6
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
            this.TxtCharacters = new System.Windows.Forms.TextBox();
            this.TxtVocals = new System.Windows.Forms.TextBox();
            this.TxtConsonants = new System.Windows.Forms.TextBox();
            this.LblCharakter = new System.Windows.Forms.Label();
            this.LblVocals = new System.Windows.Forms.Label();
            this.LblConsonant = new System.Windows.Forms.Label();
            this.CmdVocals = new System.Windows.Forms.Button();
            this.CmdConsonants = new System.Windows.Forms.Button();
            this.CmdGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtCharacters
            // 
            this.TxtCharacters.Location = new System.Drawing.Point(12, 34);
            this.TxtCharacters.Name = "TxtCharacters";
            this.TxtCharacters.Size = new System.Drawing.Size(260, 20);
            this.TxtCharacters.TabIndex = 0;
            // 
            // TxtVocals
            // 
            this.TxtVocals.Location = new System.Drawing.Point(12, 100);
            this.TxtVocals.Name = "TxtVocals";
            this.TxtVocals.Size = new System.Drawing.Size(260, 20);
            this.TxtVocals.TabIndex = 1;
            // 
            // TxtKonsonants
            // 
            this.TxtConsonants.Location = new System.Drawing.Point(12, 178);
            this.TxtConsonants.Name = "TxtKonsonants";
            this.TxtConsonants.Size = new System.Drawing.Size(260, 20);
            this.TxtConsonants.TabIndex = 2;
            // 
            // LblCharakter
            // 
            this.LblCharakter.AutoSize = true;
            this.LblCharakter.Location = new System.Drawing.Point(13, 13);
            this.LblCharakter.Name = "LblCharakter";
            this.LblCharakter.Size = new System.Drawing.Size(154, 13);
            this.LblCharakter.TabIndex = 3;
            this.LblCharakter.Text = "Zufällig generierte Buchstaben:";
            // 
            // LblVocals
            // 
            this.LblVocals.AutoSize = true;
            this.LblVocals.Location = new System.Drawing.Point(12, 84);
            this.LblVocals.Name = "LblVocals";
            this.LblVocals.Size = new System.Drawing.Size(43, 13);
            this.LblVocals.TabIndex = 4;
            this.LblVocals.Text = "Vokale:";
            // 
            // LblConsonant
            // 
            this.LblConsonant.AutoSize = true;
            this.LblConsonant.Location = new System.Drawing.Point(13, 162);
            this.LblConsonant.Name = "LblConsonant";
            this.LblConsonant.Size = new System.Drawing.Size(73, 13);
            this.LblConsonant.TabIndex = 5;
            this.LblConsonant.Text = "Konsonanten:";
            // 
            // CmdVocals
            // 
            this.CmdVocals.Location = new System.Drawing.Point(137, 126);
            this.CmdVocals.Name = "CmdVocals";
            this.CmdVocals.Size = new System.Drawing.Size(135, 23);
            this.CmdVocals.TabIndex = 6;
            this.CmdVocals.Text = "Bestimme Vokale";
            this.CmdVocals.UseVisualStyleBackColor = true;
            this.CmdVocals.Click += new System.EventHandler(this.CmdVocals_Click);
            // 
            // CmdConsonants
            // 
            this.CmdConsonants.Location = new System.Drawing.Point(137, 204);
            this.CmdConsonants.Name = "CmdConsonants";
            this.CmdConsonants.Size = new System.Drawing.Size(135, 23);
            this.CmdConsonants.TabIndex = 7;
            this.CmdConsonants.Text = "Bestimme Konsonanten";
            this.CmdConsonants.UseVisualStyleBackColor = true;
            this.CmdConsonants.Click += new System.EventHandler(this.CmdConsonants_Click);
            // 
            // CmdGenerate
            // 
            this.CmdGenerate.Location = new System.Drawing.Point(137, 61);
            this.CmdGenerate.Name = "CmdGenerate";
            this.CmdGenerate.Size = new System.Drawing.Size(134, 23);
            this.CmdGenerate.TabIndex = 8;
            this.CmdGenerate.Text = "Erzeuge Buchstaben";
            this.CmdGenerate.UseVisualStyleBackColor = true;
            this.CmdGenerate.Click += new System.EventHandler(this.CmdGenerate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CmdGenerate);
            this.Controls.Add(this.CmdConsonants);
            this.Controls.Add(this.CmdVocals);
            this.Controls.Add(this.LblConsonant);
            this.Controls.Add(this.LblVocals);
            this.Controls.Add(this.LblCharakter);
            this.Controls.Add(this.TxtConsonants);
            this.Controls.Add(this.TxtVocals);
            this.Controls.Add(this.TxtCharacters);
            this.Name = "Form1";
            this.Text = "Aufgabe_A9-2-6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCharacters;
        private System.Windows.Forms.TextBox TxtVocals;
        private System.Windows.Forms.TextBox TxtConsonants;
        private System.Windows.Forms.Label LblCharakter;
        private System.Windows.Forms.Label LblVocals;
        private System.Windows.Forms.Label LblConsonant;
        private System.Windows.Forms.Button CmdVocals;
        private System.Windows.Forms.Button CmdConsonants;
        private System.Windows.Forms.Button CmdGenerate;
    }
}

