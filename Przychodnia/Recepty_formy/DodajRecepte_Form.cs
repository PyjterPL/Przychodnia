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
namespace Przychodnia.Recepty_formy
{
    public partial class DodajRecepte_Form : Form
    {
        private List<Lekarz> listaLekarzy;
        private List<Pacjent> listaPacjentów;
        private List<Grafik> listaGrafikow;
        private ComboboxItem item;
        private Lekarz lekarz = null;
        private Pacjent pacjent = null;

        public DodajRecepte_Form()
        {
            InitializeComponent();


            listaLekarzy = Lekarz.PobierzWszystkichLekarzy();
            listaPacjentów = Pacjent.PobierzWszystkichPacjentow();

            ComboPacjent.Sorted = true;
            ComboLekarz.Sorted = true;
            ComboPacjent.DropDownStyle = ComboBoxStyle.DropDown;
            ComboLekarz.DropDownStyle = ComboBoxStyle.DropDown;
            ComboPacjent.AutoCompleteMode = AutoCompleteMode.Suggest;
            ComboLekarz.AutoCompleteMode = AutoCompleteMode.Suggest;
            ComboLekarz.AutoCompleteSource = AutoCompleteSource.ListItems;
            ComboPacjent.AutoCompleteSource = AutoCompleteSource.ListItems;

            foreach (Lekarz lek in listaLekarzy)
            {
                item = new ComboboxItem();
                item.Text = lek.Imie + " " + lek.Nazwisko + " " + lek.NazwaMiasta + " " + lek.Telefon;
                item.Value = lek.ID;
                ComboLekarz.Items.Add(item);
            }
            foreach (Pacjent pac in listaPacjentów)
            {
                item = new ComboboxItem();
                item.Text = pac.Imie + " " + pac.Nazwisko + " " + pac.NazwaMiasta + " " + pac.Telefon;
                item.Value = (int)pac.ID;
                ComboPacjent.Items.Add(item);
            }
           // ComboLekarz.DropDownStyle = ComboBoxStyle.DropDownList;
          //  ComboPacjent.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public DodajRecepte_Form(int ID_Pacjenta, int ID_Lekarza) 
        {
            InitializeComponent();

            listaLekarzy = Lekarz.PobierzWszystkichLekarzy();
            listaPacjentów = Pacjent.PobierzWszystkichPacjentow();

            ComboPacjent.Sorted = true;
            ComboLekarz.Sorted = true;
            ComboPacjent.DropDownStyle = ComboBoxStyle.DropDown;
            ComboLekarz.DropDownStyle = ComboBoxStyle.DropDown;
            ComboPacjent.AutoCompleteMode = AutoCompleteMode.Suggest;
            ComboLekarz.AutoCompleteMode = AutoCompleteMode.Suggest;
            ComboLekarz.AutoCompleteSource = AutoCompleteSource.ListItems;
            ComboPacjent.AutoCompleteSource = AutoCompleteSource.ListItems;

           // ComboLekarz.DropDownStyle = ComboBoxStyle.DropDownList;
          //  ComboPacjent.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (Lekarz lek in listaLekarzy)
            {
                item = new ComboboxItem();
                item.Text = lek.Imie + " " + lek.Nazwisko + " " + lek.NazwaMiasta + " " + lek.Telefon;
                item.Value = lek.ID;
                ComboLekarz.Items.Add(item);
            }
            foreach (Pacjent pac in listaPacjentów)
            {
                item = new ComboboxItem();
                item.Text = pac.Imie + " " + pac.Nazwisko + " " + pac.NazwaMiasta + " " + pac.Telefon;
                item.Value = (int)pac.ID;
                ComboPacjent.Items.Add(item);
            }

            // wybieranie odpowiednich indeksow w komoboxach 
            int i = 0;
            foreach (ComboboxItem it in ComboLekarz.Items)
            {
                var lekarzID = (ComboboxItem)ComboLekarz.Items[i];
                if ((int)lekarzID.Value == ID_Lekarza)
                {
                    ComboLekarz.SelectedIndex = i;
                }
                else i++;
            }
            i = 0;
            foreach (ComboboxItem it in ComboPacjent.Items)
            {
                var PacjentID = (ComboboxItem)ComboPacjent.Items[i];
                if ((int)PacjentID.Value == ID_Pacjenta)
                {
                    ComboPacjent.SelectedIndex = i;
                }
                else i++;
            }

        }
        private void DodajRecepteDialog_Click(object sender, EventArgs e)
        {

            var dataW = DataWaznosci.Value.Date;
            int lekarzIndeks = ComboLekarz.SelectedIndex;
            int pacjentIndeks = ComboPacjent.SelectedIndex;
            if (lekarzIndeks < 0 || pacjentIndeks < 0)
            {
                MessageBox.Show("Wybierz Lekarza Oraz Pacjenta!");
                return;
            }
            if (Tresc.Text == null || Tresc.Text == "" || Tresc.Text.Length < 5)
            {
                MessageBox.Show("Recepta Pusta lub zbyt krótka");
                return;
            }
            var lekarzID = (ComboboxItem)ComboLekarz.Items[lekarzIndeks];
            var pacjentID = (ComboboxItem)ComboPacjent.Items[pacjentIndeks];
            Grafik grafik = null;

            foreach (Lekarz lek in listaLekarzy)
            {
                if (lek.ID == (int)lekarzID.Value)
                {
                    lekarz = lek;
                    listaGrafikow = Grafik.PobierzGrafikDleLekarza(lek.ID);

                    foreach (Grafik graf in listaGrafikow)
                    {
                        if (graf.IdLekarza == lekarz.ID)
                        {
                            grafik = graf;
                            break;
                        }
                    }
                    break;
                }
            }
            foreach (Pacjent pac in listaPacjentów)
            {
                if (pac.ID.Value == (int)pacjentID.Value)
                {
                    pacjent = pac;
                    break;
                }
            }

            if (lekarz != null && pacjent != null && grafik != null)
            {

                Recepta.DodajRecepte(lekarz.ID, pacjent.ID.Value, grafik.ID, Tresc.Text, dataW);
                MessageBox.Show("Dodano Receptę !");
                this.Hide();
                this.Dispose();
            }
            else if (lekarz != null && pacjent != null)
            {
                Recepta.DodajRecepte(lekarz.ID, pacjent.ID.Value, null, Tresc.Text, dataW);
                MessageBox.Show("Dodano Receptę !");
                this.Hide();
                this.Dispose();
            }
            else MessageBox.Show("Wystąpił błąd !");


        }

        private void ComboLekarz_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboLekarz_TextChanged(object sender, EventArgs e)
        {




        }
    }
}
