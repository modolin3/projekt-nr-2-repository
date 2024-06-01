using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projekt2_WindowsForm
{
    public partial class sprawdzian2 : Form
    {
        public sprawdzian2()
        {
            InitializeComponent();
        }

        private void sprawdzian2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult moOknoMessage = MessageBox.Show("Czy na pewno chcesz zamknąć ten formularz?", this.Text,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (moOknoMessage == DialogResult.Yes)
            {
                e.Cancel = false;
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnObliczWartoscFx_Click(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
            float moX, moFx;
            if (!moPobranieDanychDoObliczen(out moX))
            {
                errorProvider1.SetError(btnObliczWartoscFx, "ERROR! W zapisie występuje niepoprawny znak!");
                return;
            }
            moFx = moObliczenieRownania(moX);
            txtFx.Text = string.Format("{0:0.###}", moFx);
            btnObliczWartoscFx.Enabled = false;
        }

        private void btnWizualizacjaTabelaryczna_Click(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
            float moXd, moXg, moh;
            if (!moPobranieDanychDlaTablicowania(out moXd, out moXg, out moh))
            {
                errorProvider1.SetError(btnWizualizacjaTabelaryczna, "ERROR! Podczas pobierania danych dla funkcjonalności wystąpił błąd!");
                return;
            }
            float[,] moTWFx;
            moTablicowanieWartosciFx(moXd, moXg, moh, out moTWFx);
            moPrzepiszDoDataGridView(moTWFx, ref dgvTWFx);
            dgvTWFx.Visible = true;
            btnWizualizacjaTabelaryczna.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Czyszczenie wszystkich pól tekstowych.
            txtX.Text = "";
            txtXd.Text = "";
            txtXg.Text = "";
            txtH.Text = "";
            txtFx.Text = "";

            // Czyszczenie błędów z errorProvidera.
            errorProvider1.Clear();

            // Czyszczenie danych z DataGridView.
            dgvTWFx.Rows.Clear();

            // Włączenie przycisków (jeśli były wyłączone).
            btnObliczWartoscFx.Enabled = true;
            btnWizualizacjaTabelaryczna.Enabled = true;

            // Ukrycie DataGridView, jeśli jest widoczny.
            dgvTWFx.Visible = false;

            // Ustawienie pól tekstowych na możliwe do edycji.
            txtX.ReadOnly = false;
            txtXd.ReadOnly = false;
            txtXg.ReadOnly = false;
            txtH.ReadOnly = false;
        }

        private bool moPobranieDanychDoObliczen(out float moX)
        {
            moX = 0.0F;
            if (string.IsNullOrEmpty(txtX.Text.Trim()))
            {
                errorProvider1.SetError(txtX, "ERROR! Wpisz wartość 'X'");
                return false;
            }

            if (!float.TryParse(txtX.Text, out moX))
            {
                errorProvider1.SetError(txtX, "ERROR! W zapisie występuje niepoprawny znak!");
                return false;
            }

            txtX.ReadOnly = true;
            return true;
        }

        private float moObliczenieRownania(float moX)
        {
            if (moX < -5)
            {
                // Dla x < -5
                return (float)(Math.Sqrt(1 + Math.Sqrt(1 + Math.Pow(moX, 2))) + 1);
            }
            else if (moX >= -5 && moX < 5)
            {
                // Dla -5 <= x < 5
                return (float)(2 * Math.Log(1 + Math.Abs(moX)));
            }
            else
            {
                // Dla x >= 5
                double part1 = Math.Sqrt(1 + Math.Exp(moX) + 2 * Math.Log(moX));
                double part2 = Math.Sin(moX) / (1 + Math.Pow(moX, 3) / 3);
                return (float)(part1 - part2);
            }
        }

        private bool moPobranieDanychDlaTablicowania(out float moXd, out float moXg, out float moh)
        {
            moXd = moXg = moh = 0.0F;

            if (string.IsNullOrEmpty(txtXd.Text.Trim()) || !float.TryParse(txtXd.Text, out moXd) ||
                string.IsNullOrEmpty(txtXg.Text.Trim()) || !float.TryParse(txtXg.Text, out moXg) ||
                string.IsNullOrEmpty(txtH.Text.Trim()) || !float.TryParse(txtH.Text, out moh) ||
                moXd > moXg || moh <= 0 || moh > Math.Abs(moXg - moXd) / 2)
            {
                errorProvider1.SetError(txtH, "ERROR! Sprawdź wprowadzone dane!");
                return false;
            }

            txtXd.Text = "";
            txtXg.Text = "";
            txtH.Text = "";
            return true;
        }

        void moTablicowanieWartosciFx(float moXd, float moXg, float moh, out float[,] moTWFx)
        {
            int n = (int)((moXg - moXd) / moh) + 1;
            moTWFx = new float[n, 3];
            for (int i = 0; i < n; i++)
            {
                float moX = moXd + i * moh;
                moTWFx[i, 0] = i;
                moTWFx[i, 1] = moX;
                moTWFx[i, 2] = moObliczenieRownania(moX);
            }
        }

        void moPrzepiszDoDataGridView(float[,] moTWFx, ref DataGridView dgvTWFx)
        {
            dgvTWFx.Rows.Clear();
            for (int i = 0; i < moTWFx.GetLength(0); i++)
            {
                dgvTWFx.Rows.Add(moTWFx[i, 0], moTWFx[i, 1].ToString("0.00"), moTWFx[i, 2].ToString("F3"));
            }
        }

        private void sprawdzian2_Load(object sender, EventArgs e)
        {

        }
    }
}
