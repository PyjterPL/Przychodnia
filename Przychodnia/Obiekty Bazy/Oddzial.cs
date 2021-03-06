﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Przychodnia.Obiekty_Bazy
{
    public class Oddzial
    {
        //  private int IdOdzialu;
        ///  private int IdSpecjalizacji;
        //private int IdLekarza;

        public int IdOdzialu { get; set; }
        public int IdSpecjalizacji { get; set; }
        public int IdLekarza { get; set; }

        Oddzial(int IdOdzialu, int IdSpecjalizacji, int idLekarza)
        {
            this.IdLekarza = idLekarza;
            this.IdOdzialu = IdOdzialu;
            this.IdSpecjalizacji = IdSpecjalizacji;
        }



        public static List<Oddzial> PobierzWszystkieOddzialy()
        {

            int pOddzial;
            int pSpecjalizacja;
            int pLekarz;

            var oddzialy = new List<Oddzial>();
            var zapytanie = "SELECT * FROM oddzialy";
            var komenda = new MySqlCommand(zapytanie, DbHelper.Polaczenie);

            DbHelper.Polaczenie.Open();
            var reader = komenda.ExecuteReader();

            while (reader.Read())
            {
                pOddzial = (int)reader["Id_oddzialu"];
                pSpecjalizacja = (int)reader["Id_Specjalizacji"];
                pLekarz = (int)reader["Id_lekarza"];

                var oddzial = new Oddzial(pOddzial, pSpecjalizacja, pLekarz);
                oddzialy.Add(oddzial);

            }
            DbHelper.Polaczenie.Close();
            return oddzialy;
        }

        public static Oddzial PobierzOddzial(int index) // w razie potrzeby można zrobić dodatkowe werjse tej metody
        {
            int pOddzial;
            int pSpecjalizacja;
            int pLekarz;

            var oddzialy = new List<Oddzial>();
            var zapytanie = string.Format("SELECT * FROM oddzialy WHERE Id_oddzialu='{0}'", index);
            var komenda = new MySqlCommand(zapytanie, DbHelper.Polaczenie);

            Oddzial oddzial = null;

            DbHelper.Polaczenie.Open();
            var reader = komenda.ExecuteReader();

            if (reader.Read())
            {
                pOddzial = (int)reader["Id_oddzialu"];
                pSpecjalizacja = (int)reader["Id_Specjalizacji"];
                pLekarz = (int)reader["Id_lekarza"];

                oddzial = new Oddzial(pOddzial, pSpecjalizacja, pLekarz);
                DbHelper.Polaczenie.Close();
                return oddzial;
            }
            DbHelper.Polaczenie.Close();
            return null;
        }
        public static Oddzial PobierzOddzialLekarza(int idlekarza,int idspecjalizacji)
        {
            var zapytanie = string.Format("SELECT * FROM oddzialy WHERE Id_lekarza='{0}' AND Id_specjalizacji='{1}'", idlekarza,idspecjalizacji);

            var komenda = new MySqlCommand(zapytanie, DbHelper.Polaczenie);
            DbHelper.Polaczenie.Open();
            var reader = komenda.ExecuteReader();
            if (reader.Read())
            {
                var oddzial = new Oddzial((int)reader["Id_oddzialu"], idspecjalizacji, idlekarza);
                DbHelper.Polaczenie.Close();
                return oddzial;
            }
            DbHelper.Polaczenie.Close();
            return null;
        }
        public static List<Oddzial> PobierzOddzialyLekarza(int ID)
        {
            int pOddzial;
            int pSpecjalizacja;
            int pLekarz;

            var lista = new List<Oddzial>();
            var zapytanie = string.Format("SELECT * FROM oddzialy WHERE Id_lekarza='{0}'", ID);

            var komenda = new MySqlCommand(zapytanie, DbHelper.Polaczenie);

            DbHelper.Polaczenie.Open();
            var reader = komenda.ExecuteReader();

            while (reader.Read())
            {
                pOddzial = (int)reader["Id_oddzialu"];
                pSpecjalizacja = (int)reader["Id_Specjalizacji"];
                pLekarz = (int)reader["Id_lekarza"];

                var oddzial = new Oddzial(pOddzial, pSpecjalizacja, pLekarz);
                lista.Add(oddzial);

            }
            DbHelper.Polaczenie.Close();
            return lista;
        }

        public static void DodajOddzial(int id_spec, int id_lek)
        {

            var zapytanie = "INSERT INTO oddzialy VALUES(@null,@id_spec,@id_lek";//, null, id_spec, id_lek);
            var komenda = new MySqlCommand(zapytanie, DbHelper.Polaczenie);
            komenda.Parameters.AddWithValue("@null", null);
            komenda.Parameters.AddWithValue("@id_spec", id_spec);
            komenda.Parameters.AddWithValue("@id_lek", id_lek);

            DbHelper.Polaczenie.Open();
            komenda.ExecuteNonQuery();
            DbHelper.Polaczenie.Close();
        }
        public static void UsunOddzial(int index)
        {
            var zapytanie = string.Format("DELETE FROM oddzialy WHERE Id_oddzialu='{0}' ", index);
            var komenda = new MySqlCommand(zapytanie, DbHelper.Polaczenie);

            DbHelper.Polaczenie.Open();
            komenda.ExecuteNonQuery();
            DbHelper.Polaczenie.Close();
        }


    }
}