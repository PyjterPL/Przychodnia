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
        private List<Specjalizacja> lista_spec;
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

        private void Wybierz_button_Click(object sender, EventArgs e)
        {
            var nazwa = this.comboBox1.Text;
            if (nazwa == "Nie wybieraj")
            {
                wybrana = new Specjalizacja(-1, "");
            }
            else
            {
                var id = lista_spec.First(i => i.nazwa == nazwa).ID_specjalizacji;
                wybrana = new Specjalizacja(id, nazwa);
            }
            this.Close();
        }

        private void Anuluj_button_Click(object sender, EventArgs e)
        {
            wybrana = null;
            this.Close();
        }
    }
}
