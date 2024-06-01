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
    public partial class AnalizatorLaboratoryjny : Form
    {

        public AnalizatorLaboratoryjny()
        {
            InitializeComponent();

            // inicjalizacja kontrolki errorProvider1
            errorProvider1 = new ErrorProvider();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void btnObliczWartoscFx_Click_1(object sender, EventArgs e)
        {
            //zgaszenie kontrolki errorProvider
            errorProvider1.Dispose();

            //deklaracja zmiennych dla danych wejściowych
            float moA, moB, moC, moX;
            float moFx;

            //pobieranie danych wejściowych
            if (!moPobranieDanychDoObliczen(out moA, out moB, out moC, out moX))
            {
                //sygnalizujemy błąd
                errorProvider1.SetError(btnObliczWartoscFx, "ERROR! W zapisie występuje niepoprawny znak!");
                //przerwanie obsługi zdarzenia Click
                return;
            }

            //oblicznie F(X)
            moFx = moObliczenieRownaniaKwadratowego(moA, moB, moC, moX);

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
            float moA, moB, moC, moXd, moXg, moh;

            if (!moPobranieDanychDlaTablicowania(out moA, out moB, out moC, out moXd, out moXg, out moh))
            {
                //sygnalizujemy błąd
                errorProvider1.SetError(btnObliczWartoscFx, "ERROR! Podczas pobierania danych dla funkcjonalności wystąpił błąd!");
                //przerwanie obsługi zdarzenia Click
                return;
            }
            //deklaracja tablicy do przechowywania wyników
            float[,] moTWFx;

            //tablicowanie wartości równania funkcji F(x) w podanym przedziale
            moTablicowanieWartosciFx(moA, moB, moC, moXd, moXg, moh, out moTWFx);

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
            txtA.Text = "";
            txtB.Text = "";
            txmo.Text = "";
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

            txtA.ReadOnly = false;
            txtB.ReadOnly = false;
            txmo.ReadOnly = false;
            txtX.ReadOnly = false;
            txtXd.ReadOnly = false;
            txtXg.ReadOnly = false;
            txtH.ReadOnly = false;
        }
        private void AnalizatorLaboratoryjny_FormClosing(object sender, FormClosingEventArgs e)
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

        #region Metody pomocnicze dla obliczania wartości równania(kalkulator laboratoryjny)

        bool moPobranieDanychDoObliczen(out float moA, out float moB, out float moC, out float moX)
        {
            //przypisanie wartosci początkowej

            moA = moB = moC = moX = 0.0F;


            //sprawdzenie czy wartość A została wpisana
            if (string.IsNullOrEmpty(txtA.Text.Trim()))
            {
                //zapalenie errorProvider
                errorProvider1.SetError(txtA, "ERROR! Wpisz współczynnik 'a'!");
                //zwrócenie informacji o błędzie
                return false;
            }
            else
                errorProvider1.Dispose();

            //pobranie współczynnika A
            if (!float.TryParse(txtA.Text, out moA))
            {
                //sygnalizujemy, jeżeli błąd
                errorProvider1.SetError(txtA, "ERROR! W zapisie występuje niepoprawny znak!");

                //zwrócenie informacji o błędzie 
                return false;
            }
            else
                errorProvider1.Dispose();

            if (moA == 0.0F)
            {
                //sygnalizujemy, że warość A nie może wynosic zero
                errorProvider1.SetError(txtA, "ERROR! Wartość A nie może wynosić 0!");

                return false;
            }
            else
                errorProvider1.Dispose();

            //sprawdzenie czy wartość B została wpisana
            if (string.IsNullOrEmpty(txtB.Text.Trim()))
            {
                //zapalenie errorProvider
                errorProvider1.SetError(txtB, "ERROR! Wpisz współczynnik 'b'!");
                return false;
            }
            else
                errorProvider1.Dispose();

            //pobranie współczynnika B
            if (!float.TryParse(txtB.Text, out moB))
            {
                //sygnalizujemy, jeżeli błąd
                errorProvider1.SetError(txtB, "ERROR! W zapisie występuje niepoprawny znak!");

                //zwrócenie informacji o błędzie 
                return false;
            }
            else
                errorProvider1.Dispose();

            //sprawdzenie czy wartość C została wpisana
            if (string.IsNullOrEmpty(txmo.Text.Trim()))
            {
                //zapalenie errorProvider
                errorProvider1.SetError(txmo, "ERROR! Wpisz współczynnik 'b'!");
                return false;
            }
            else
                errorProvider1.Dispose();

            //pobranie współczynnika C
            if (!float.TryParse(txmo.Text, out moC))
            {
                //sygnalizujemy, jeżeli błąd
                errorProvider1.SetError(txmo, "ERROR! W zapisie występuje niepoprawny znak!");

                //zwrócenie informacji o błędzie 
                return false;
            }
            else
                errorProvider1.Dispose();

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

            txtA.ReadOnly = true;
            txtB.ReadOnly = true;
            txmo.ReadOnly = true;
            txtX.ReadOnly = true;

            //zwrócenie przekazanych danych, bez wykrytych błędów

            return true;

        }

        private float moObliczenieRownaniaKwadratowego(float moA, float moB, float moC, float moX)
        {
            return (moA * moX + moB) * moX + moC;
        }


        #endregion

        #region Metody pomocnicze do tablicowania funkcji wartości równiania Fx

        bool moPobranieDanychDlaTablicowania(out float moA, out float moB, out float moC, out float moXd, out float moXg, out float moh)
        {
            //przypisanie wartosci początkowej

            moA = moB = moC = moXd = moXg = moh = 0.0F;


            //sprawdzenie czy wartość A została wpisana
            if (string.IsNullOrEmpty(txtA.Text.Trim()))
            {
                //zapalenie errorProvider
                errorProvider1.SetError(txtA, "ERROR! Wpisz współczynnik 'a'!");
                //zwrócenie informacji o błędzie
                return false;
            }
            else
                errorProvider1.Dispose();

            //pobranie współczynnika A
            if (!float.TryParse(txtA.Text, out moA))
            {
                //sygnalizujemy, jeżeli błąd
                errorProvider1.SetError(txtA, "ERROR! W zapisie występuje niepoprawny znak!");

                //zwrócenie informacji o błędzie 
                return false;
            }
            else
                errorProvider1.Dispose();

            if (moA == 0.0F)
            {
                //sygnalizujemy, że warość A nie może wynosic zero
                errorProvider1.SetError(txtA, "ERROR! Wartość A nie może wynosić 0!");

                return false;
            }
            else
                errorProvider1.Dispose();

            //sprawdzenie czy wartość B została wpisana
            if (string.IsNullOrEmpty(txtB.Text.Trim()))
            {
                //zapalenie errorProvider
                errorProvider1.SetError(txtB, "ERROR! Wpisz współczynnik 'b'!");
                return false;
            }
            else
                errorProvider1.Dispose();

            //pobranie współczynnika B
            if (!float.TryParse(txtB.Text, out moB))
            {
                //sygnalizujemy, jeżeli błąd
                errorProvider1.SetError(txtB, "ERROR! W zapisie występuje niepoprawny znak!");

                //zwrócenie informacji o błędzie 
                return false;
            }
            else
                errorProvider1.Dispose();

            //sprawdzenie czy wartość C została wpisana
            if (string.IsNullOrEmpty(txmo.Text.Trim()))
            {
                //zapalenie errorProvider
                errorProvider1.SetError(txmo, "ERROR! Wpisz współczynnik 'b'!");
                return false;
            }
            else
                errorProvider1.Dispose();

            //pobranie współczynnika C
            if (!float.TryParse(txmo.Text, out moC))
            {
                //sygnalizujemy, jeżeli błąd
                errorProvider1.SetError(txmo, "ERROR! W zapisie występuje niepoprawny znak!");

                //zwrócenie informacji o błędzie 
                return false;
            }
            else
                errorProvider1.Dispose();

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

            txtA.ReadOnly = true;
            txtB.ReadOnly = true;
            txmo.ReadOnly = true;
            txtXd.ReadOnly = true;
            txtXg.ReadOnly = true;
            txtH.ReadOnly = true;
            //zwrócenie przekazanych danych, bez wykrytych błędów

            return true;
        }

        void moTablicowanieWartosciFx(float moA, float moB, float moC, float moXd, float moXg, float moh, out float[,] moTWFx)
        {
            moTWFx = null;

            //wyznaczenie liczby podprzedziałów

            int n = (int)((moXg - moXd) / moh) + 1;

            //utworzenie egzemplarza tablicy TWS 
            moTWFx = new float[n, 3];

            float moX; //zmienna niezależna X
            int i; //numer podprzedziału

            for (moX = moXd, i = 0; i < moTWFx.GetLength(0); i++, moX = moX + i * moh)
            {
                moTWFx[i, 0] = i;
                moTWFx[i, 1] = moX;
                moTWFx[i, 2] = moObliczenieRownaniaKwadratowego(moA, moB, moC, moX);
            }

        }

        void moPrzepiszDoDataGridView(float[,] moTWFx, ref DataGridView dgvTWFx)
        {
            //deklaracja odstępu
            const ushort moDist = 100;

            //lokalizacja kontrolki na formularzu
            dgvTWFx.Location = new Point(label1.Left + 150, label1.Top + moDist);
            dgvTWFx.Width = (int)(this.Width * 0.4F);
            dgvTWFx.Height = (int)(this.Height * 0.6F);

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

        private void AnalizatorLaboratoryjny_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
