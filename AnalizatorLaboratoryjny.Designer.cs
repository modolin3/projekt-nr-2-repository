
namespace Projekt2_WindowsForm
{
    partial class AnalizatorLaboratoryjny
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
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.txtXg = new System.Windows.Forms.TextBox();
            this.txtXd = new System.Windows.Forms.TextBox();
            this.txmo = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtFx = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.btnObliczWartoscFx = new System.Windows.Forms.Button();
            this.btnWizualizacjaTabelaryczna = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dgvTWFx = new System.Windows.Forms.DataGridView();
            this.Nr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wartosc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WartoscFx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTWFx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(103, 151);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(116, 22);
            this.txtB.TabIndex = 0;
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(76, 457);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(116, 22);
            this.txtH.TabIndex = 1;
            // 
            // txtXg
            // 
            this.txtXg.Location = new System.Drawing.Point(76, 417);
            this.txtXg.Name = "txtXg";
            this.txtXg.Size = new System.Drawing.Size(116, 22);
            this.txtXg.TabIndex = 2;
            // 
            // txtXd
            // 
            this.txtXd.Location = new System.Drawing.Point(76, 370);
            this.txtXd.Name = "txtXd";
            this.txtXd.Size = new System.Drawing.Size(116, 22);
            this.txtXd.TabIndex = 3;
            // 
            // txmo
            // 
            this.txmo.Location = new System.Drawing.Point(103, 192);
            this.txmo.Name = "txmo";
            this.txmo.Size = new System.Drawing.Size(116, 22);
            this.txmo.TabIndex = 4;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(103, 112);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(116, 22);
            this.txtA.TabIndex = 5;
            // 
            // txtFx
            // 
            this.txtFx.Location = new System.Drawing.Point(724, 120);
            this.txtFx.Name = "txtFx";
            this.txtFx.Size = new System.Drawing.Size(116, 22);
            this.txtFx.TabIndex = 6;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(63, 268);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(116, 22);
            this.txtX.TabIndex = 7;
            // 
            // btnObliczWartoscFx
            // 
            this.btnObliczWartoscFx.Location = new System.Drawing.Point(682, 192);
            this.btnObliczWartoscFx.Name = "btnObliczWartoscFx";
            this.btnObliczWartoscFx.Size = new System.Drawing.Size(205, 96);
            this.btnObliczWartoscFx.TabIndex = 8;
            this.btnObliczWartoscFx.Text = "Oblicz Wartość równania \r\nkwadratowego dla podanego X";
            this.btnObliczWartoscFx.UseVisualStyleBackColor = true;
            this.btnObliczWartoscFx.Click += new System.EventHandler(this.btnObliczWartoscFx_Click_1);
            // 
            // btnWizualizacjaTabelaryczna
            // 
            this.btnWizualizacjaTabelaryczna.Location = new System.Drawing.Point(682, 294);
            this.btnWizualizacjaTabelaryczna.Name = "btnWizualizacjaTabelaryczna";
            this.btnWizualizacjaTabelaryczna.Size = new System.Drawing.Size(219, 77);
            this.btnWizualizacjaTabelaryczna.TabIndex = 9;
            this.btnWizualizacjaTabelaryczna.Text = "Wizaulizazacja tabelaryczna \r\nwartości równania w podanym przedziale zmian zmienn" +
    "ej\r\n niezaleźnej X";
            this.btnWizualizacjaTabelaryczna.UseVisualStyleBackColor = true;
            this.btnWizualizacjaTabelaryczna.Click += new System.EventHandler(this.btnWizualizacjaTabelaryczna_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(699, 417);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(203, 55);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset\r\n(ustaw stan początkowy)\r\n";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dgvTWFx
            // 
            this.dgvTWFx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTWFx.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nr,
            this.Wartosc,
            this.WartoscFx});
            this.dgvTWFx.Location = new System.Drawing.Point(268, 92);
            this.dgvTWFx.Name = "dgvTWFx";
            this.dgvTWFx.Size = new System.Drawing.Size(407, 195);
            this.dgvTWFx.TabIndex = 11;
            // 
            // Nr
            // 
            this.Nr.HeaderText = "Numer przedziału";
            this.Nr.Name = "Nr";
            // 
            // Wartosc
            // 
            this.Wartosc.HeaderText = "Wartość zmiennej niezależnej X";
            this.Wartosc.Name = "Wartosc";
            // 
            // WartoscFx
            // 
            this.WartoscFx.HeaderText = "Wartość równania funkcji F(X)";
            this.WartoscFx.Name = "WartoscFx";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(118, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(590, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "Analizator Laboratoryjny równania kwadratowego F(X)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 30);
            this.label2.TabIndex = 13;
            this.label2.Text = "Przedział i przyrost \'h\' zmian \r\nwartości zmiennej X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(28, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Wartość zmiennej niezaleźne X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(65, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 30);
            this.label4.TabIndex = 15;
            this.label4.Text = "Współczynnik równania \r\nkwadratowego";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(712, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 30);
            this.label5.TabIndex = 16;
            this.label5.Text = "Oblicz wartość równaia \r\nkwadrotowego dla podnego X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Xg:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Xd :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "B:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "A: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "C:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 460);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "h";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AnalizatorLaboratoryjny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTWFx);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnWizualizacjaTabelaryczna);
            this.Controls.Add(this.btnObliczWartoscFx);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.txtFx);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txmo);
            this.Controls.Add(this.txtXd);
            this.Controls.Add(this.txtXg);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.txtB);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "AnalizatorLaboratoryjny";
            this.Text = "AnalizatorLaboratoryjny";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTWFx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.TextBox txtXg;
        private System.Windows.Forms.TextBox txtXd;
        private System.Windows.Forms.TextBox txmo;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtFx;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Button btnObliczWartoscFx;
        private System.Windows.Forms.Button btnWizualizacjaTabelaryczna;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dgvTWFx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wartosc;
        private System.Windows.Forms.DataGridViewTextBoxColumn WartoscFx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}