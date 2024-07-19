namespace MB04.A9_2
{
    partial class A9_2_2
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
            this.CmdNewValues = new System.Windows.Forms.Button();
            this.LblPosition = new System.Windows.Forms.Label();
            this.TxtPosition = new System.Windows.Forms.TextBox();
            this.CmdWriteValue = new System.Windows.Forms.Button();
            this.LblValue = new System.Windows.Forms.Label();
            this.TxtValue = new System.Windows.Forms.TextBox();
            this.LblArraySize = new System.Windows.Forms.Label();
            this.TxtArraySize = new System.Windows.Forms.TextBox();
            this.TxtHistory = new System.Windows.Forms.TextBox();
            this.LblHistory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdNewValues
            // 
            this.CmdNewValues.Location = new System.Drawing.Point(466, 13);
            this.CmdNewValues.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CmdNewValues.Name = "CmdNewValues";
            this.CmdNewValues.Size = new System.Drawing.Size(224, 44);
            this.CmdNewValues.TabIndex = 0;
            this.CmdNewValues.Text = "Daten generieren";
            this.CmdNewValues.UseVisualStyleBackColor = true;
            this.CmdNewValues.Click += new System.EventHandler(this.CmdNewValues_Click);
            // 
            // LblPosition
            // 
            this.LblPosition.AutoSize = true;
            this.LblPosition.Location = new System.Drawing.Point(26, 133);
            this.LblPosition.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblPosition.Name = "LblPosition";
            this.LblPosition.Size = new System.Drawing.Size(169, 25);
            this.LblPosition.TabIndex = 1;
            this.LblPosition.Text = "Position wählen:";
            // 
            // TxtPosition
            // 
            this.TxtPosition.Location = new System.Drawing.Point(250, 127);
            this.TxtPosition.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtPosition.Name = "TxtPosition";
            this.TxtPosition.Size = new System.Drawing.Size(104, 31);
            this.TxtPosition.TabIndex = 2;
            // 
            // CmdWriteValue
            // 
            this.CmdWriteValue.Location = new System.Drawing.Point(32, 177);
            this.CmdWriteValue.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CmdWriteValue.Name = "CmdWriteValue";
            this.CmdWriteValue.Size = new System.Drawing.Size(658, 44);
            this.CmdWriteValue.TabIndex = 3;
            this.CmdWriteValue.Text = "Wert der gewünschten Position auslesen";
            this.CmdWriteValue.UseVisualStyleBackColor = true;
            this.CmdWriteValue.Click += new System.EventHandler(this.CmdWriteValue_Click);
            // 
            // LblValue
            // 
            this.LblValue.AutoSize = true;
            this.LblValue.Location = new System.Drawing.Point(370, 133);
            this.LblValue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblValue.Name = "LblValue";
            this.LblValue.Size = new System.Drawing.Size(204, 25);
            this.LblValue.TabIndex = 4;
            this.LblValue.Text = "Gespeicherter Wert:";
            // 
            // TxtValue
            // 
            this.TxtValue.Location = new System.Drawing.Point(576, 127);
            this.TxtValue.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtValue.Name = "TxtValue";
            this.TxtValue.Size = new System.Drawing.Size(110, 31);
            this.TxtValue.TabIndex = 5;
            // 
            // LblArraySize
            // 
            this.LblArraySize.AutoSize = true;
            this.LblArraySize.Location = new System.Drawing.Point(26, 23);
            this.LblArraySize.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblArraySize.Name = "LblArraySize";
            this.LblArraySize.Size = new System.Drawing.Size(212, 25);
            this.LblArraySize.TabIndex = 6;
            this.LblArraySize.Text = "Gewünschte Grösse:";
            // 
            // TxtArraySize
            // 
            this.TxtArraySize.Location = new System.Drawing.Point(250, 17);
            this.TxtArraySize.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtArraySize.Name = "TxtArraySize";
            this.TxtArraySize.Size = new System.Drawing.Size(104, 31);
            this.TxtArraySize.TabIndex = 7;
            // 
            // TxtHistory
            // 
            this.TxtHistory.Location = new System.Drawing.Point(250, 281);
            this.TxtHistory.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtHistory.Multiline = true;
            this.TxtHistory.Name = "TxtHistory";
            this.TxtHistory.Size = new System.Drawing.Size(434, 200);
            this.TxtHistory.TabIndex = 8;
            // 
            // LblHistory
            // 
            this.LblHistory.AutoSize = true;
            this.LblHistory.Location = new System.Drawing.Point(26, 287);
            this.LblHistory.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblHistory.Name = "LblHistory";
            this.LblHistory.Size = new System.Drawing.Size(185, 25);
            this.LblHistory.TabIndex = 9;
            this.LblHistory.Text = "Erfolgte Abfragen:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 502);
            this.Controls.Add(this.LblHistory);
            this.Controls.Add(this.TxtHistory);
            this.Controls.Add(this.TxtArraySize);
            this.Controls.Add(this.LblArraySize);
            this.Controls.Add(this.TxtValue);
            this.Controls.Add(this.LblValue);
            this.Controls.Add(this.CmdWriteValue);
            this.Controls.Add(this.TxtPosition);
            this.Controls.Add(this.LblPosition);
            this.Controls.Add(this.CmdNewValues);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Aufgabe_A9-2-2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdNewValues;
        private System.Windows.Forms.Label LblPosition;
        private System.Windows.Forms.TextBox TxtPosition;
        private System.Windows.Forms.Button CmdWriteValue;
        private System.Windows.Forms.Label LblValue;
        private System.Windows.Forms.TextBox TxtValue;
        private System.Windows.Forms.Label LblArraySize;
        private System.Windows.Forms.TextBox TxtArraySize;
        private System.Windows.Forms.TextBox TxtHistory;
        private System.Windows.Forms.Label LblHistory;
    }
}

