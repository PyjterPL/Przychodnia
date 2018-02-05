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

namespace Przychodnia.DialogRecepty
{
    public partial class DodRecepte : Form
    {
        private List<Lekarz> listaLekarzy;
        
        private ComboboxItem item;
        public DodRecepte()
        {
            InitializeComponent();
            

            listaLekarzy = Lekarz.PobierzWszystkichLekarzy();
            ComboLekarz.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboLekarz.Sorted = true;
            foreach(Lekarz lek in listaLekarzy)
            {
                item = new ComboboxItem();
                item.Text = lek.Imie + " " + lek.Nazwisko + " " + lek.NazwaMiasta + " " + lek.Telefon;
                item.Value = lek.ID;
                ComboLekarz.Items.Add(item);
            }
            // To do: Pacjenci 


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DodajRecepteDialog_Click(object sender, EventArgs e)
        {
            var lekarz = (Lekarz)ComboLekarz.SelectedItem;

            var tresc = TrescR.Text;

        }

        private void AnulujRecepteDialog_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
