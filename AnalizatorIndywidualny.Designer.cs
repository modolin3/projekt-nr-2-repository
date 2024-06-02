
namespace Projekt2_WindowsForm
{
    partial class AnalizatorIndywidualny
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
            this.txtFx = new System.Windows.Forms.TextBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.txtXg = new System.Windows.Forms.TextBox();
            this.txtXd = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvTWFx = new System.Windows.Forms.DataGridView();
            this.Nr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wartośćx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WartosćFx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnObliczWartoscFx = new System.Windows.Forms.Button();
            this.btnWizualizacjaTabelaryczna = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTWFx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFx
            // 
            this.txtFx.Location = new System.Drawing.Point(630, 94);
            this.txtFx.Name = "txtFx";
            this.txtFx.Size = new System.Drawing.Size(100, 20);
            this.txtFx.TabIndex = 0;
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(71, 360);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(100, 20);
            this.txtH.TabIndex = 1;
            // 
            // txtXg
            // 
            this.txtXg.Location = new System.Drawing.Point(71, 313);
            this.txtXg.Name = "txtXg";
            this.txtXg.Size = new System.Drawing.Size(100, 20);
            this.txtXg.TabIndex = 2;
            // 
            // txtXd
            // 
            this.txtXd.Location = new System.Drawing.Point(71, 262);
            this.txtXd.Name = "txtXd";
            this.txtXd.Size = new System.Drawing.Size(100, 20);
            this.txtXd.TabIndex = 3;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(67, 120);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 20);
            this.txtX.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(32, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Wartość zmiennej niezależnej X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(64, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Przedział i przyrost h \r\nzmian wartości X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(33, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Xd";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(32, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Xg";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(33, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "h";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(573, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Wartość F(X) równania w punkcie X";
            // 
            // dgvTWFx
            // 
            this.dgvTWFx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTWFx.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nr,
            this.Wartośćx,
            this.WartosćFx});
            this.errorProvider1.SetIconAlignment(this.dgvTWFx, System.Windows.Forms.ErrorIconAlignment.BottomLeft);
            this.dgvTWFx.Location = new System.Drawing.Point(240, 225);
            this.dgvTWFx.Name = "dgvTWFx";
            this.dgvTWFx.Size = new System.Drawing.Size(332, 150);
            this.dgvTWFx.TabIndex = 11;
            // 
            // Nr
            // 
            this.Nr.HeaderText = "Numer przedziału";
            this.Nr.Name = "Nr";
            // 
            // Wartośćx
            // 
            this.Wartośćx.HeaderText = "Wartość zmiennej niezależnej X";
            this.Wartośćx.Name = "Wartośćx";
            // 
            // WartosćFx
            // 
            this.WartosćFx.HeaderText = "Wartość funkcji F(X)";
            this.WartosćFx.Name = "WartosćFx";
            // 
            // btnObliczWartoscFx
            // 
            this.btnObliczWartoscFx.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObliczWartoscFx.Location = new System.Drawing.Point(615, 157);
            this.btnObliczWartoscFx.Name = "btnObliczWartoscFx";
            this.btnObliczWartoscFx.Size = new System.Drawing.Size(157, 78);
            this.btnObliczWartoscFx.TabIndex = 12;
            this.btnObliczWartoscFx.Text = "Oblicz wartość równania F(X) \r\ndla podangeo  X";
            this.btnObliczWartoscFx.UseVisualStyleBackColor = true;
            this.btnObliczWartoscFx.Click += new System.EventHandler(this.btnObliczWartoscFx_Click);
            // 
            // btnWizualizacjaTabelaryczna
            // 
            this.btnWizualizacjaTabelaryczna.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWizualizacjaTabelaryczna.Location = new System.Drawing.Point(600, 241);
            this.btnWizualizacjaTabelaryczna.Name = "btnWizualizacjaTabelaryczna";
            this.btnWizualizacjaTabelaryczna.Size = new System.Drawing.Size(198, 89);
            this.btnWizualizacjaTabelaryczna.TabIndex = 13;
            this.btnWizualizacjaTabelaryczna.Text = "Wizualizacja tabelaryczna wartości równania F(X) w podanym przedziale zmiany wart" +
    "ości X";
            this.btnWizualizacjaTabelaryczna.UseVisualStyleBackColor = true;
            this.btnWizualizacjaTabelaryczna.Click += new System.EventHandler(this.btnWizualizacjaTabelaryczna_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReset.Location = new System.Drawing.Point(615, 351);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(161, 58);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset\r\n(ustaw stan początkowy)\r\n";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(82, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(536, 26);
            this.label7.TabIndex = 15;
            this.label7.Text = "Analizator Indywidualny przydzielonej funkcji F(x)";
            // 
            // AnalizatorIndywidualny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnWizualizacjaTabelaryczna);
            this.Controls.Add(this.btnObliczWartoscFx);
            this.Controls.Add(this.dgvTWFx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.txtXd);
            this.Controls.Add(this.txtXg);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.txtFx);
            this.Name = "AnalizatorIndywidualny";
            this.Text = "Analizator Indywidualny";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTWFx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFx;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.TextBox txtXg;
        private System.Windows.Forms.TextBox txtXd;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvTWFx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wartośćx;
        private System.Windows.Forms.DataGridViewTextBoxColumn WartosćFx;
        private System.Windows.Forms.Button btnObliczWartoscFx;
        private System.Windows.Forms.Button btnWizualizacjaTabelaryczna;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label7;
    }
}