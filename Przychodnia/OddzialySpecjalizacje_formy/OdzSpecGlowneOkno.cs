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

namespace Przychodnia.OddzialySpecjalizacje_formy
{
    public partial class OdzSpecGlowneOkno : Form
    {
        private List<Specjalizacja> listaSpecjalizacji;
        public OdzSpecGlowneOkno()
        {
            InitializeComponent();
            OdswiezTabele();
          
        }

        void OdswiezTabele()
        {
            SpecjalizacjeTabela.Rows.Clear();

            listaSpecjalizacji = Specjalizacja.PobierzWszystkieSpecjalizacje();
            int i = 0;
            foreach (Specjalizacja spec in listaSpecjalizacji)
            {
               
                SpecjalizacjeTabela.Rows.Insert(i, spec.ID_specjalizacji, spec.nazwa);
                i++;
            }
        }

        private void DodSpec_Click(object sender, EventArgs e)
        {
            var dodajSpec = new DodSpec_Form();
            dodajSpec.Show();
        }

        private void Odswierz_Click(object sender, EventArgs e)
        {
            OdswiezTabele();
        }

        private void UsuSpec_Click(object sender, EventArgs e)
        {
            var selectedRow = SpecjalizacjeTabela.SelectedRows;
            if(selectedRow.Count>1)
            {
                var dialogUsunSpec = new Przychodnia.Recepty_formy.PotwierdzDialog("Uwaga wybrano więcej niż jedną pozycję!");
                DialogResult dr = dialogUsunSpec.ShowDialog();
                SprawdzUsuwanieSpec(dialogUsunSpec, dr);
            }
            else if (selectedRow.Count==0)
                MessageBox.Show(this, "Nie wybrano żadnej pozycji", "Uwaga", MessageBoxButtons.OK);
            else
            {
                var dialogUsunSpec = new Przychodnia.Recepty_formy.PotwierdzDialog();
                DialogResult dr = dialogUsunSpec.ShowDialog();
                SprawdzUsuwanieSpec(dialogUsunSpec, dr);
            }
        }

        private void SprawdzUsuwanieSpec(Przychodnia.Recepty_formy.PotwierdzDialog obj, DialogResult dr)
        {

            if (dr == DialogResult.OK)
            {
                var selectedrows = SpecjalizacjeTabela.SelectedRows;
                for (int i = 0; i < selectedrows.Count; i++)
                {
                    string NAZWA_SPECJALIZACJI = (string)selectedrows[i].Cells[1].Value;
                    Specjalizacja.UsunSpecjalizacje(NAZWA_SPECJALIZACJI);
                }

                OdswiezTabele();
            }
            else if (dr == DialogResult.Cancel)
            {
                obj.Hide();
                obj.Dispose();
            }
            else
            {
                string tmp = obj.Komunikat;
                obj.Hide();
                obj.Dispose();
                obj = new Przychodnia.Recepty_formy.PotwierdzDialog(tmp);
                dr = obj.ShowDialog();
                SprawdzUsuwanieSpec(obj, dr);

            }
        }
    }
}
