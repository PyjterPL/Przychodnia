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
namespace Przychodnia.Miasta_formy
{
    public partial class Miasta_glowna_forma : Form
    {
        private List<Miasto> _miasta;
        public Miasta_glowna_forma()
        {
            InitializeComponent();
            _miasta = Miasto.PobierzWszystkieMiasta();
            OdswierzTabele();
           // Tabela.Rows.Add()

        }
        void OdswierzTabele()
        {
            Tabela.Rows.Clear();
            _miasta = Miasto.PobierzWszystkieMiasta();
            int i = 0;
            foreach (Miasto miasto in _miasta)
            {
                Tabela.Rows.Insert(i, miasto.ID, miasto.Nazwa);
                i++;
            }
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            var EdytujMiastoForm = new Dodaj_Edytuj_miasto();
            EdytujMiastoForm.ShowDialog();
            OdswierzTabele();
           
           
        }

        private void buttonEdytuj_Click(object sender, EventArgs e)
        {
            if (Tabela.SelectedRows.Count == 1)
            {
                foreach (DataGridViewRow miasto in this.Tabela.SelectedRows)
                {
                    var ID = (int)miasto.Cells["ID"].Value;
                    var dodajMiastoForm = new Dodaj_Edytuj_miasto(ID);
                    dodajMiastoForm.ShowDialog();
                    OdswierzTabele();
                }
            }
            else
            {
                MessageBox.Show("Zaznacz tylko jedno miasto!");
            }
        }
    }
}
