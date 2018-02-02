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
        public LekarzeGlowneOkno()
        {
            InitializeComponent();
            var listaLekarzy = Lekarz.PobierzWszystkichLekarzy();
            int i = 0;
            foreach (Lekarz lekarz in listaLekarzy)
            {
                Tabela.Rows.Insert(i, lekarz.ID, lekarz.Imie, lekarz.Nazwisko, lekarz.DataUrodzenia.Date.ToString(), lekarz.Adres,
                    lekarz.IdMiasta, lekarz.Telefon);
                    i++;
            }
           
        }

    }
}
