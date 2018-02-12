using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Przychodnia.Obiekty_Bazy;


namespace Przychodnia.Lekarze_formy
{
    public partial class Dodaj_lekarza_form : Form
    {
        private List<Miasto> _miasta;
        bool edycja = false;
        Lekarz lekarz;
        public Dodaj_lekarza_form()
        {
            InitializeComponent();
            _miasta = Miasto.PobierzWszystkieMiasta();
            foreach(var miasto in _miasta)
            {
                this.Miasto_combobox.Items.Add(miasto.Nazwa);
            }
            this.Miasto_combobox.SelectedIndex = 0;   
        }
        public Dodaj_lekarza_form(int index)//edycja
        {
            InitializeComponent();
            edycja = true;

            _miasta = Miasto.PobierzWszystkieMiasta();
            foreach (var miasto in _miasta)
            {
                this.Miasto_combobox.Items.Add(miasto.Nazwa);
            }
            this.Text = "Edycja danych";
            lekarz = Lekarz.PobierzLekarza(index);
            this.Imie_textbox.Text = lekarz.Imie;
            this.Nazwisko_textbox.Text = lekarz.Nazwisko;
            this.DataUrodzenia_dtpicker.Value = lekarz.DataUrodzenia;
            this.Adres_textbox.Text = lekarz.Adres;

            this.Miasto_combobox.Text = lekarz.NazwaMiasta;
            this.Telefon_texbox.Text = lekarz.Telefon;

            this.Dodaj_button.Text = "Edytuj";
        }

        private bool SprawdzPoprawnoscPola()
        {
            if(Imie_textbox.Text.Length<3 || Nazwisko_textbox.Text.Length<3)
            {
                MessageBox.Show("Imię lub Nazwisko jest nieprawidłowe", "Błąd");
                return false;
                
            }
            return true;
        } // proste zabezpieczenie, sprawdza długosc stringa ktory jest pobierany z textboxa

        private void Anuluj_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dodaj_button_Click(object sender, EventArgs e)
        {
            if (edycja)
            {
                if (SprawdzPoprawnoscPola() == false) return;
                var imie = this.Imie_textbox.Text;
                var nazwisko = this.Nazwisko_textbox.Text;
                var data = this.DataUrodzenia_dtpicker.Value;
                var adres = this.Adres_textbox.Text;
                var miasto = this.Miasto_combobox.Text;
                var id_miasta = _miasta.First(i => i.Nazwa == miasto).ID;
                if (CzyCiagJestNumerem(Telefon_texbox.Text) == true)
                {
                    var telefon = this.Telefon_texbox.Text;
                    Lekarz.EdytujLekarza(new Lekarz(lekarz.ID, imie, nazwisko, data, adres, id_miasta, telefon));
                    MessageBox.Show("Edytowano lekarza!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Podaj poprawny numer telefonu bez znaków specjalnych oraz liter", "Błąd");
                    return;
                }
               
            }
            else
            {
                if (SprawdzPoprawnoscPola() == false) return;
                var imie = this.Imie_textbox.Text;
                var nazwisko = this.Nazwisko_textbox.Text;
                var data = this.DataUrodzenia_dtpicker.Value;
                var adres = this.Adres_textbox.Text;
                var miasto = this.Miasto_combobox.Text;
                var id_miasta = _miasta.First(i => i.Nazwa == miasto).ID;
                if (CzyCiagJestNumerem(Telefon_texbox.Text) == true)
                {
                    var telefon = this.Telefon_texbox.Text;
                    Lekarz.DodajLekarza(new Lekarz(imie, nazwisko, data, adres, id_miasta, telefon));
                    MessageBox.Show("Dodano lekarza!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Podaj poprawny numer telefonu bez znaków specjalnych oraz liter", "Błąd");
                    return;
                }
            }
        }

        private bool CzyCiagJestNumerem(string ciag)
        {
            for (int i =0;i< ciag.Length;i++)
            {
            if(!char.IsDigit(ciag[i]))
              {
                    return false;
              }
            }
            return true;
        }
        private void Telefon_texbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
