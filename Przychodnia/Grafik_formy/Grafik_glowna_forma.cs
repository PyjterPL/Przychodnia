﻿using System;
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
        ComboboxItem item;
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
                Tabela.Rows.Insert(i, null, data.TimeOfDay, null, null, null);
                data = data.AddMinutes(15);
                i++;
            }
            _lekarze = Lekarz.PobierzWszystkichLekarzy();
            foreach (Lekarz lekarz in _lekarze)
            {
                item = new ComboboxItem();
                item.Text = lekarz.Imie + " " + lekarz.Nazwisko;
                item.Value = lekarz.ID;
                this.lekarz_comboBox.Items.Add(item);
            }
            this.lekarz_comboBox.SelectedIndex = 0;
            Odswierz();

        }
        public void Odswierz()
        {
            var ID = _lekarze.First(i => i.Imie + " " + i.Nazwisko == this.lekarz_comboBox.Text).ID;
            var lista = Grafik.PobierzGrafikDleLekarza(ID);
            this.Tabela.Rows.Clear();
            var data = this.dateTimePicker1.Value;
            var ts = new TimeSpan(0, 0, 0);
            data = data.Date + ts;
            var dzien = this.dateTimePicker1.Value.Day;
            int x = 0;
            while (data.Day == dzien)
            {
                Tabela.Rows.Insert(x, null, data.TimeOfDay, null, null, null);
                data = data.AddMinutes(15);
                x++;
            }
            foreach (Grafik grafik in lista)
            {
                if (grafik.Dzien_od.Date == dateTimePicker1.Value.Date)
                {
                    foreach (DataGridViewRow row in this.Tabela.Rows)
                    {
                        var godzina = TimeSpan.Parse(row.Cells["Godzina"].Value.ToString());
                        if (godzina == grafik.Dzien_od.TimeOfDay)
                        {
                            Tabela.Rows[row.Index].SetValues(grafik.ID, grafik.Dzien_od.TimeOfDay.ToString(), grafik.NazwaPacjent, grafik.Opis, grafik.NazwaSpecjalizacji);
                            if (grafik.IdPacjenta == 0 || grafik.IdPacjenta==null)
                            {
                                row.DefaultCellStyle.BackColor = Color.Green;
                            }
                            else
                            {
                                row.DefaultCellStyle.BackColor = Color.Red;
                            }
                            break;

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
                    try // Zabezpieczenie przed dodawaniem godzin " w Przeszłość" 
                    {
                        if (spec_form.wybrana.ID_specjalizacji > 0)
                        {
                            var oddzial = Obiekty_Bazy.Oddzial.PobierzOddzialLekarza(ID, spec_form.wybrana.ID_specjalizacji);
                            Grafik.DodajGrafik(new Grafik(0, ID, wybrana_data_godzina, null, "", oddzial.IdOdzialu));//Id oddziału zamiast id specjalizacju!
                        }
                        else
                        {
                            Grafik.DodajGrafik(new Grafik(0, ID, wybrana_data_godzina, null, "", null));
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Nie można dodawać godzin pracy w przeszłości", "Błąd");
                        DbHelper.Polaczenie.Close();
                        return;
                    }

                }
                MessageBox.Show("Dodano godziny do grafiku!");
                Odswierz();
            }
        }

        private void Odwolaj_godziny_button_Click(object sender, EventArgs e)
        {
            if (Tabela.SelectedRows.Count > 0)
            {
                var decyzja = MessageBox.Show("Czy na pewno chcesz usunąć zaznaczone?", "Usuwanie lekarzy", MessageBoxButtons.YesNo);
                if (decyzja == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in this.Tabela.SelectedRows)
                    {
                        if (row.Cells["ID"].Value == null)
                        {
                            MessageBox.Show("Zaznaczono godziny, które są puste!");
                            return;
                        }
                        if (row.Cells["Pacjent"].Value != null)
                        {
                            MessageBox.Show("Najpierw odwołaj wizyty!");
                            return;
                        }
                    }

                    try
                    {
                        foreach (DataGridViewRow row in Tabela.SelectedRows)
                        {
                            var id = (int)row.Cells["ID"].Value;
                            Grafik.UsunGrafik(id);  // tutaj try catch
                        }
                        Odswierz();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        DbHelper.Polaczenie.Close();
                    }
                }
            }
        }

        private void Umow_button_Click(object sender, EventArgs e)
        {
            if (Tabela.SelectedRows.Count > 0)
            {

                foreach (DataGridViewRow row in this.Tabela.SelectedRows)
                {
                    if (row.Cells["ID"].Value == null)
                    {
                        MessageBox.Show("Zaznaczono godziny, które są puste!");
                        return;
                    }
                    if (row.Cells["Pacjent"].Value != null)
                    {
                        MessageBox.Show("Godziny są zajęte");
                        return;
                    }
                }
                var wybor_pacjenta = new Wybor_specjalizacji_form();
                wybor_pacjenta.ShowDialog();
                if (wybor_pacjenta.wybrany_pacjent == null) return;

                foreach (DataGridViewRow row in this.Tabela.SelectedRows)
                {
                    Grafik.UmowWizyte((int)wybor_pacjenta.wybrany_pacjent.ID, (int)row.Cells["ID"].Value);
                }
                MessageBox.Show("Umówiono wizytę");
                Odswierz();
            }
        }

        private void Odwolaj_button_Click(object sender, EventArgs e)
        {
            if (Tabela.SelectedRows.Count > 0)
            {

                foreach (DataGridViewRow row in this.Tabela.SelectedRows)
                {
                    if (row.Cells["ID"].Value == null)
                    {
                        MessageBox.Show("Zaznaczono godziny, które są puste!");
                        return;
                    }
                    if (row.Cells["Pacjent"].Value == null)
                    {
                        MessageBox.Show("Zaznaczone godziny są wolne!");
                        return;
                    }
                }
                // Może powodować błędy choć nie powinno 
                try
                {
                    foreach (DataGridViewRow row in this.Tabela.SelectedRows)
                    {
                        var grafik = Grafik.PobierzGrafik((int)row.Cells["ID"].Value);
                        Grafik.OdwolajWizyte((int)row.Cells["ID"].Value); // Rzuci wyjątkiem jeśli sprobuje się usunąć przeszłą wizytę 
                        Odwolane.DodajOdwolanie(grafik, row.Cells["Oddzial"].Value.ToString());
                    }
                    MessageBox.Show("Odwołano!");
                    Odswierz();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nie można odwoływać przeszłych wizyt", "Błąd");
                    return;
                }
            }
        }

        private void lekarz_comboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Odswierz();
        }

        private void OdwWizyty_Click(object sender, EventArgs e)
        {
            // tutaj forma na odwołane wizyty 
            var odwolaneOkno = new Odwolane_forma();
            odwolaneOkno.Show();
        }

        private void wizyta_Click(object sender, EventArgs e)
        {
            var SelectedRow = Tabela.SelectedRows;

            if (SelectedRow.Count <= 0)
            {
                MessageBox.Show("Zaznacz Wizytę ", "Błąd");
                return;
            }
            if (SelectedRow.Count > 1)
            {
                MessageBox.Show("Zaznacz jedną wizytę", "Błąd");
                return;
            }

            try
            {
                int ID_Grafiku = (int)SelectedRow[0].Cells[0].Value;
                string Pacjent = (string)SelectedRow[0].Cells[2].Value;
                if (string.IsNullOrEmpty(Pacjent))
                {
                    MessageBox.Show("Na Daną godzinę nie ma umówionego Pacjenta! ", "Błąd");
                    return;
                }
                var SelectedComboIndex = lekarz_comboBox.SelectedIndex;
                var ID_lekarzaComboItem = (ComboboxItem)lekarz_comboBox.Items[SelectedComboIndex]; // obiekt ComboBoxItem który zawiera string -> Imię i nazwisko oraz Value -> ID Lekarza
                int ID_lekarza = (int)ID_lekarzaComboItem.Value;
                var WizytaOkno = new Wizyta(ID_Grafiku, Pacjent, ID_lekarza);
                WizytaOkno.Show();
            }
            catch (System.NullReferenceException ex)
            {
                MessageBox.Show("Zaznacz umówioną wizytę!", "Błąd");
            }

        }

        private void lekarz_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Odswierz();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Zmieniono date");
            Odswierz();
        }
    }
}