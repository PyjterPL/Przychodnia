using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Przychodnia.Obiekty_Bazy
{
   public class Specjalizacja
    {


        public int ID_specjalizacji { get; set; }
        public string nazwa { get; set; }
        public Specjalizacja(int id_spec, string nazwa)
        {
            this.ID_specjalizacji = id_spec;
            this.nazwa = nazwa;
        }

        public static List<Specjalizacja> PobierzWszystkieSpecjalizacje()
        {
            int pId_specjalizacji;
            string pNazwa;
            List<Specjalizacja> lista = new List<Specjalizacja>();

            var zapytanie = "SELECT * FROM specjalizacja";
            var komenda = new MySqlCommand(zapytanie, DbHelper.Polaczenie);

            DbHelper.Polaczenie.Open();
            var reader = komenda.ExecuteReader();
            

            while(reader.Read())
            {
                pId_specjalizacji = (int)reader["Id_specjalizacji"];
                pNazwa            = (string)reader["Nazwa"];

                var specjalizacja = new Specjalizacja(pId_specjalizacji, pNazwa);
                lista.Add(specjalizacja);
            }
            DbHelper.Polaczenie.Close();
            return lista;
        }

        public static void DodajSpecjalizacje(string NazwaSpec)
        {
            var zapytanie = string.Format("INSERT INTO specjalizacja VALUES('{0}','{1}')", null, NazwaSpec);
            var komenda = new MySqlCommand(zapytanie, DbHelper.Polaczenie);

            DbHelper.Polaczenie.Open();
            komenda.ExecuteNonQuery();
            DbHelper.Polaczenie.Close();
        }
        public static void UsunSpecjalizacje(string NazwaSpec)
        {
            var zapytanie = string.Format("DELETE FROM specjalizacja WHERE Nazwa='{0}'",  NazwaSpec);
            var komenda = new MySqlCommand(zapytanie, DbHelper.Polaczenie);

            DbHelper.Polaczenie.Open();
            komenda.ExecuteNonQuery();
            DbHelper.Polaczenie.Close();
        }
        public static Specjalizacja PobierzSpecjalizacje(int ID)
        {
            int pId_specjalizacji;
            string pNazwa;
            

            var zapytanie = string.Format("SELECT * FROM specjalizacja WHERE Id_specjalizacji='{0}'",ID);
            var komenda = new MySqlCommand(zapytanie, DbHelper.Polaczenie);

            DbHelper.Polaczenie.Open();
            var reader = komenda.ExecuteReader();
            DbHelper.Polaczenie.Close();

            if (reader.Read())
            {
                pId_specjalizacji = (int)reader["Id_specjalizacji"];
                pNazwa = (string)reader["Nazwa"];

                var specjalizacja = new Specjalizacja(pId_specjalizacji, pNazwa);
                
                return specjalizacja;
            }
            return null;
        }
        public static List<Specjalizacja> PobierzWszystkieSpecjalizacjeLekarza(int ID)
        {
            int pId_specjalizacji;
            string pNazwa;
            var lista = new List<Specjalizacja>();

            var zapytanie = string.Format("SELECT s.Id_specjalizacji, s.Nazwa FROM specjalizacja S INNER JOIN oddzialy O ON o.Id_specjalizacji=s.Id_specjalizacji WHERE o.Id_lekarza='{0}'",ID);

            var komenda = new MySqlCommand(zapytanie, DbHelper.Polaczenie);

            DbHelper.Polaczenie.Open();
            var reader = komenda.ExecuteReader();
            

            while (reader.Read())
            {
                pId_specjalizacji = (int)reader["Id_specjalizacji"];
                pNazwa = (string)reader["Nazwa"];

                var specjalizacja = new Specjalizacja(pId_specjalizacji, pNazwa);
                lista.Add(specjalizacja);
            }
            DbHelper.Polaczenie.Close();
            return lista;
        }
    }
}
