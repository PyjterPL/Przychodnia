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
namespace Przychodnia.Recepty_formy
{
    public partial class DodajRecepte_Form : Form
    {
        private List<Lekarz> listaLekarzy;
        private List<Pacjent> listaPacjentów;
        private ComboboxItem item;
        public DodajRecepte_Form()
        {
            InitializeComponent();


            listaLekarzy = Lekarz.PobierzWszystkichLekarzy();
            listaPacjentów = Pacjent.PobierzWszystkichPacjentow();
            ComboPacjent.Sorted = true;
            ComboLekarz.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboLekarz.Sorted = true;
            foreach (Lekarz lek in listaLekarzy)
            {
                item = new ComboboxItem();
                item.Text = lek.Imie + " " + lek.Nazwisko + " " + lek.NazwaMiasta + " " + lek.Telefon;
                item.Value = lek.ID;
                ComboLekarz.Items.Add(item);
            }
            foreach(Pacjent pac in listaPacjentów)
            {
                item = new ComboboxItem();
                item.Text = pac.Imie + " " + pac.Nazwisko + " " + pac.NazwaMiasta + " " + pac.Telefon;
                item.Value = (int)pac.ID;
                ComboPacjent.Items.Add(item);
            }
        }

        private void DodajRecepteDialog_Click(object sender, EventArgs e)
        {
           var dataW           = DataWaznosci.Value.Date;
           int lekarzIndeks    = ComboLekarz.SelectedIndex;
           int pacjentIndeks   = ComboPacjent.SelectedIndex;
           var lekarzID        = (ComboboxItem)ComboLekarz.Items[lekarzIndeks];
           var pacjentID       = (ComboboxItem)ComboPacjent.Items[pacjentIndeks];
           Lekarz lekarz=null;
           Pacjent pacjent=null;
           
            foreach( Lekarz lek in listaLekarzy)
            {
               
                if (lek.ID == (int)lekarzID.Value)
                {
                 
                    lekarz = lek;
                    break;
                }
            }
            foreach( Pacjent pac in listaPacjentów)
            {
                MessageBox.Show(pac.ID + " " + pac.Nazwisko);
                if (pac.ID.Value==(int)pacjentID.Value)
                {
                    
                  
                    pacjent = pac;
                    break;
                }
            }
            if (lekarz != null && pacjent != null)
            {
                MessageBox.Show("Jestem w IF !");
                Recepta.DodajRecepte(lekarz.ID,pacjent.ID.Value, 1, Tresc.Text, dataW);
                MessageBox.Show("Dodano Receptę !");
            }
     

        }
    }
}
