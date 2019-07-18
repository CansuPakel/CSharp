namespace GUI
{
    partial class NieuwOPO
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
            this.label6 = new System.Windows.Forms.Label();
            this.NudStudiepunten = new System.Windows.Forms.NumericUpDown();
            this.CmbFase = new System.Windows.Forms.ComboBox();
            this.CmbSemester = new System.Windows.Forms.ComboBox();
            this.CmbVerantwoordelijke = new System.Windows.Forms.ComboBox();
            this.TxtCode = new System.Windows.Forms.TextBox();
            this.TxtNaam = new System.Windows.Forms.TextBox();
            this.BtnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NudStudiepunten)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "code";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "naam";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "studiepunten";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "fase";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "semester";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "verantwoordelijke";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // NudStudiepunten
            // 
            this.NudStudiepunten.Location = new System.Drawing.Point(144, 134);
            this.NudStudiepunten.Name = "NudStudiepunten";
            this.NudStudiepunten.Size = new System.Drawing.Size(176, 20);
            this.NudStudiepunten.TabIndex = 6;
            this.NudStudiepunten.ValueChanged += new System.EventHandler(this.NudStudiepunten_ValueChanged);
            // 
            // CmbFase
            // 
            this.CmbFase.FormattingEnabled = true;
            this.CmbFase.Location = new System.Drawing.Point(144, 192);
            this.CmbFase.Name = "CmbFase";
            this.CmbFase.Size = new System.Drawing.Size(176, 21);
            this.CmbFase.TabIndex = 7;
            // 
            // CmbSemester
            // 
            this.CmbSemester.FormattingEnabled = true;
            this.CmbSemester.Location = new System.Drawing.Point(143, 258);
            this.CmbSemester.Name = "CmbSemester";
            this.CmbSemester.Size = new System.Drawing.Size(177, 21);
            this.CmbSemester.TabIndex = 8;
            // 
            // CmbVerantwoordelijke
            // 
            this.CmbVerantwoordelijke.FormattingEnabled = true;
            this.CmbVerantwoordelijke.Location = new System.Drawing.Point(143, 318);
            this.CmbVerantwoordelijke.Name = "CmbVerantwoordelijke";
            this.CmbVerantwoordelijke.Size = new System.Drawing.Size(177, 21);
            this.CmbVerantwoordelijke.TabIndex = 9;
            this.CmbVerantwoordelijke.SelectedIndexChanged += new System.EventHandler(this.CmbVerantwoordelijke_SelectedIndexChanged);
            // 
            // TxtCode
            // 
            this.TxtCode.Location = new System.Drawing.Point(143, 34);
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.Size = new System.Drawing.Size(177, 20);
            this.TxtCode.TabIndex = 10;
            this.TxtCode.TextChanged += new System.EventHandler(this.TxtCode_TextChanged);
            // 
            // TxtNaam
            // 
            this.TxtNaam.Location = new System.Drawing.Point(144, 84);
            this.TxtNaam.Name = "TxtNaam";
            this.TxtNaam.Size = new System.Drawing.Size(176, 20);
            this.TxtNaam.TabIndex = 11;
            this.TxtNaam.TextChanged += new System.EventHandler(this.TxtNaam_TextChanged);
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(245, 390);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 23);
            this.BtnOk.TabIndex = 12;
            this.BtnOk.Text = "ok";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // NieuwOPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 450);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.TxtNaam);
            this.Controls.Add(this.TxtCode);
            this.Controls.Add(this.CmbVerantwoordelijke);
            this.Controls.Add(this.CmbSemester);
            this.Controls.Add(this.CmbFase);
            this.Controls.Add(this.NudStudiepunten);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NieuwOPO";
            this.Text = "NieuwOPO";
            this.Load += new System.EventHandler(this.NieuwOPO_Load);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NudStudiepunten;
        private System.Windows.Forms.ComboBox CmbFase;
        private System.Windows.Forms.ComboBox CmbSemester;
        private System.Windows.Forms.ComboBox CmbVerantwoordelijke;
        private System.Windows.Forms.TextBox TxtCode;
        private System.Windows.Forms.TextBox TxtNaam;
        private System.Windows.Forms.Button BtnOk;
    }
}