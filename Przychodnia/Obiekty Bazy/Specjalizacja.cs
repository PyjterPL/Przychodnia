using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace Przychodnia.Obiekty_Bazy
{
    class Specjalizacja
    {
        private int Id_specjalizacji;
        private string Nazwa;

        public int ID_specjalizacji { get { return Id_specjalizacji; } set { Id_specjalizacji = value; } }
        public string nazwa { get { return Nazwa; }  set { Nazwa=value; } }



        Specjalizacja(int id_spec, string nazwa)
        {
            this.Id_specjalizacji = id_spec;
            this.Nazwa = nazwa;
        }

        public static List<Specjalizacja> PobierzWszystkieSpecjalizacje()
        {
            int pId_specjalizacji;
            string pNazwa;
            var lista = new List<Specjalizacja>();

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
    }
}
