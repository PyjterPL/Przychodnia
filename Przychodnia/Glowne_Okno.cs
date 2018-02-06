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
            lekarzeOkno.Show();
        }

        private void buttonPacienci_Click(object sender, EventArgs e)
        {
            var pacjenciOkno = new Pacjenci_glowne_okno();
            pacjenciOkno.Show();
        }

        private void Wizyty_button_Click(object sender, EventArgs e)
        {
            var grafik =new Grafik_formy.Grafik_glowna_forma();
            grafik.Show();
        }

        private void Recepty_Button_Click(object sender, EventArgs e)
        {
            var receptyOkno = new Recepty_formy.ReceptyGlowneOkno();
            receptyOkno.Show();
        }
    }
}
