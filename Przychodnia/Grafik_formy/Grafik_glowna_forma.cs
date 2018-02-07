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
            this.lekarz_comboBox.SelectedIndex = 0;
            
        }
       public  void Odswierz()
        {
            var ID = _lekarze.First(i => i.Imie + " " + i.Nazwisko == this.lekarz_comboBox.Text).ID;
            var lista = Grafik.PobierzGrafikDleLekarza(ID);
            foreach (Grafik grafik in lista)
            {
                if (grafik.Dzien_od.Date == dateTimePicker1.Value.Date)
                {
                    foreach (DataGridViewRow row in this.Tabela.Rows)
                    {
                        var godzina = TimeSpan.Parse(row.Cells["Godzina"].Value.ToString());
                        if (godzina == grafik.Dzien_od.TimeOfDay)
                        {
                            Tabela.Rows[row.Index].SetValues(grafik.ID, grafik.Dzien_od.TimeOfDay.ToString(), grafik.IdPacjenta, grafik.Opis, grafik.IdOddzialu);
                            if (grafik.IdPacjenta == 0)
                            {
                                row.DefaultCellStyle.BackColor = Color.Green;
                            }
                            else
                            {
                                row.DefaultCellStyle.BackColor = Color.Red;
                            }
                        }
                    }
                }
            }
        }

        private void Pokaz_button_Click(object sender, EventArgs e)
        {
            Odswierz();
        }

        private void Dodaj_godzin_button_Click(object sender, EventArgs e)
        {
            if (Tabela.SelectedRows.Count > 0)
            {
                

                var ID = _lekarze.First(i => i.Imie + " " + i.Nazwisko == this.lekarz_comboBox.Text).ID;
                var spec_form = new Wybor_specjalizacji_form(ID);
                spec_form.ShowDialog();
                if (spec_form.wybrana == null) return;
                
                var lista = Grafik.PobierzGrafikDleLekarza(ID);
                foreach (DataGridViewRow row in this.Tabela.SelectedRows)
                    {
                        var wybrana_data_godzina = this.dateTimePicker1.Value.Date + TimeSpan.Parse(row.Cells["Godzina"].Value.ToString());

                        var znalezione = lista.Find(i => i.Dzien_od == wybrana_data_godzina);
                        if (znalezione != null)
                        {
                            MessageBox.Show("W zaznaczonych godzinach jest już ustalony grafik!");
                            return;
                        }
                            var godzina = TimeSpan.Parse(row.Cells["Godzina"].Value.ToString());
                    }
                foreach (DataGridViewRow row in this.Tabela.SelectedRows)
                {
                    var wybrana_data_godzina = this.dateTimePicker1.Value.Date + TimeSpan.Parse(row.Cells["Godzina"].Value.ToString());
                    
                    var godzina = TimeSpan.Parse(row.Cells["Godzina"].Value.ToString());
                    if (spec_form.wybrana.ID_specjalizacji > 0)
                    {
                        Grafik.DodajGrafik(new Grafik(0, ID, wybrana_data_godzina, null, "", spec_form.wybrana.ID_specjalizacji));
                    }else
                    {
                        Grafik.DodajGrafik(new Grafik(0, ID, wybrana_data_godzina, null, "", null));
                    }
                }
                MessageBox.Show("Dodano godziny do grafiku!");
                Odswierz();
            }
        }
    }
}
