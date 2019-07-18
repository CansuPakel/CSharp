namespace OdiseeAdministratie
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
            this.lstOlas = new System.Windows.Forms.ListView();
            this.BtnNieuwDocent = new System.Windows.Forms.Button();
            this.BtnNieuwOpo = new System.Windows.Forms.Button();
            this.BtnNieuwOla = new System.Windows.Forms.Button();
            this.BtnUpdateOla = new System.Windows.Forms.Button();
            this.BtnDeleteOla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbDocenten
            // 
            this.cmbDocenten.FormattingEnabled = true;
            this.cmbDocenten.Location = new System.Drawing.Point(45, 63);
            this.cmbDocenten.Name = "cmbDocenten";
            this.cmbDocenten.Size = new System.Drawing.Size(530, 21);
            this.cmbDocenten.TabIndex = 0;
            // 
            // lstOlas
            // 
            this.lstOlas.Location = new System.Drawing.Point(45, 104);
            this.lstOlas.Name = "lstOlas";
            this.lstOlas.Size = new System.Drawing.Size(530, 283);
            this.lstOlas.TabIndex = 1;
            this.lstOlas.UseCompatibleStateImageBehavior = false;
            // 
            // BtnNieuwDocent
            // 
            this.BtnNieuwDocent.Location = new System.Drawing.Point(621, 104);
            this.BtnNieuwDocent.Name = "BtnNieuwDocent";
            this.BtnNieuwDocent.Size = new System.Drawing.Size(154, 30);
            this.BtnNieuwDocent.TabIndex = 2;
            this.BtnNieuwDocent.Text = "voeg nieuwe docent toe";
            this.BtnNieuwDocent.UseVisualStyleBackColor = true;
            // 
            // BtnNieuwOpo
            // 
            this.BtnNieuwOpo.Location = new System.Drawing.Point(621, 169);
            this.BtnNieuwOpo.Name = "BtnNieuwOpo";
            this.BtnNieuwOpo.Size = new System.Drawing.Size(154, 30);
            this.BtnNieuwOpo.TabIndex = 3;
            this.BtnNieuwOpo.Text = "voeg nieuwe opo toe";
            this.BtnNieuwOpo.UseVisualStyleBackColor = true;
            // 
            // BtnNieuwOla
            // 
            this.BtnNieuwOla.Location = new System.Drawing.Point(621, 233);
            this.BtnNieuwOla.Name = "BtnNieuwOla";
            this.BtnNieuwOla.Size = new System.Drawing.Size(154, 30);
            this.BtnNieuwOla.TabIndex = 4;
            this.BtnNieuwOla.Text = "voeg nieuwe ola toe";
            this.BtnNieuwOla.UseVisualStyleBackColor = true;
            // 
            // BtnUpdateOla
            // 
            this.BtnUpdateOla.Location = new System.Drawing.Point(621, 294);
            this.BtnUpdateOla.Name = "BtnUpdateOla";
            this.BtnUpdateOla.Size = new System.Drawing.Size(154, 30);
            this.BtnUpdateOla.TabIndex = 5;
            this.BtnUpdateOla.Text = "update ola";
            this.BtnUpdateOla.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteOla
            // 
            this.BtnDeleteOla.Location = new System.Drawing.Point(621, 357);
            this.BtnDeleteOla.Name = "BtnDeleteOla";
            this.BtnDeleteOla.Size = new System.Drawing.Size(154, 30);
            this.BtnDeleteOla.TabIndex = 6;
            this.BtnDeleteOla.Text = "verwijder ola";
            this.BtnDeleteOla.UseVisualStyleBackColor = true;
            // 
            // Hoofdvenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnDeleteOla);
            this.Controls.Add(this.BtnUpdateOla);
            this.Controls.Add(this.BtnNieuwOla);
            this.Controls.Add(this.BtnNieuwOpo);
            this.Controls.Add(this.BtnNieuwDocent);
            this.Controls.Add(this.lstOlas);
            this.Controls.Add(this.cmbDocenten);
            this.Name = "Hoofdvenster";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Hoofdvenster_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDocenten;
        private System.Windows.Forms.ListView lstOlas;
        private System.Windows.Forms.Button BtnNieuwDocent;
        private System.Windows.Forms.Button BtnNieuwOpo;
        private System.Windows.Forms.Button BtnNieuwOla;
        private System.Windows.Forms.Button BtnUpdateOla;
        private System.Windows.Forms.Button BtnDeleteOla;
    }
}

