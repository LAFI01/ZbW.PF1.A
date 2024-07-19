namespace MB09.A13_1._1
{
    partial class A13_1_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtFirstname = new System.Windows.Forms.TextBox();
            this.TxtLastname = new System.Windows.Forms.TextBox();
            this.TxtAge = new System.Windows.Forms.TextBox();
            this.CmdCreate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtObjectCounter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vorname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nachname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alter:";
            // 
            // TxtFirstname
            // 
            this.TxtFirstname.Location = new System.Drawing.Point(182, 46);
            this.TxtFirstname.Name = "TxtFirstname";
            this.TxtFirstname.Size = new System.Drawing.Size(278, 31);
            this.TxtFirstname.TabIndex = 3;
            // 
            // TxtLastname
            // 
            this.TxtLastname.Location = new System.Drawing.Point(182, 102);
            this.TxtLastname.Name = "TxtLastname";
            this.TxtLastname.Size = new System.Drawing.Size(278, 31);
            this.TxtLastname.TabIndex = 4;
            // 
            // TxtAge
            // 
            this.TxtAge.Location = new System.Drawing.Point(182, 158);
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.Size = new System.Drawing.Size(278, 31);
            this.TxtAge.TabIndex = 5;
            // 
            // CmdCreate
            // 
            this.CmdCreate.Location = new System.Drawing.Point(501, 49);
            this.CmdCreate.Name = "CmdCreate";
            this.CmdCreate.Size = new System.Drawing.Size(258, 139);
            this.CmdCreate.TabIndex = 6;
            this.CmdCreate.Text = "Erzeuge neues Personen-Objekt";
            this.CmdCreate.UseVisualStyleBackColor = true;
            this.CmdCreate.Click += new System.EventHandler(this.CmdCreate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Anzahl erzeugter Objekte:";
            // 
            // TxtObjectCounter
            // 
            this.TxtObjectCounter.Location = new System.Drawing.Point(320, 258);
            this.TxtObjectCounter.Name = "TxtObjectCounter";
            this.TxtObjectCounter.Size = new System.Drawing.Size(140, 31);
            this.TxtObjectCounter.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 359);
            this.Controls.Add(this.TxtObjectCounter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmdCreate);
            this.Controls.Add(this.TxtAge);
            this.Controls.Add(this.TxtLastname);
            this.Controls.Add(this.TxtFirstname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Aufgabe_13-1-1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtFirstname;
        private System.Windows.Forms.TextBox TxtLastname;
        private System.Windows.Forms.TextBox TxtAge;
        private System.Windows.Forms.Button CmdCreate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtObjectCounter;
    }
}

