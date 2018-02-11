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
    public partial class ReceptyGlowneOkno : Form
    {
        private List<Recepta> listaRecept;
        private Lekarz lekarz;
        private Pacjent pac;
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


            foreach (Recepta recept in listaRecept)
            {
                lekarz = Lekarz.PobierzLekarza(recept.ID_lekarza);
                pac = Pacjent.PobierzPacjenta(recept.ID_pacjenta);
                if (recept.ID_grafiku == null)
                {
                    ReceptyTabela.Rows.Insert(i, recept.ID_recepty, recept.ID_lekarza, lekarz.Nazwisko, "-", pac.Pesel, pac.Imie + " " + pac.Nazwisko, recept.Data_waznosci.ToString("yyyy-MM-dd"), recept.Tresc);
                }
                else ReceptyTabela.Rows.Insert(i, recept.ID_recepty, recept.ID_lekarza, lekarz.Nazwisko, recept.ID_grafiku, pac.Pesel, pac.Imie + " " + pac.Nazwisko, recept.Data_waznosci.ToString("yyyy-MM-dd"), recept.Tresc);
                i++;
            }


        }


        private void UsuRecpt_Click(object sender, EventArgs e)
        {
         var   selectedRow = ReceptyTabela.SelectedRows;
            if (selectedRow.Count > 1)
            {
                var dialogUsunRecpt = new PotwierdzDialog("Uwaga wybrano więcej niż jedną receptę ! ");
                DialogResult dr     = dialogUsunRecpt.ShowDialog();
                SprawdzUsuwanieRecept(dialogUsunRecpt, dr);

            }

            else if (selectedRow.Count == 0)
                MessageBox.Show(this, "Nie wybrano żadnej recepty", "Uwaga", MessageBoxButtons.OK);
            else
            {
                var dialogUsunRecpt = new PotwierdzDialog();
                DialogResult dr = dialogUsunRecpt.ShowDialog();
                SprawdzUsuwanieRecept(dialogUsunRecpt, dr);
            }
              

            

        }

        private void DodRecpt_Click(object sender, EventArgs e)
        {
            var dialogRecept = new DodajRecepte_Form();
            dialogRecept.Show();
        }


        private void SprawdzUsuwanieRecept(PotwierdzDialog obj,DialogResult dr)
        {
        
            if(dr== DialogResult.OK)
            {
                var selectedrows = ReceptyTabela.SelectedRows;
                 for (int i =0;i< selectedrows.Count;i++)
                {
                    int ID_RECEPTY= (int)selectedrows[i].Cells[0].Value;
                    Recepta.UsunReceptę(ID_RECEPTY);
                }

                OdswierzTabele();
            }
            else if (dr==DialogResult.Cancel)
            {
                obj.Hide();
                obj.Dispose();
            }
            else
            {
                string tmp = obj.Komunikat;
                obj.Hide();
                obj.Dispose();
                obj = new PotwierdzDialog(tmp);
                dr = obj.ShowDialog();
                SprawdzUsuwanieRecept(obj, dr);
         
            }
        }

        private void odsiwerz_Click(object sender, EventArgs e)
        {
            OdswierzTabele();
        }
    }

}
