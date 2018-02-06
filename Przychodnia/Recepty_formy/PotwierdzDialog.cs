using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przychodnia.Recepty_formy
{
    public partial class PotwierdzDialog : Form
    {
       private int generated;
       private Random rand;
        private string komunikat = "";
        public string Komunikat { get => komunikat; set => komunikat = value; }
        private void Generuj()
        {
            rand = new Random();
            generated = rand.Next(10, 100);
            wygenL.Text = generated.ToString();
        }
        public PotwierdzDialog()
        {
            InitializeComponent();
            Generuj();

        }
        public PotwierdzDialog(string komunikat)
        {
            InitializeComponent();
            this.komunikat = komunikat;
            Generuj();
            komL.Text = komunikat;
            komL.Show();
        }

        private void potwDialog_Click(object sender, EventArgs e)
        {
            int wpisane = 0;
            if (Int32.TryParse(this.checnumT.Text, out wpisane))
            {
                if (wpisane == generated)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Liczba różni się od wyświetlanej", "Błąd", MessageBoxButtons.OK);
                    this.DialogResult = DialogResult.Abort;
                }
            }
            else
            {
                MessageBox.Show("Niepoprawnie wpisana liczba", "Błąd", MessageBoxButtons.OK);
                this.DialogResult = DialogResult.Abort;
            }
              
        }

        private void anlulujDialog_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
            this.Dispose();
        }
    }
}
