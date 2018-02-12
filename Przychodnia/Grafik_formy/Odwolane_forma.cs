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
        List<Pacjent> listaPacjentów;
        Pacjent pac=null;
        ComboboxItem item = null;
       
        string ImieNazwPac;
        public Odwolane_forma()
        {
            InitializeComponent();

            listaPacjentów = Pacjent.PobierzWszystkichPacjentow();
            ComboPacjent.Sorted = true;
            ComboPacjent.DropDownStyle = ComboBoxStyle.DropDown;
            ComboPacjent.AutoCompleteMode = AutoCompleteMode.Suggest;
            ComboPacjent.AutoCompleteSource = AutoCompleteSource.ListItems;

            foreach (Pacjent pac in listaPacjentów)
            {
                item = new ComboboxItem();
                item.Text = pac.Imie + " " + pac.Nazwisko + " " + pac.NazwaMiasta + " " + pac.Telefon;
                item.Value = (int)pac.ID;
                ComboPacjent.Items.Add(item);
            }

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
            /////

        }

        private void Szukaj_Click(object sender, EventArgs e)
        {
            int pacjentIndeks = ComboPacjent.SelectedIndex;
            if ( pacjentIndeks < 0)
            {
                MessageBox.Show("Wybierz Pacjenta!");
                return;
            }
            var pacjentID = (ComboboxItem)ComboPacjent.Items[pacjentIndeks];
            foreach (Pacjent pacj in listaPacjentów)
            {
                if(pacj.ID.Value==(int)pacjentID.Value)
                {
                    pac = pacj; // pacjent z "góry klasy" = pacjent z listy "tutaj" 
                    break;
                }
            }
            if (pac != null)
            {
                lista = Odwolane.PobierzOdwolaneWizytyPacjenta(pac.ID.Value);
                if(lista == null)
                {
                    MessageBox.Show("Dany Pacjent nie posiada odwolanych wizyt");
                    return;
                }
                OdwolaneTabela.Rows.Clear();
                int i = 0;
                foreach (Odwolane odwolane in lista)
                {
                    OdwolaneTabela.Rows.Insert(i, odwolane.Id_odwolania, pac.Pesel, ImieNazwPac, odwolane.ImieNazwisko, odwolane.Specjalalizacja, odwolane.Dzien_od);
                }
                

            }
            else MessageBox.Show("Błąd Wyszukiwania Pacjenta");
        }

        private void WyczWysz_Click(object sender, EventArgs e)
        {
            OdswiezTabele();
        }
    }
}
