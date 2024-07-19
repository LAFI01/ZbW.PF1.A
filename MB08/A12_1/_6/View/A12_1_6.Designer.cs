namespace MB08.A12_1._6
{
    partial class A12_1_6
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
            this.LstStudents = new System.Windows.Forms.ListBox();
            this.GrpFunctions = new System.Windows.Forms.GroupBox();
            this.CmdStudentDetails = new System.Windows.Forms.Button();
            this.CmdBestStudent = new System.Windows.Forms.Button();
            this.GrpFunctions.SuspendLayout();
            this.SuspendLayout();
            // 
            // LstStudents
            // 
            this.LstStudents.FormattingEnabled = true;
            this.LstStudents.HorizontalScrollbar = true;
            this.LstStudents.ItemHeight = 25;
            this.LstStudents.Location = new System.Drawing.Point(24, 83);
            this.LstStudents.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.LstStudents.Name = "LstStudents";
            this.LstStudents.ScrollAlwaysVisible = true;
            this.LstStudents.Size = new System.Drawing.Size(592, 554);
            this.LstStudents.TabIndex = 0;
            // 
            // GrpFunctions
            // 
            this.GrpFunctions.Controls.Add(this.CmdBestStudent);
            this.GrpFunctions.Controls.Add(this.CmdStudentDetails);
            this.GrpFunctions.Location = new System.Drawing.Point(640, 77);
            this.GrpFunctions.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.GrpFunctions.Name = "GrpFunctions";
            this.GrpFunctions.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.GrpFunctions.Size = new System.Drawing.Size(262, 562);
            this.GrpFunctions.TabIndex = 1;
            this.GrpFunctions.TabStop = false;
            this.GrpFunctions.Text = "Funktionen";
            // 
            // CmdStudentDetails
            // 
            this.CmdStudentDetails.Location = new System.Drawing.Point(12, 37);
            this.CmdStudentDetails.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CmdStudentDetails.Name = "CmdStudentDetails";
            this.CmdStudentDetails.Size = new System.Drawing.Size(238, 44);
            this.CmdStudentDetails.TabIndex = 0;
            this.CmdStudentDetails.Text = "Zeige Fächer von";
            this.CmdStudentDetails.UseVisualStyleBackColor = true;
            this.CmdStudentDetails.Click += new System.EventHandler(this.CmdStudentDetails_Click);
            // 
            // CmdBestStudent
            // 
            this.CmdBestStudent.Location = new System.Drawing.Point(12, 91);
            this.CmdBestStudent.Name = "CmdBestStudent";
            this.CmdBestStudent.Size = new System.Drawing.Size(238, 44);
            this.CmdBestStudent.TabIndex = 1;
            this.CmdBestStudent.Text = "Bester Student";
            this.CmdBestStudent.UseVisualStyleBackColor = true;
            this.CmdBestStudent.Click += new System.EventHandler(this.CmdBestStudent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 663);
            this.Controls.Add(this.GrpFunctions);
            this.Controls.Add(this.LstStudents);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Aufgabe_A12-1-6";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GrpFunctions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LstStudents;
        private System.Windows.Forms.GroupBox GrpFunctions;
        private System.Windows.Forms.Button CmdStudentDetails;
        private System.Windows.Forms.Button CmdBestStudent;
    }
}

