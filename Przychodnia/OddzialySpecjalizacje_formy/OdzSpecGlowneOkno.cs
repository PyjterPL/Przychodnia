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
            OdswierzTabele();
          
        }

        void OdswierzTabele()
        {
            SpecjalizacjeTabela.Rows.Clear();

            listaSpecjalizacji = Specjalizacja.PobierzWszystkieSpecjalizacje();
            int i = 0;
            foreach (Specjalizacja spec in listaSpecjalizacji)
            {
                MessageBox.Show(spec.nazwa + " " + spec.ID_specjalizacji);
                SpecjalizacjeTabela.Rows.Insert(i, spec.ID_specjalizacji, spec.nazwa);
                i++;
            }
        }

        private void DodSpec_Click(object sender, EventArgs e)
        {

        }
    }
}
