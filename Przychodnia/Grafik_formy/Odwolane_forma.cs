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
    public partial class Odwolane_forma : Form
    {
        List<Odwolane> lista;
        Pacjent pac;
        string ImieNazwPac;
        public Odwolane_forma()
        {
            InitializeComponent();
            OdswiezTabele();
        }

        private void OdswiezTabele()
        {
            OdwolaneTabela.Rows.Clear();
            lista = Odwolane.PobierzWszystkieOdwolaneWiztyty();

            int i = 0;
            foreach(Odwolane odwolane in lista)
            {
                pac = Pacjent.PobierzPacjenta(odwolane.Id_pacjenta);
                ImieNazwPac = pac.Imie + " " + pac.Nazwisko;
                OdwolaneTabela.Rows.Insert(i, odwolane.Id_odwolania, pac.Pesel, ImieNazwPac, odwolane.ImieNazwisko, odwolane.Specjalalizacja, odwolane.Dzien_od);
                i++;
            }
            
        }
    }
}
