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
    public partial class Grafik_glowna_forma : Form
    {
        private List<Lekarz> _lekarze;
        public Grafik_glowna_forma()
        {
            InitializeComponent();
            var data = this.dateTimePicker1.Value;
            var ts = new TimeSpan(0, 0, 0);
            data = data.Date + ts;
            var dzien = this.dateTimePicker1.Value.Day;
            int i = 0;
            while (data.Day == dzien)
            {
                Tabela.Rows.Insert(i, null, data.TimeOfDay,null,null,null);
                data=data.AddMinutes(15);
                i++;
            }
            _lekarze = Lekarz.PobierzWszystkichLekarzy();
            foreach(Lekarz lekarz in _lekarze)
            {
                this.lekarz_comboBox.Items.Add(lekarz.Imie + " " + lekarz.Nazwisko);
            }
            
        }

        private void Pokaz_button_Click(object sender, EventArgs e)
        {

            var ID = _lekarze.First(i => i.Imie + " " + i.Nazwisko == this.lekarz_comboBox.Text).ID;
            var lista = Grafik.PobierzGrafikDleLekarza(ID);
            foreach(Grafik grafik in lista)
            {
                if (grafik.Dzien_od.Date == dateTimePicker1.Value.Date)
                { 
                     foreach(DataGridViewRow row in this.Tabela.Rows)
                    {
                        //var index = lekarz.Index;
                        //var ID = (int)lekarz.Cells["ID"].Value;
                        // var godzina = (DateTime)row.Cells["Godzina"].Value;
                        //  var x = new TimeSpan()
                        var godzina = TimeSpan.Parse(row.Cells["Godzina"].Value.ToString());
                        if (godzina == grafik.Dzien_od.TimeOfDay)
                        {
                            Tabela.Rows[row.Index].SetValues(grafik.ID, grafik.Dzien_od.TimeOfDay.ToString(), grafik.IdPacjenta, grafik.Opis, grafik.IdOddzialu);
                        }
                       // Tabela.Rows.RemoveAt(index);
                        //Lekarz.UsunLekarza(ID);
                    }
                }
            }

        }


    }
}
