using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt2_WindowsForm
{
    public partial class AnalizatorIndywidualny : Form
    {
        public AnalizatorIndywidualny()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AnalizatorIndywidualny_FormClosing(object sender, FormClosingEventArgs e)
        {
            //utworzenie egzemplarza okna dialogowego "MessageBox" z pytaniem czy na pewno zamknąć formularz
            DialogResult moOknoMessage = MessageBox.Show("Czy na pewno chcesz zamknąć ten formularz?", this.Text,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //rozpoznanie klikniętego przycisku 
            if (moOknoMessage == DialogResult.Yes)
            {
                //nie kasujemy okna z zapytaniem
                e.Cancel = false;
                //zamknięcie wszystkich wątków i skasowanie wszystkich formularzy
                Application.ExitThread();
            }
            else
                //anulowanie zamknięcia formularza
                e.Cancel = true;
        }

        private void btnObliczWartoscFx_Click(object sender, EventArgs e)
        {
            //zgaszenie kontrolki errorProvider
            errorProvider1.Dispose();

            //deklaracja zmiennych dla danych wejściowych
            float moX;
            float moFx;

            //pobieranie danych wejściowych
            if (!moPobranieDanychDoObliczen(out moX))
            {
                //sygnalizujemy błąd
                errorProvider1.SetError(btnObliczWartoscFx, "ERROR! W zapisie występuje niepoprawny znak!");
                //przerwanie obsługi zdarzenia Click
                return;
            }

            //oblicznie F(X)
            moFx = moObliczenieRownania(moX);

            //wizualizacja wyniku w kontrolce Fx
            txtFx.Text = string.Format("{0:0.###}", moFx);

            //przestawienie przycisku na brak aktywności
            btnObliczWartoscFx.Enabled = false;
        }
        private void btnWizualizacjaTabelaryczna_Click(object sender, EventArgs e)
        {
            //zgaszenie kontrolki errorProvider
            errorProvider1.Dispose();

            //deklaracja zmiennych do przechowywania danych wejścowych
            float moXd, moXg, moh;

            if (!moPobranieDanychDlaTablicowania(out moXd, out moXg, out moh))
            {
                //sygnalizujemy błąd
                errorProvider1.SetError(btnObliczWartoscFx, "ERROR! Podczas pobierania danych dla funkcjonalności wystąpił błąd!");
                //przerwanie obsługi zdarzenia Click
                return;
            }
            //deklaracja tablicy do przechowywania wyników
            float[,] moTWFx;

            //tablicowanie wartości równania funkcji F(x) w podanym przedziale
            moTablicowanieWartosciFx(moXd, moXg, moh, out moTWFx);

            //wywołanie metody przepisania wierszy z tablicy TWFx do kontrolki DataGridView
            moPrzepiszDoDataGridView(moTWFx, ref dgvTWFx);

            //odsłonięcie kontrolki

            dgvTWFx.Visible = true;

            //ustawienie stanu braku aktywności
            btnWizualizacjaTabelaryczna.Enabled = false;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            // Wyczyszczenie zawartości pól tekstowych i kontrolki errorProvider
            txtX.Text = "";
            txtXd.Text = "";
            txtXg.Text = "";
            txtH.Text = "";
            txtFx.Text = "";
            errorProvider1.Clear(); // Wyczyszczenie komunikatów błędów
            dgvTWFx.Rows.Clear();

            btnObliczWartoscFx.Enabled = true;
            btnWizualizacjaTabelaryczna.Enabled = true;
            dgvTWFx.Visible = false;

            txtX.ReadOnly = false;
            txtXd.ReadOnly = false;
            txtXg.ReadOnly = false;
            txtH.ReadOnly = false;
        }
        #region Metody pomocnicze analizatora indywidualnego


        bool moPobranieDanychDoObliczen(out float moX)
        {
            moX = 0.0F;

            //sprawdzenie czy wartość X została wpisana
            if (string.IsNullOrEmpty(txtX.Text.Trim()))
            {
                //zapalenie errorProvider
                errorProvider1.SetError(txtX, "ERROR! Wpisz wartość 'X'");
                return false;
            }
            else
                errorProvider1.Dispose();

            //pobranie wartości X
            if (!float.TryParse(txtX.Text, out moX))
            {
                //sygnalizujemy, jeżeli błąd
                errorProvider1.SetError(txtX, "ERROR! W zapisie występuje niepoprawny znak!");

                //zwrócenie informacji o błędzie 
                return false;
            }
            else
                errorProvider1.Dispose();

            //ustawienie kontrolek ReadOnly dla kontrolek pobierających dane

            txtX.ReadOnly = true;

            //zwrócenie przekazanych danych, bez wykrytych błędów

            return true;
        }

        private float moObliczenieRownania(float X)
        {
            // Using the piecewise function defined earlier
            if (X < -1)
            {
                return (float)(Math.Pow(X, 2) * Math.Sin(X));
            }
            else if (X >= -1 && X <= 1)
            {
                if (X == 0)
                {
                    return 0; // Special case to avoid division by zero
                }
                else
                {
                    return (float)((1 - Math.Abs(X)) * (1 - Math.Abs(X)) / X);
                }
            }
            else // x > 1
            {
                return (float)(Math.Pow(X, X) - Math.Log(X) / Math.Cos(X));
            }
        }
        #endregion

        #region Metody pomocnicze do tablicowania funkcji wartości równiania Fx

        bool moPobranieDanychDlaTablicowania(out float moXd, out float moXg, out float moh)
        {
            moXd = moXg = moh = 0.0F;

            //sprawdzenie czy wartość X została wpisana
            if (string.IsNullOrEmpty(txtXd.Text.Trim()))
            {
                //zapalenie errorProvider
                errorProvider1.SetError(txtXd, "ERROR! Wpisz wartość 'X'");
                return false;
            }
            else
                errorProvider1.Dispose();

            //pobranie wartości X
            if (!float.TryParse(txtXd.Text, out moXd))
            {
                //sygnalizujemy, jeżeli błąd
                errorProvider1.SetError(txtXd, "ERROR! W zapisie występuje niepoprawny znak!");

                //zwrócenie informacji o błędzie 
                return false;
            }
            else
                errorProvider1.Dispose();
            //sprawdzenie czy wartość X została wpisana
            if (string.IsNullOrEmpty(txtXg.Text.Trim()))
            {
                //zapalenie errorProvider
                errorProvider1.SetError(txtXg, "ERROR! Wpisz wartość 'X'");
                return false;
            }
            else
                errorProvider1.Dispose();

            //pobranie wartości X
            if (!float.TryParse(txtXg.Text, out moXg))
            {
                //sygnalizujemy, jeżeli błąd
                errorProvider1.SetError(txtXg, "ERROR! W zapisie występuje niepoprawny znak!");

                //zwrócenie informacji o błędzie 
                return false;
            }
            else
                errorProvider1.Dispose();

            //pobranie wartości X
            if (!float.TryParse(txtH.Text, out moh))
            {
                //sygnalizujemy, jeżeli błąd
                errorProvider1.SetError(txtH, "ERROR! W zapisie występuje niepoprawny znak!");

                //zwrócenie informacji o błędzie 
                return false;
            }
            else
                errorProvider1.Dispose();
            if (moXd > moXg)
            {
                //sygnalizujemy, jeżeli błąd
                errorProvider1.SetError(txtXg, "ERROR! Granica górna ma wartość mniejszą niż górna!");

                //zwrócenie informacji o błędzie 
                return false;
            }
            else
                errorProvider1.Dispose();

            if (moh <= 0.0F)
            {
                //sygnalizujemy, jeżeli błąd
                errorProvider1.SetError(txtH, "ERROR! Wartość przyrostu musi mieć wartość większą od 0!");

                //zwrócenie informacji o błędzie 
                return false;
            }
            else
                errorProvider1.Dispose();

            if (moh > Math.Abs(moXg - moXd) / 2)
            {
                //sygnalizujemy, jeżeli błąd
                errorProvider1.SetError(txtH, "ERROR! Musi być spełniony warunek h<=|Xg - Xd|/2!");

                //zwrócenie informacji o błędzie 
                return false;
            }
            else
                errorProvider1.Dispose();

            //ustawienie kontrolek ReadOnly dla kontrolek pobierających dane
            txtXd.ReadOnly = true;
            txtXg.ReadOnly = true;
            txtH.ReadOnly = true;
            //zwrócenie przekazanych danych, bez wykrytych błędów

            return true;
        }

        void moTablicowanieWartosciFx(float moXd, float moXg, float moh, out float[,] moTWFx)
        {
            moTWFx = null;

            //wyznaczenie liczby podprzedziałów

            int n = (int)((moXg - moXd) / moh) + 1;

            //utworzenie egzemplarza tablicy TWS 
            moTWFx = new float[n, 3];

            float moX; //zmienna niezależna X
            int i; //numer podprzedziału

            for (moX = moXd, i = 0; i < moTWFx.GetLength(0); i++, moX = moX + moh)
            {
                moTWFx[i, 0] = i;
                moTWFx[i, 1] = moX;
                moTWFx[i, 2] = moObliczenieRownania(moX);
            }
        }
        void moPrzepiszDoDataGridView(float[,] moTWFx, ref DataGridView dgvTWFx)
        {
            //deklaracja odstępu
            const ushort moDist = 100;

            //lokalizacja kontrolki na formularzu
            dgvTWFx.Location = new Point(label1.Left -300, label1.Top + moDist);
            dgvTWFx.Width = (int)(this.Width * 0.35F);
            dgvTWFx.Height = (int)(this.Height * 0.5F);

            //wyzerowanie wierszy danych kontrolki
            dgvTWFx.Rows.Clear();

            //wycentrowanie zapisu w kolumnach
            dgvTWFx.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTWFx.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTWFx.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //przepisanie wierszy danych z tablicy TWFx do kontrolki DataGridView

            for (int i = 0; i < moTWFx.GetLength(0); i++)
            {
                //dodanie nowego wiersza
                dgvTWFx.Rows.Add();
                //wpisanie wartości numeru przedziału X

                dgvTWFx.Rows[i].Cells[0].Value = String.Format("{0}", moTWFx[i, 0]);

                //wpisanie wartości zmiennej niezależnej X
                dgvTWFx.Rows[i].Cells[1].Value = String.Format("{0:0.00}", moTWFx[i, 1]);

                //wpisanie wartości równania
                dgvTWFx.Rows[i].Cells[2].Value = String.Format("{0:F3}", moTWFx[i, 2]);
            }
        }


        #endregion

        private void AnalizatorIndywidualny_Load(object sender, EventArgs e)
        {

        }

        
    }
}

