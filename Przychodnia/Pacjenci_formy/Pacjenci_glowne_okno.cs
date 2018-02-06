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
    public partial class Pacjenci_glowne_okno : Form
    {
        private List<Pacjent> _pacjenci;
        public Pacjenci_glowne_okno()
        {
            InitializeComponent();
            OdswierzTabele();

        }
        void OdswierzTabele()
        {
            Tabela.Rows.Clear();
            _pacjenci = Pacjent.PobierzWszystkichPacjentow();
            int i = 0;
            foreach (Pacjent pacjent in _pacjenci)
            {
                Tabela.Rows.Insert(i, pacjent.ID, pacjent.Pesel, pacjent.Imie, pacjent.Nazwisko, pacjent.DataUrodzenia.Date.ToString("yyyy-MM-dd"), pacjent.Adres, pacjent.NazwaMiasta,
                    pacjent.Telefon,pacjent.Plec,pacjent.LekarzProwadzacy.Imie +" " + pacjent.LekarzProwadzacy.Nazwisko);
                i++;
            }
        }

        private void DodajButton_Click(object sender, EventArgs e)
        {
            var dodajForm =new Dodaj_edytuj_pacjenta_forma();
            dodajForm.Show();
        }

        private void Odswierz_Click(object sender, EventArgs e)
        {
            OdswierzTabele();
        }

        private void Usun_Click(object sender, EventArgs e)
        {
            if (Tabela.SelectedRows.Count > 0)
            {
                var decyzja = MessageBox.Show("Czy na pewno chcesz usunąć zaznaczone?", "Usuwanie pacjentów", MessageBoxButtons.YesNo);
                if (decyzja == DialogResult.Yes)
                {
                    foreach (DataGridViewRow pacjent in this.Tabela.SelectedRows)
                    {
                        var index = pacjent.Index;
                        var ID = (int)pacjent.Cells["ID"].Value;

                        Tabela.Rows.RemoveAt(index);
                        Pacjent.UsunPacjenta(ID);
                    }
                }
                OdswierzTabele();
            }
        }

        private void Edytuj_Click(object sender, EventArgs e)
        {
            if (Tabela.SelectedRows.Count == 1)
            {
                foreach (DataGridViewRow pacjent in this.Tabela.SelectedRows)
                {
                    //var index = lekarz.Index;
                    var ID = (int)pacjent.Cells["ID"].Value;
                    var edycja = new Dodaj_edytuj_pacjenta_forma(ID);
                    edycja.Show();
                }
            }
            OdswierzTabele();
        }
    }
}
