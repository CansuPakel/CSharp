namespace GUI
{
    partial class Hoofdvenster
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
            this.cmbDocenten = new System.Windows.Forms.ComboBox();
            this.BtnNieuwDocent = new System.Windows.Forms.Button();
            this.BtnNieuwOpo = new System.Windows.Forms.Button();
            this.BtnNiewOla = new System.Windows.Forms.Button();
            this.BtnUpdateOla = new System.Windows.Forms.Button();
            this.BtnVerwijderOLA = new System.Windows.Forms.Button();
            this.lstOlas = new System.Windows.Forms.ListView();
            this.OlaCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OlaNaam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OpoNaam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Studiepunten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // cmbDocenten
            // 
            this.cmbDocenten.FormattingEnabled = true;
            this.cmbDocenten.Location = new System.Drawing.Point(92, 68);
            this.cmbDocenten.Name = "cmbDocenten";
            this.cmbDocenten.Size = new System.Drawing.Size(425, 21);
            this.cmbDocenten.TabIndex = 0;
            this.cmbDocenten.SelectedIndexChanged += new System.EventHandler(this.cmbDocenten_SelectedIndexChanged);
            // 
            // BtnNieuwDocent
            // 
            this.BtnNieuwDocent.Location = new System.Drawing.Point(553, 68);
            this.BtnNieuwDocent.Name = "BtnNieuwDocent";
            this.BtnNieuwDocent.Size = new System.Drawing.Size(170, 23);
            this.BtnNieuwDocent.TabIndex = 1;
            this.BtnNieuwDocent.Text = "voeg nieuwe docent toe";
            this.BtnNieuwDocent.UseVisualStyleBackColor = true;
            this.BtnNieuwDocent.Click += new System.EventHandler(this.BtnNieuwDocent_Click);
            // 
            // BtnNieuwOpo
            // 
            this.BtnNieuwOpo.Location = new System.Drawing.Point(553, 136);
            this.BtnNieuwOpo.Name = "BtnNieuwOpo";
            this.BtnNieuwOpo.Size = new System.Drawing.Size(170, 23);
            this.BtnNieuwOpo.TabIndex = 2;
            this.BtnNieuwOpo.Text = "voeg nieuwe OPO toe";
            this.BtnNieuwOpo.UseVisualStyleBackColor = true;
            this.BtnNieuwOpo.Click += new System.EventHandler(this.BtnNieuwOpo_Click);
            // 
            // BtnNiewOla
            // 
            this.BtnNiewOla.Location = new System.Drawing.Point(553, 205);
            this.BtnNiewOla.Name = "BtnNiewOla";
            this.BtnNiewOla.Size = new System.Drawing.Size(170, 23);
            this.BtnNiewOla.TabIndex = 3;
            this.BtnNiewOla.Text = "voeg nieuw OLA toe";
            this.BtnNiewOla.UseVisualStyleBackColor = true;
            this.BtnNiewOla.Click += new System.EventHandler(this.BtnNiewOla_Click);
            // 
            // BtnUpdateOla
            // 
            this.BtnUpdateOla.Location = new System.Drawing.Point(553, 274);
            this.BtnUpdateOla.Name = "BtnUpdateOla";
            this.BtnUpdateOla.Size = new System.Drawing.Size(170, 23);
            this.BtnUpdateOla.TabIndex = 4;
            this.BtnUpdateOla.Text = "update OLA";
            this.BtnUpdateOla.UseVisualStyleBackColor = true;
            this.BtnUpdateOla.Click += new System.EventHandler(this.BtnUpdateOla_Click);
            // 
            // BtnVerwijderOLA
            // 
            this.BtnVerwijderOLA.Location = new System.Drawing.Point(553, 339);
            this.BtnVerwijderOLA.Name = "BtnVerwijderOLA";
            this.BtnVerwijderOLA.Size = new System.Drawing.Size(170, 23);
            this.BtnVerwijderOLA.TabIndex = 5;
            this.BtnVerwijderOLA.Text = "verwijder OLA";
            this.BtnVerwijderOLA.UseVisualStyleBackColor = true;
            this.BtnVerwijderOLA.Click += new System.EventHandler(this.BtnVerwijderOLA_Click);
            // 
            // lstOlas
            // 
            this.lstOlas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OlaCode,
            this.OlaNaam,
            this.OpoNaam,
            this.Studiepunten});
            this.lstOlas.GridLines = true;
            this.lstOlas.Location = new System.Drawing.Point(92, 122);
            this.lstOlas.Name = "lstOlas";
            this.lstOlas.Size = new System.Drawing.Size(425, 240);
            this.lstOlas.TabIndex = 6;
            this.lstOlas.UseCompatibleStateImageBehavior = false;
            this.lstOlas.View = System.Windows.Forms.View.Details;
            this.lstOlas.SelectedIndexChanged += new System.EventHandler(this.lstOlas_SelectedIndexChanged);
            // 
            // OlaCode
            // 
            this.OlaCode.Text = "OLA-code";
            this.OlaCode.Width = 121;
            // 
            // OlaNaam
            // 
            this.OlaNaam.Text = "OLA-naam";
            this.OlaNaam.Width = 107;
            // 
            // OpoNaam
            // 
            this.OpoNaam.Text = "OPO-naam";
            this.OpoNaam.Width = 103;
            // 
            // Studiepunten
            // 
            this.Studiepunten.Text = "studiepunten";
            this.Studiepunten.Width = 161;
            // 
            // Hoofdvenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstOlas);
            this.Controls.Add(this.BtnVerwijderOLA);
            this.Controls.Add(this.BtnUpdateOla);
            this.Controls.Add(this.BtnNiewOla);
            this.Controls.Add(this.BtnNieuwOpo);
            this.Controls.Add(this.BtnNieuwDocent);
            this.Controls.Add(this.cmbDocenten);
            this.Name = "Hoofdvenster";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Hoofdvenster_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDocenten;
        private System.Windows.Forms.Button BtnNieuwDocent;
        private System.Windows.Forms.Button BtnNieuwOpo;
        private System.Windows.Forms.Button BtnNiewOla;
        private System.Windows.Forms.Button BtnUpdateOla;
        private System.Windows.Forms.Button BtnVerwijderOLA;
        private System.Windows.Forms.ListView lstOlas;
        private System.Windows.Forms.ColumnHeader OlaCode;
        private System.Windows.Forms.ColumnHeader OlaNaam;
        private System.Windows.Forms.ColumnHeader OpoNaam;
        private System.Windows.Forms.ColumnHeader Studiepunten;
    }
}

