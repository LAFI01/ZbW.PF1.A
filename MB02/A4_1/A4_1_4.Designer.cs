namespace MB03.A4_1
{
    partial class A4_1_4
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
            LblValue1=new Label();
            LblValue2=new Label();
            TxtValue1=new TextBox();
            TxtValue2=new TextBox();
            LblResult=new Label();
            CmdCheck=new Button();
            SuspendLayout();
            // 
            // LblValue1
            // 
            LblValue1.AutoSize=true;
            LblValue1.Location=new Point(15, 15);
            LblValue1.Margin=new Padding(4, 0, 4, 0);
            LblValue1.Name="LblValue1";
            LblValue1.Size=new Size(44, 15);
            LblValue1.TabIndex=0;
            LblValue1.Text="Zahl A:";
            // 
            // LblValue2
            // 
            LblValue2.AutoSize=true;
            LblValue2.Location=new Point(15, 45);
            LblValue2.Margin=new Padding(4, 0, 4, 0);
            LblValue2.Name="LblValue2";
            LblValue2.Size=new Size(43, 15);
            LblValue2.TabIndex=1;
            LblValue2.Text="Zahl B:";
            // 
            // TxtValue1
            // 
            TxtValue1.Location=new Point(74, 15);
            TxtValue1.Margin=new Padding(4, 3, 4, 3);
            TxtValue1.Name="TxtValue1";
            TxtValue1.Size=new Size(188, 23);
            TxtValue1.TabIndex=2;
            // 
            // TxtValue2
            // 
            TxtValue2.Location=new Point(74, 46);
            TxtValue2.Margin=new Padding(4, 3, 4, 3);
            TxtValue2.Name="TxtValue2";
            TxtValue2.Size=new Size(188, 23);
            TxtValue2.TabIndex=3;
            // 
            // LblResult
            // 
            LblResult.AutoSize=true;
            LblResult.Location=new Point(70, 133);
            LblResult.Margin=new Padding(4, 0, 4, 0);
            LblResult.Name="LblResult";
            LblResult.Size=new Size(16, 15);
            LblResult.TabIndex=4;
            LblResult.Text="...";
            // 
            // CmdCheck
            // 
            CmdCheck.Location=new Point(74, 77);
            CmdCheck.Margin=new Padding(4, 3, 4, 3);
            CmdCheck.Name="CmdCheck";
            CmdCheck.Size=new Size(189, 27);
            CmdCheck.TabIndex=5;
            CmdCheck.Text="Bestimme grössere Zahl:";
            CmdCheck.UseVisualStyleBackColor=true;
            CmdCheck.Click+=CmdCheck_Click;
            // 
            // A4_1_4
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(331, 301);
            Controls.Add(CmdCheck);
            Controls.Add(LblResult);
            Controls.Add(TxtValue2);
            Controls.Add(TxtValue1);
            Controls.Add(LblValue2);
            Controls.Add(LblValue1);
            Margin=new Padding(4, 3, 4, 3);
            Name="A4_1_4";
            Text="Aufgabe_A4-1-4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblValue1;
        private Label LblValue2;
        private TextBox TxtValue1;
        private TextBox TxtValue2;
        private Label LblResult;
        private Button CmdCheck;
    }
}

