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
    public partial class DodSpec_Form : Form
    {
        public DodSpec_Form()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DodSpecB_Click(object sender, EventArgs e)
        {
            Specjalizacja.DodajSpecjalizacje(SpecT.Text);
            this.Hide();
            this.Dispose();
        }

        private void AnSpecB_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }
    }
}
