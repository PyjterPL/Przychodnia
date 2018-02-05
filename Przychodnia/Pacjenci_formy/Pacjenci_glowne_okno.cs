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
    }
}
