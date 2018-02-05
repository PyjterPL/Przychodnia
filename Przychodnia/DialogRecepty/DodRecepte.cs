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
            item = new ComboboxItem();
            listaLekarzy = Lekarz.PobierzWszystkichLekarzy();
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
