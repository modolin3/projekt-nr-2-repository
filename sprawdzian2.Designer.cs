

namespace Projekt2_WindowsForm
{
    partial class sprawdzian2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtFx = new System.Windows.Forms.TextBox();
            this.txtXd = new System.Windows.Forms.TextBox();
            this.txtXg = new System.Windows.Forms.TextBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.dgvTWFx = new System.Windows.Forms.DataGridView();
            this.Numer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wartoscx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wartosFx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnObliczWartoscFx = new System.Windows.Forms.Button();
            this.btnWizualizacjaTabelaryczna = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTWFx)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(219, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sprawdzian Nr 2 samoocena 5.0\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(57, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Xg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(57, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Xd";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(598, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Obliczona wartość kwadratowego \r\ndla podanego X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(25, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Wartość zmiennej niezależnej X";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(57, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "h";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(36, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 30);
            this.label7.TabIndex = 6;
            this.label7.Text = "Przedział i przyrost \'h\' zmian \r\nwartości zmiennej X";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(60, 153);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 20);
            this.txtX.TabIndex = 7;
            // 
            // txtFx
            // 
            this.txtFx.Location = new System.Drawing.Point(633, 99);
            this.txtFx.Name = "txtFx";
            this.txtFx.Size = new System.Drawing.Size(100, 20);
            this.txtFx.TabIndex = 8;
            // 
            // txtXd
            // 
            this.txtXd.Location = new System.Drawing.Point(83, 318);
            this.txtXd.Name = "txtXd";
            this.txtXd.Size = new System.Drawing.Size(100, 20);
            this.txtXd.TabIndex = 9;
            // 
            // txtXg
            // 
            this.txtXg.Location = new System.Drawing.Point(83, 346);
            this.txtXg.Name = "txtXg";
            this.txtXg.Size = new System.Drawing.Size(100, 20);
            this.txtXg.TabIndex = 10;
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(83, 372);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(100, 20);
            this.txtH.TabIndex = 11;
            // 
            // dgvTWFx
            // 
            this.dgvTWFx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTWFx.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numer,
            this.Wartoscx,
            this.wartosFx});
            this.dgvTWFx.Location = new System.Drawing.Point(233, 111);
            this.dgvTWFx.Name = "dgvTWFx";
            this.dgvTWFx.Size = new System.Drawing.Size(339, 255);
            this.dgvTWFx.TabIndex = 12;
            // 
            // Numer
            // 
            this.Numer.HeaderText = "Numer przedziału ";
            this.Numer.Name = "Numer";
            // 
            // Wartoscx
            // 
            this.Wartoscx.HeaderText = "Wartość zmiennej niezaleźnej X";
            this.Wartoscx.Name = "Wartoscx";
            // 
            // wartosFx
            // 
            this.wartosFx.HeaderText = "Wartość funkcji F(X) na sprawdzian";
            this.wartosFx.Name = "wartosFx";
            // 
            // btnObliczWartoscFx
            // 
            this.btnObliczWartoscFx.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObliczWartoscFx.Location = new System.Drawing.Point(604, 138);
            this.btnObliczWartoscFx.Name = "btnObliczWartoscFx";
            this.btnObliczWartoscFx.Size = new System.Drawing.Size(167, 84);
            this.btnObliczWartoscFx.TabIndex = 13;
            this.btnObliczWartoscFx.Text = "Oblicz wartość funkcji (na sprawdzian) F(x)\r\ndla podanego X\r\n";
            this.btnObliczWartoscFx.UseVisualStyleBackColor = true;
            this.btnObliczWartoscFx.Click += new System.EventHandler(this.btnObliczWartoscFx_Click);
            // 
            // btnWizualizacjaTabelaryczna
            // 
            this.btnWizualizacjaTabelaryczna.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWizualizacjaTabelaryczna.Location = new System.Drawing.Point(607, 239);
            this.btnWizualizacjaTabelaryczna.Name = "btnWizualizacjaTabelaryczna";
            this.btnWizualizacjaTabelaryczna.Size = new System.Drawing.Size(164, 69);
            this.btnWizualizacjaTabelaryczna.TabIndex = 14;
            this.btnWizualizacjaTabelaryczna.Text = "Wizualizacja tabelaryczna wartości\r\nwartość funkcji (na sprawdzian)";
            this.btnWizualizacjaTabelaryczna.UseVisualStyleBackColor = true;
            this.btnWizualizacjaTabelaryczna.Click += new System.EventHandler(this.btnWizualizacjaTabelaryczna_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReset.Location = new System.Drawing.Point(607, 318);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(164, 74);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Resetuj";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // sprawdzian2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnWizualizacjaTabelaryczna);
            this.Controls.Add(this.btnObliczWartoscFx);
            this.Controls.Add(this.dgvTWFx);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.txtXg);
            this.Controls.Add(this.txtXd);
            this.Controls.Add(this.txtFx);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "sprawdzian2";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTWFx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnWizualizacjaTabelaryczna;
        private System.Windows.Forms.Button btnObliczWartoscFx;
        private System.Windows.Forms.DataGridView dgvTWFx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wartoscx;
        private System.Windows.Forms.DataGridViewTextBoxColumn wartosFx;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.TextBox txtXg;
        private System.Windows.Forms.TextBox txtXd;
        private System.Windows.Forms.TextBox txtFx;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}