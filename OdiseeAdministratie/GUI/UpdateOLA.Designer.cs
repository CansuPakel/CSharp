namespace GUI
{
    partial class UpdateOLA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NudStudiepunten = new System.Windows.Forms.NumericUpDown();
            this.CmbOPO = new System.Windows.Forms.ComboBox();
            this.CmbDocent = new System.Windows.Forms.ComboBox();
            this.TxtCode = new System.Windows.Forms.TextBox();
            this.TxtNaam = new System.Windows.Forms.TextBox();
            this.BtnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NudStudiepunten)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "naam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 140);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "studiepunten";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "OPO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "docent";
            // 
            // NudStudiepunten
            // 
            this.NudStudiepunten.Location = new System.Drawing.Point(172, 140);
            this.NudStudiepunten.Name = "NudStudiepunten";
            this.NudStudiepunten.Size = new System.Drawing.Size(170, 20);
            this.NudStudiepunten.TabIndex = 5;
            // 
            // CmbOPO
            // 
            this.CmbOPO.FormattingEnabled = true;
            this.CmbOPO.Location = new System.Drawing.Point(172, 183);
            this.CmbOPO.Name = "CmbOPO";
            this.CmbOPO.Size = new System.Drawing.Size(170, 21);
            this.CmbOPO.TabIndex = 6;
            // 
            // CmbDocent
            // 
            this.CmbDocent.FormattingEnabled = true;
            this.CmbDocent.Location = new System.Drawing.Point(172, 240);
            this.CmbDocent.Name = "CmbDocent";
            this.CmbDocent.Size = new System.Drawing.Size(170, 21);
            this.CmbDocent.TabIndex = 7;
            // 
            // TxtCode
            // 
            this.TxtCode.Location = new System.Drawing.Point(172, 24);
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.Size = new System.Drawing.Size(170, 20);
            this.TxtCode.TabIndex = 8;
            // 
            // TxtNaam
            // 
            this.TxtNaam.Location = new System.Drawing.Point(172, 83);
            this.TxtNaam.Name = "TxtNaam";
            this.TxtNaam.Size = new System.Drawing.Size(170, 20);
            this.TxtNaam.TabIndex = 9;
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(292, 287);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 23);
            this.BtnOk.TabIndex = 10;
            this.BtnOk.Text = "Ok";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // UpdateOLA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 346);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.TxtNaam);
            this.Controls.Add(this.TxtCode);
            this.Controls.Add(this.CmbDocent);
            this.Controls.Add(this.CmbOPO);
            this.Controls.Add(this.NudStudiepunten);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateOLA";
            this.Text = "UpdateOLA";
            ((System.ComponentModel.ISupportInitialize)(this.NudStudiepunten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown NudStudiepunten;
        private System.Windows.Forms.ComboBox CmbOPO;
        private System.Windows.Forms.ComboBox CmbDocent;
        private System.Windows.Forms.TextBox TxtCode;
        private System.Windows.Forms.TextBox TxtNaam;
        private System.Windows.Forms.Button BtnOk;
    }
}