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
namespace Przychodnia.Miasta_formy
{
    public partial class Dodaj_Edytuj_miasto : Form
    {
        private bool edycja = false;
        private Miasto miasto;
        public Dodaj_Edytuj_miasto()
        {
            InitializeComponent();
        }
        public Dodaj_Edytuj_miasto(int id)//edycja
        {
            InitializeComponent();
            edycja = true;
            miasto = Miasto.PobierzMiastoObjekt(id);
            textBox1.Text = miasto.Nazwa;
        }

        private void DodajEdytujButton_Click(object sender, EventArgs e)
        {
            if (edycja)
            {
                this.DodajEdytujButton.Text = "Edytuj";
                var nazwa = textBox1.Text;
                if (nazwa.Length > 0)
                {
                    Miasto.EdytujMiasto(miasto.ID,nazwa);
                    MessageBox.Show("Edytowano");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nie można dodać pustej nazwy");
                }
            }
            else
            {
                var nazwa = textBox1.Text;
                if (nazwa.Length > 0)
                {
                    Miasto.DodajMiasto(nazwa);
                    MessageBox.Show("Dodano");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nie można dodać pustej nazwy");
                }
            }
        }

        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
