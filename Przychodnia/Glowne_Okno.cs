using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Przychodnia.Pacjenci_formy;
using Przychodnia.Recepty_formy;
using Przychodnia.OddzialySpecjalizacje_formy;
namespace Przychodnia
{
    public partial class Okno_glowne : Form
    {//test 
        public Okno_glowne()
        {
            InitializeComponent();
        }

        private void buttonLekarze_Click(object sender, EventArgs e)
        {
            var lekarzeOkno = new LekarzeGlowneOkno();
            lekarzeOkno.ShowDialog();
        }

        private void buttonPacienci_Click(object sender, EventArgs e)
        {
            var pacjenciOkno = new Pacjenci_glowne_okno();
            pacjenciOkno.ShowDialog();
        }

        private void Wizyty_button_Click(object sender, EventArgs e)
        {
            var grafik =new Grafik_formy.Grafik_glowna_forma();
            grafik.ShowDialog();
        }

        private void Recepty_Button_Click(object sender, EventArgs e)
        {
            var receptyOkno = new Recepty_formy.ReceptyGlowneOkno();
            receptyOkno.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var SpecOdzOkno = new OddzialySpecjalizacje_formy.OdzSpecGlowneOkno();
            SpecOdzOkno.ShowDialog();
        }

        private void buttonMiasta_Click(object sender, EventArgs e)
        {
            var MiastaOkno = new Miasta_formy.Miasta_glowna_forma();
            MiastaOkno.ShowDialog();
        }
    }
}
