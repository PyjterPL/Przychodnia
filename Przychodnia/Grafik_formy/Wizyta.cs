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
using Przychodnia.Recepty_formy;
namespace Przychodnia.Grafik_formy
{
    public partial class Wizyta : Form
    {
        private Grafik graf;
        private Lekarz lek;
      
        private int ID_grafiku, ID_lekarza;
        string Pacjent;
        public Wizyta()
        {
            InitializeComponent();
        }
        public Wizyta(int ID_grafiku, string Pacjent,int ID_lekarza)
        {
            InitializeComponent();
            //   pac = Pacjent.PobierzPacjenta(ID_pacjenta);
            this.ID_grafiku = ID_grafiku;
            this.ID_lekarza = ID_lekarza;
            this.Pacjent = Pacjent;
            odswierz();
        }
        private void odswierz()
        {
            lek = Lekarz.PobierzLekarza(ID_lekarza);
            graf = Grafik.PobierzGrafik(ID_grafiku);
            label1.Text = "PACJENT: " + Pacjent;
            label2.Text = "LEKARZ: " + lek.Imie + " " + lek.Nazwisko;
            OpisWczesniejszy.Text = graf.Opis;
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
            Grafik.ZaaktualizujOpisWizyty(graf.ID, lek.ID, OpisWczesniejszy.Text+"   \n\n   "+"DATA WIZYTY: "+DateTime.Now.ToString("dd-MM-yy HH:mm")+"\n\n"+Opis.Text);
            odswierz();
        }

        private void edtOp_Click(object sender, EventArgs e) // W tym momencie przestałem mieć siłe
        {
            MessageBox.Show("Uwaga, za chwilę będzisz mógł zmodyfikować PEŁNY opis pacjenta, jeśli usuniesz całą historię, nie bedzie możliwe jej odzyskanie");
            this.Opis.Text = graf.Opis;
            this.OpisWczesniejszy.Text = "";
        }

        private void pokazRcpt_Click(object sender, EventArgs e)
        {
            if (graf.IdPacjenta !=null)
            {
                var histRcpt = new ReceptyGlowneOkno((int)graf.IdPacjenta,graf.IdLekarza);
                histRcpt.Show();
            }
           else
            {
                MessageBox.Show("Nie ma Pacjenta w bazie grafiku", "Błąd Grafiku");
            }
        }

        private void WypRecpt_Click(object sender, EventArgs e)
        {
            var dodrecpt = new Recepty_formy.DodajRecepte_Form();
            dodrecpt.Show();
        }
    }
}
