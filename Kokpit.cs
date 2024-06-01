using Projekt2_WindowsForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektNr2_WindowsForm
{
    public partial class Kokpit : Form
    {
        public Kokpit()
        {
            InitializeComponent();
        }

        private void btnAnalizatorLaboratoryjny_Click(object sender, EventArgs e)
        {
            // sprawdzenie czy egzemplarz formularza AnalizatorLaboratoryjny byl juz utworzony
            foreach (Form moFormularzZnaleziony in Application.OpenForms)
                // sprawdzenie czy to jest poszukiwany formularz
                if (moFormularzZnaleziony.Name == "AnalizatorLaboratoryjny")
                {
                    //ukrycie bieżącego formularza
                    this.Hide();
                    //odsłonięcie formularza znalezionego
                    moFormularzZnaleziony.Show();
                    //koniec obsługi zdarzenia "click"
                    return;
                }
            // formularz "AnalizatorLaboratoryjny" nie został znaleziony 
            // tworzymy egzemplarz formularza "AnalizatorLaboratoryjny"
            AnalizatorLaboratoryjny moFormAnalizatorLaboratoryjny = new AnalizatorLaboratoryjny();

            //ukrycie "starego" formularza
            this.Hide();

            //odsłonięcie (wyświetlenie nowego formularza)
            moFormAnalizatorLaboratoryjny.Show();

        }

        private void btnAnalizatorIndywidualny_Click(object sender, EventArgs e)
        {
            // sprawdzenie czy egzemplarz formularza AnalizatorLaboratoryjny byl juz utworzony
            foreach (Form moFormularzZnaleziony in Application.OpenForms)
                // sprawdzenie czy to jest poszukiwany formularz
                if (moFormularzZnaleziony.Name == "AnalizatorIndywidualny")
                {
                    //ukrycie bieżącego formularza
                    this.Hide();
                    //odsłonięcie formularza znalezionego
                    moFormularzZnaleziony.Show();
                    //koniec obsługi zdarzenia "click"
                    return;
                }
            // formularz "AnalizatorIndywidualny" nie został znaleziony 
            // tworzymy egzemplarz formularza "AnalizatorIndywidualny"
            AnalizatorIndywidualny moFormAnalizatorIndywidualny = new AnalizatorIndywidualny();

            //ukrycie "starego" formularza
            this.Hide();

            //odsłonięcie (wyświetlenie nowego formularza)
            moFormAnalizatorIndywidualny.Show();

        }

        private void btnsprawdzian_Click(object sender, EventArgs e)
        {
            // sprawdzenie czy egzemplarz formularza AnalizatorLaboratoryjny byl juz utworzony
            foreach (Form moFormularzZnaleziony in Application.OpenForms)
                // sprawdzenie czy to jest poszukiwany formularz
                if (moFormularzZnaleziony.Name == "sprawdzian2")
                {
                    //ukrycie bieżącego formularza
                    this.Hide();
                    //odsłonięcie formularza znalezionego
                    moFormularzZnaleziony.Show();
                    //koniec obsługi zdarzenia "click"
                    return;
                }
            // formularz "AnalizatorIndywidualny" nie został znaleziony 
            // tworzymy egzemplarz formularza "AnalizatorIndywidualny"
            sprawdzian2 moFormsprawdzian2 = new sprawdzian2();

            //ukrycie "starego" formularza
            this.Hide();

            //odsłonięcie (wyświetlenie nowego formularza)
            moFormsprawdzian2.Show();

        }
    }
}
