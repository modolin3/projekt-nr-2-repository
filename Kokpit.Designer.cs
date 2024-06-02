
namespace ProjektNr2_WindowsForm
{
    partial class Kokpit
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
            this.btnAnalizatorLaboratoryjny = new System.Windows.Forms.Button();
            this.btnAnalizatorIndywidualny = new System.Windows.Forms.Button();
            this.btnsprawdzian = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAnalizatorLaboratoryjny
            // 
            this.btnAnalizatorLaboratoryjny.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAnalizatorLaboratoryjny.Location = new System.Drawing.Point(52, 182);
            this.btnAnalizatorLaboratoryjny.Name = "btnAnalizatorLaboratoryjny";
            this.btnAnalizatorLaboratoryjny.Size = new System.Drawing.Size(317, 93);
            this.btnAnalizatorLaboratoryjny.TabIndex = 0;
            this.btnAnalizatorLaboratoryjny.Text = "Analizator Laboratoryjny";
            this.btnAnalizatorLaboratoryjny.UseVisualStyleBackColor = true;
            this.btnAnalizatorLaboratoryjny.Click += new System.EventHandler(this.btnAnalizatorLaboratoryjny_Click);
            // 
            // btnAnalizatorIndywidualny
            // 
            this.btnAnalizatorIndywidualny.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAnalizatorIndywidualny.Location = new System.Drawing.Point(441, 182);
            this.btnAnalizatorIndywidualny.Name = "btnAnalizatorIndywidualny";
            this.btnAnalizatorIndywidualny.Size = new System.Drawing.Size(280, 83);
            this.btnAnalizatorIndywidualny.TabIndex = 1;
            this.btnAnalizatorIndywidualny.Text = "Analizator Indywidualny";
            this.btnAnalizatorIndywidualny.UseVisualStyleBackColor = true;
            this.btnAnalizatorIndywidualny.Click += new System.EventHandler(this.btnAnalizatorIndywidualny_Click);
            // 
            // btnsprawdzian
            // 
            this.btnsprawdzian.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnsprawdzian.Location = new System.Drawing.Point(237, 319);
            this.btnsprawdzian.Name = "btnsprawdzian";
            this.btnsprawdzian.Size = new System.Drawing.Size(285, 80);
            this.btnsprawdzian.TabIndex = 2;
            this.btnsprawdzian.Text = "SprawdzianNr2";
            this.btnsprawdzian.UseVisualStyleBackColor = true;
            this.btnsprawdzian.Click += new System.EventHandler(this.btnsprawdzian_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(56, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(650, 52);
            this.label1.TabIndex = 3;
            this.label1.Text = "Analizator tabelaryczny i graficzny funkcji matematycznej\r\nw określonym przedzial" +
    "e zmian wartości zmienne niezależnej X";
            // 
            // Kokpit
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsprawdzian);
            this.Controls.Add(this.btnAnalizatorIndywidualny);
            this.Controls.Add(this.btnAnalizatorLaboratoryjny);
            this.Name = "Kokpit";
            this.Text = "KokpitProjektyNr2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnalizatorLaboratoryjny;
        private System.Windows.Forms.Button btnAnalizatorIndywidualny;
        private System.Windows.Forms.Button btnsprawdzian;
        private System.Windows.Forms.Label label1;
    }
}

