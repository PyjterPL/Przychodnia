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

namespace Przychodnia.Grafik_formy
{
    public partial class Wybor_specjalizacji_form : Form
    {
        public Specjalizacja wybrana;
        public Pacjent wybrany_pacjent;
        private List<Specjalizacja> lista_spec;
        private List<Pacjent> lista_pacjentow;
        private bool pacjenci = false;
        public DialogResult res;

        public Wybor_specjalizacji_form(int ID)
        {
            InitializeComponent();
            lista_spec = Specjalizacja.PobierzWszystkieSpecjalizacjeLekarza(ID);
            this.comboBox1.Items.Add("Nie wybieraj");
            foreach (var specjalizacja in lista_spec)
            {
                this.comboBox1.Items.Add(specjalizacja.nazwa);
            }
            this.comboBox1.SelectedIndex = 0;
        }
        public Wybor_specjalizacji_form()
        {
            InitializeComponent();
            pacjenci = true;
            lista_pacjentow = Pacjent.PobierzWszystkichPacjentow();//Specjalizacja.PobierzWszystkieSpecjalizacjeLekarza(ID);
                                                                   // this.comboBox1.Items.Add("Nie wybieraj");
            foreach (var pacjent in lista_pacjentow)
            {
                this.comboBox1.Items.Add(pacjent.Imie + " " + pacjent.Nazwisko);
            }
            this.comboBox1.SelectedIndex = 0;
        }

        private void Wybierz_button_Click(object sender, EventArgs e)
        {
            var nazwa = this.comboBox1.Text;
            if (pacjenci)
            {
                // var nazwa = this
                var id = lista_pacjentow.First(i => i.Imie + " " + i.Nazwisko == nazwa).ID;
                wybrany_pacjent = Pacjent.PobierzPacjenta((int)id);
            }
            else
            {

                if (nazwa == "Nie wybieraj")
                {
                    wybrana = new Specjalizacja(-1, "");
                }
                else
                {
                    var id = lista_spec.First(i => i.nazwa == nazwa).ID_specjalizacji;
                    wybrana = new Specjalizacja(id, nazwa);
                }
            }
            this.Close();
        }

        private void Anuluj_button_Click(object sender, EventArgs e)
        {
            wybrany_pacjent = null;
            wybrana = null;
            this.Close();
        }
    }
}