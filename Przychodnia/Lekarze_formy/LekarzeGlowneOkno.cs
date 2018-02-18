using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Przychodnia;
using Przychodnia.Lekarze_formy;
using Przychodnia.Obiekty_Bazy;
namespace Przychodnia
{
    public partial class LekarzeGlowneOkno : Form
    {
        private List<Lekarz> listaLekarzy;
        public LekarzeGlowneOkno()
        {
            InitializeComponent();
            OdswierzTabele();
        }
        void OdswierzTabele()
        {
            Tabela.Rows.Clear();
            listaLekarzy = Lekarz.PobierzWszystkichLekarzy();
            int i = 0;
            foreach (Lekarz lekarz in listaLekarzy)
            {
                Tabela.Rows.Insert(i, lekarz.ID, lekarz.Imie, lekarz.Nazwisko, lekarz.DataUrodzenia.Date.ToString("yyyy-MM-dd"), lekarz.Adres,
                    lekarz.NazwaMiasta, lekarz.Telefon);
                i++;
            }
        }
        private void Usun_Click(object sender, EventArgs e)
        {
            if (Tabela.SelectedRows.Count > 0)
            {
               var decyzja = MessageBox.Show("Czy na pewno chcesz usunąć zaznaczone?", "Usuwanie lekarzy", MessageBoxButtons.YesNo);
               if(decyzja == DialogResult.Yes)//sprawdzic, czy lekarz ma umówione wizyty w grafiku i czy są jakieś w odwołanych
                {
                    foreach (DataGridViewRow lekarz in this.Tabela.SelectedRows)
                    {
                        var ID = (int)lekarz.Cells["ID"].Value;
                        var lista_wizyt=  Grafik.PobierzGrafikDleLekarza(ID);
                        if (lista_wizyt.Count > 0)
                        {
                            MessageBox.Show("Nie można usunąć lekarza gdyż ma jeszcze umówione wizyty. Odwołaj napierw wizyty");
                            return;
                        }

                    }

                    foreach (DataGridViewRow lekarz in this.Tabela.SelectedRows)
                    {
                        var index = lekarz.Index;
                        var ID = (int)lekarz.Cells["ID"].Value;
                        
                        Tabela.Rows.RemoveAt(index);
                        Lekarz.UsunLekarza(ID);
                    }
                }
                OdswierzTabele();
            }
        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            var dodawanie = new Dodaj_lekarza_form();
            dodawanie.ShowDialog();
            OdswierzTabele();
        }

        private void Edytuj_Click(object sender, EventArgs e)
        {
            if (Tabela.SelectedRows.Count == 1)
            {
                    foreach (DataGridViewRow lekarz in this.Tabela.SelectedRows)
                    {
                        //var index = lekarz.Index;
                        var ID = (int)lekarz.Cells["ID"].Value;
                        var edycja = new Dodaj_lekarza_form(ID);
                    edycja.ShowDialog();
                    }    
            }
            OdswierzTabele();
        }

        private void Odswierz_Click(object sender, EventArgs e)
        {
            OdswierzTabele();
        }
    }
}
