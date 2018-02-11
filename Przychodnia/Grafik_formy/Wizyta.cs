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
namespace Przychodnia.Grafik_formy
{
    public partial class Wizyta : Form
    {
        Grafik graf;
        Lekarz lek;
        public Wizyta()
        {
            InitializeComponent();
        }
        public Wizyta(int ID_grafiku, string Pacjent,int ID_lekarza)
        {
            InitializeComponent();
         //   pac = Pacjent.PobierzPacjenta(ID_pacjenta);
            lek = Lekarz.PobierzLekarza(ID_lekarza);
            graf = Grafik.PobierzGrafik(ID_grafiku);
            label1.Text = "PACJENT: " +Pacjent;
            label2.Text = "LEKARZ: " + lek.Imie + " " + lek.Nazwisko;
        }
        private void Wizyta_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // Opis Wiztyty 
        {
            if (Opis.Text == null || Opis.Text == "" || Opis.Text.Length < 5)
            {
                MessageBox.Show("Opis jest zbyt krótki!","Błąd");
                return;
            }
            Grafik.ZaaktualizcujOpisWizyty(graf.ID, lek.ID, Opis.Text);
            this.Hide();
            this.Dispose();
        }

        private void WypRecpt_Click(object sender, EventArgs e)
        {
            var dodrecpt = new Recepty_formy.DodajRecepte_Form();
            dodrecpt.Show();
        }
    }
}
