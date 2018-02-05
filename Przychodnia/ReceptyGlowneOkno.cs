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
using Przychodnia.DialogRecepty;
namespace Przychodnia
{
    public partial class ReceptyGlowneOkno : Form
    {
        private List<Recepta> listaRecept;

        public ReceptyGlowneOkno()
        {
            InitializeComponent();
            OdswierzTabele();
        }
        void OdswierzTabele()
        {
            ReceptyTabela.Rows.Clear();
            listaRecept = Recepta.PobierzWszystkieRecepty();
            int i = 0;
            foreach(Recepta recept in listaRecept)
            {
                ReceptyTabela.Rows.Insert(i, recept.ID_recepty, recept.ID_lekarza, recept.ID_pacjenta, recept.ID_grafiku, recept.Data_waznosci,recept.Tresc );
                i++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DodRecpt_Click(object sender, EventArgs e)
        {
            var dialogRecept = new DodRecepte();
            dialogRecept.Show();
        }

        private void UsuRecpt_Click(object sender, EventArgs e)
        {
            var selectedRow = ReceptyTabela.SelectedRows;
            if (selectedRow.Count > 1)
                MessageBox.Show(this, "Uwaga wybrano więcej niż jedną receptę ! Czy na pewno chcesz wszystkie usunąć ? ", "Uwaga !", MessageBoxButtons.OK);
                
            if (selectedRow.Count == 0)
                MessageBox.Show(this, "Nie wybrano żadnej recepty", "Uwaga", MessageBoxButtons.OK);
        }
    }
}
