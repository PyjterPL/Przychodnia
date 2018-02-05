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

        }
    }
}
