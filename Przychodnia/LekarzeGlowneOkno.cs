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
                Tabela.Rows.Insert(i, lekarz.ID, lekarz.Imie, lekarz.Nazwisko, lekarz.DataUrodzenia.Date.ToString(), lekarz.Adres,
                    lekarz.IdMiasta, lekarz.Telefon);
                i++;
            }
        }

        private void Usun_Click(object sender, EventArgs e)
        {
            if (Tabela.SelectedRows.Count > 0)
            {
               var decyzja = MessageBox.Show("Czy na pewno chcesz usunąć zaznaczone?", "Usuwanie lekarzy", MessageBoxButtons.YesNo);
               if(decyzja == DialogResult.Yes)
                {
                    foreach(DataGridViewRow lekarz in this.Tabela.SelectedRows)
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


    }
}
