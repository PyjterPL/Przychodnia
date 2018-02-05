using Przychodnia.Obiekty_Bazy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Przychodnia.Pacjenci_formy
{
    public partial class Dodaj_edytuj_pacjenta_forma : Form
    {
        private List<Miasto> _miasta;
        private List<Lekarz> _lekarze;
        private bool edycja = false;
        public Dodaj_edytuj_pacjenta_forma()
        {
            InitializeComponent();
            //dodawnie miast
            _miasta = Miasto.PobierzWszystkieMiasta();
            foreach (var miasto in _miasta)
            {
                this.Miasto_comboBox.Items.Add(miasto.Nazwa);
            }
            this.Miasto_comboBox.SelectedIndex = 0;
            //dodawanie lekarzy
            _lekarze = Lekarz.PobierzWszystkichLekarzy();
            foreach (var lekarz in _lekarze)
            {
                this.LekarzProwadzacy_comboBox.Items.Add(lekarz.Imie + " " + lekarz.Nazwisko);
            }
            this.LekarzProwadzacy_comboBox.SelectedIndex = 0;
            //dodawanie plci
            this.Plec_comboBox.Items.Add("M");
            this.Plec_comboBox.Items.Add("K");
            this.Plec_comboBox.SelectedIndex = 0;
        }

        private void Pesel_textBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Pesel_textBox.Text, "[^0-9]"))
            {
                Pesel_textBox.Text = Pesel_textBox.Text.Remove(Pesel_textBox.Text.Length - 1);
                MessageBox.Show("Pesel zawiera tylko liczby");
                
            }
        }

        private void DodajButton_Click(object sender, EventArgs e)
        {
            if (edycja)
            {
                this.Close();
            }
            else
            {
                var imie = this.Imie_textBox.Text;
                var nazwisko = this.Nazwisko_textBox.Text;
                var data = this.dateTimePicker1.Value;
                var adres = this.Adres_textBox.Text;
                var miasto = this.Miasto_comboBox.Text;
                var id_miasta = _miasta.First(i => i.Nazwa == miasto).ID;
                var pesel = this.Pesel_textBox.Text;
                var telefon = this.Telefon_textBox.Text;
                var plec = char.Parse(this.Plec_comboBox.Text);
                var lekarz = this.LekarzProwadzacy_comboBox.Text;
                var id_lekarza = _lekarze.First(i => i.Imie + " " + i.Nazwisko == lekarz).ID;

                Pacjent.DodajPacjenta(new Pacjent(null,pesel, imie, nazwisko, data, adres, id_miasta, telefon, plec, id_lekarza));
               // Lekarz.DodajLekarza(new Lekarz(imie, nazwisko, data, adres, id_miasta, telefon));
                MessageBox.Show("Dodano pacjenta!");
                this.Close();
            }
        }
    }
}
