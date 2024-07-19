namespace MB06.A11_1._4
{
    partial class A11_1_4
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
            this.Lbl1 = new System.Windows.Forms.Label();
            this.TxtbxProductName = new System.Windows.Forms.TextBox();
            this.TxtpurchasingPrice = new System.Windows.Forms.TextBox();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.TxtRetailPrice = new System.Windows.Forms.TextBox();
            this.Lbl3 = new System.Windows.Forms.Label();
            this.CmdSave = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LblProductCount = new System.Windows.Forms.Label();
            this.Lbl4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TxtProductList = new System.Windows.Forms.TextBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Location = new System.Drawing.Point(16, 22);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(70, 13);
            this.Lbl1.TabIndex = 0;
            this.Lbl1.Text = "Produktname";
            // 
            // TxtbxProductName
            // 
            this.TxtbxProductName.Location = new System.Drawing.Point(92, 19);
            this.TxtbxProductName.Name = "TxtbxProductName";
            this.TxtbxProductName.Size = new System.Drawing.Size(248, 20);
            this.TxtbxProductName.TabIndex = 1;
            // 
            // TxtpurchasingPrice
            // 
            this.TxtpurchasingPrice.Location = new System.Drawing.Point(92, 53);
            this.TxtpurchasingPrice.Name = "TxtpurchasingPrice";
            this.TxtpurchasingPrice.Size = new System.Drawing.Size(248, 20);
            this.TxtpurchasingPrice.TabIndex = 3;
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.Location = new System.Drawing.Point(16, 56);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(70, 13);
            this.Lbl2.TabIndex = 2;
            this.Lbl2.Text = "Einkaufspreis";
            // 
            // TxtRetailPrice
            // 
            this.TxtRetailPrice.Location = new System.Drawing.Point(92, 88);
            this.TxtRetailPrice.Name = "TxtRetailPrice";
            this.TxtRetailPrice.Size = new System.Drawing.Size(248, 20);
            this.TxtRetailPrice.TabIndex = 5;
            // 
            // Lbl3
            // 
            this.Lbl3.AutoSize = true;
            this.Lbl3.Location = new System.Drawing.Point(16, 91);
            this.Lbl3.Name = "Lbl3";
            this.Lbl3.Size = new System.Drawing.Size(71, 13);
            this.Lbl3.TabIndex = 4;
            this.Lbl3.Text = "Verkaufspreis";
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(92, 129);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(248, 23);
            this.CmdSave.TabIndex = 6;
            this.CmdSave.Text = "Speichern";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(372, 249);
            this.tabControl1.TabIndex = 7;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.ShowProducts);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LblProductCount);
            this.tabPage1.Controls.Add(this.Lbl4);
            this.tabPage1.Controls.Add(this.Lbl1);
            this.tabPage1.Controls.Add(this.CmdSave);
            this.tabPage1.Controls.Add(this.TxtbxProductName);
            this.tabPage1.Controls.Add(this.TxtRetailPrice);
            this.tabPage1.Controls.Add(this.Lbl2);
            this.tabPage1.Controls.Add(this.Lbl3);
            this.tabPage1.Controls.Add(this.TxtpurchasingPrice);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(364, 223);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Produkte erstellen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // LblProductCount
            // 
            this.LblProductCount.AutoSize = true;
            this.LblProductCount.Location = new System.Drawing.Point(140, 185);
            this.LblProductCount.Name = "LblProductCount";
            this.LblProductCount.Size = new System.Drawing.Size(13, 13);
            this.LblProductCount.TabIndex = 8;
            this.LblProductCount.Text = "0";
            // 
            // Lbl4
            // 
            this.Lbl4.AutoSize = true;
            this.Lbl4.Location = new System.Drawing.Point(19, 185);
            this.Lbl4.Name = "Lbl4";
            this.Lbl4.Size = new System.Drawing.Size(119, 13);
            this.Lbl4.TabIndex = 7;
            this.Lbl4.Text = "Gespeicherte Produkte:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TxtProductList);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(364, 223);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Produkte verwalten";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TxtProductList
            // 
            this.TxtProductList.Location = new System.Drawing.Point(16, 22);
            this.TxtProductList.Multiline = true;
            this.TxtProductList.Name = "TxtProductList";
            this.TxtProductList.Size = new System.Drawing.Size(333, 186);
            this.TxtProductList.TabIndex = 0;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(16, 9);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(165, 24);
            this.LblTitle.TabIndex = 8;
            this.LblTitle.Text = "Produktverwaltung";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 300);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Aufgabe_A11-1-4";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.TextBox TxtbxProductName;
        private System.Windows.Forms.TextBox TxtpurchasingPrice;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.TextBox TxtRetailPrice;
        private System.Windows.Forms.Label Lbl3;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblProductCount;
        private System.Windows.Forms.Label Lbl4;
        private System.Windows.Forms.TextBox TxtProductList;
    }
}

