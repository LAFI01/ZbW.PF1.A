namespace MB09.A13_2._1
{
    partial class A13_2_1
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
            this.CmdPerson = new System.Windows.Forms.Button();
            this.CmdCustomer = new System.Windows.Forms.Button();
            this.CmdEmployee = new System.Windows.Forms.Button();
            this.CmdLead = new System.Windows.Forms.Button();
            this.CmdTrainee = new System.Windows.Forms.Button();
            this.LblPerson = new System.Windows.Forms.Label();
            this.LblCustomer = new System.Windows.Forms.Label();
            this.LblEmployee = new System.Windows.Forms.Label();
            this.LblLead = new System.Windows.Forms.Label();
            this.LblTrainee = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdPerson
            // 
            this.CmdPerson.Location = new System.Drawing.Point(24, 47);
            this.CmdPerson.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmdPerson.Name = "CmdPerson";
            this.CmdPerson.Size = new System.Drawing.Size(118, 29);
            this.CmdPerson.TabIndex = 0;
            this.CmdPerson.Text = "Erzeuge Person";
            this.CmdPerson.UseVisualStyleBackColor = true;
            this.CmdPerson.Click += new System.EventHandler(this.Cmd1_Click);
            // 
            // CmdCustomer
            // 
            this.CmdCustomer.Location = new System.Drawing.Point(24, 97);
            this.CmdCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmdCustomer.Name = "CmdCustomer";
            this.CmdCustomer.Size = new System.Drawing.Size(118, 29);
            this.CmdCustomer.TabIndex = 1;
            this.CmdCustomer.Text = "Erzeuge Kunde";
            this.CmdCustomer.UseVisualStyleBackColor = true;
            this.CmdCustomer.Click += new System.EventHandler(this.CmdCustomer_Click);
            // 
            // CmdEmployee
            // 
            this.CmdEmployee.Location = new System.Drawing.Point(24, 146);
            this.CmdEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmdEmployee.Name = "CmdEmployee";
            this.CmdEmployee.Size = new System.Drawing.Size(118, 29);
            this.CmdEmployee.TabIndex = 2;
            this.CmdEmployee.Text = "Erzeuge Mitarbeiter";
            this.CmdEmployee.UseVisualStyleBackColor = true;
            this.CmdEmployee.Click += new System.EventHandler(this.CmdEmployee_Click);
            // 
            // CmdLead
            // 
            this.CmdLead.Location = new System.Drawing.Point(24, 193);
            this.CmdLead.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmdLead.Name = "CmdLead";
            this.CmdLead.Size = new System.Drawing.Size(118, 29);
            this.CmdLead.TabIndex = 3;
            this.CmdLead.Text = "Erzeuge Vorgesetzter";
            this.CmdLead.UseVisualStyleBackColor = true;
            this.CmdLead.Click += new System.EventHandler(this.CmdLead_Click);
            // 
            // CmdTrainee
            // 
            this.CmdTrainee.Location = new System.Drawing.Point(24, 242);
            this.CmdTrainee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmdTrainee.Name = "CmdTrainee";
            this.CmdTrainee.Size = new System.Drawing.Size(118, 29);
            this.CmdTrainee.TabIndex = 4;
            this.CmdTrainee.Text = "Erzeuge Lernender";
            this.CmdTrainee.UseVisualStyleBackColor = true;
            this.CmdTrainee.Click += new System.EventHandler(this.CmdTrainee_Click);
            // 
            // LblPerson
            // 
            this.LblPerson.AutoSize = true;
            this.LblPerson.Location = new System.Drawing.Point(156, 55);
            this.LblPerson.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPerson.Name = "LblPerson";
            this.LblPerson.Size = new System.Drawing.Size(16, 13);
            this.LblPerson.TabIndex = 5;
            this.LblPerson.Text = "...";
            // 
            // LblCustomer
            // 
            this.LblCustomer.AutoSize = true;
            this.LblCustomer.Location = new System.Drawing.Point(156, 105);
            this.LblCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCustomer.Name = "LblCustomer";
            this.LblCustomer.Size = new System.Drawing.Size(16, 13);
            this.LblCustomer.TabIndex = 6;
            this.LblCustomer.Text = "...";
            // 
            // LblEmployee
            // 
            this.LblEmployee.AutoSize = true;
            this.LblEmployee.Location = new System.Drawing.Point(156, 154);
            this.LblEmployee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblEmployee.Name = "LblEmployee";
            this.LblEmployee.Size = new System.Drawing.Size(16, 13);
            this.LblEmployee.TabIndex = 7;
            this.LblEmployee.Text = "...";
            // 
            // LblLead
            // 
            this.LblLead.AutoSize = true;
            this.LblLead.Location = new System.Drawing.Point(156, 201);
            this.LblLead.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblLead.Name = "LblLead";
            this.LblLead.Size = new System.Drawing.Size(16, 13);
            this.LblLead.TabIndex = 8;
            this.LblLead.Text = "...";
            // 
            // LblTrainee
            // 
            this.LblTrainee.AutoSize = true;
            this.LblTrainee.Location = new System.Drawing.Point(156, 250);
            this.LblTrainee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTrainee.Name = "LblTrainee";
            this.LblTrainee.Size = new System.Drawing.Size(16, 13);
            this.LblTrainee.TabIndex = 9;
            this.LblTrainee.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 316);
            this.Controls.Add(this.LblTrainee);
            this.Controls.Add(this.LblLead);
            this.Controls.Add(this.LblEmployee);
            this.Controls.Add(this.LblCustomer);
            this.Controls.Add(this.LblPerson);
            this.Controls.Add(this.CmdTrainee);
            this.Controls.Add(this.CmdLead);
            this.Controls.Add(this.CmdEmployee);
            this.Controls.Add(this.CmdCustomer);
            this.Controls.Add(this.CmdPerson);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Aufgabe_A13-2-1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdPerson;
        private System.Windows.Forms.Button CmdCustomer;
        private System.Windows.Forms.Button CmdEmployee;
        private System.Windows.Forms.Button CmdLead;
        private System.Windows.Forms.Button CmdTrainee;
        private System.Windows.Forms.Label LblPerson;
        private System.Windows.Forms.Label LblCustomer;
        private System.Windows.Forms.Label LblEmployee;
        private System.Windows.Forms.Label LblLead;
        private System.Windows.Forms.Label LblTrainee;
    }
}

