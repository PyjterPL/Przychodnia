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
        private int tryb=0;
        private int ID;
        public DodSpec_Form()
        {
            InitializeComponent();
        }
        public DodSpec_Form(int id)
        {
            InitializeComponent();
            tryb = 1;
            ID = id;
            TekstL.Text = "Edytuj nazwę specjalizacji ";
        
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DodSpecB_Click(object sender, EventArgs e)
        {
            if(SpecT.Text =="" || SpecT.Text.Length <3)
            {
                MessageBox.Show("Nazwa Specjalizacji nie moze byc pusta ani krótsza niz 3 znaki ","Błąd");
                return;
            }
            for (int i =0;i<SpecT.Text.Length; i++)
            {
                if (SpecT.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("Nazwa Specjalizacji nie moze zawierać cyfr", "Błąd");
                    return; 
                }
            }
            if (tryb==0)
            {
                Specjalizacja.DodajSpecjalizacje(SpecT.Text);
            }
           else if (tryb==1)
            {
                Specjalizacja.EdytujSpecjalizacje(ID, SpecT.Text);
            }
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
