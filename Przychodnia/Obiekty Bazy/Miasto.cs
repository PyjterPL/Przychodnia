using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Przychodnia.Obiekty_Bazy
{
    class Miasto
    {
        public int ID { get; private set; }
        public string Nazwa { get; private set; }

        public Miasto(int id, string nazwa)
        {
            this.ID = id;
            this.Nazwa = nazwa;
        }
        public static List<Miasto> PobierzWszystkieMiasta()
        {
            int id;
            string nazwa;          
            var miasta = new List<Miasto>();

            var zapytanie = "SELECT * FROM miasta";
            var komenda = new MySqlCommand(zapytanie, DbHelper.Polaczenie);

            DbHelper.Polaczenie.Open();

            var reader = komenda.ExecuteReader();

            while (reader.Read())
            {
                id = (int)reader["Id_miasta"];
                nazwa = reader["Nazwa"].ToString();

                var miasto = new Miasto(id, nazwa);

                miasta.Add(miasto);
            }
            DbHelper.Polaczenie.Close();
            return miasta;
        }
        public static void DodajMiasto(string nazwa)
        {
            var zapytanie = string.Format("INSERT INTO miasta(Nazwa) VALUES('{0}')",nazwa);
            var komenda = new MySqlCommand(zapytanie, DbHelper.Polaczenie);

            DbHelper.Polaczenie.Open();

            komenda.ExecuteNonQuery();

            DbHelper.Polaczenie.Close();
        }
        public static void EdytujMiasto(int id,string nazwa)
        {
            var zapytanie = string.Format("UPDATE miasta SET Nazwa='{0}' WHERE Id_miasta='{1}' ", nazwa, id);
           
            var komenda = new MySqlCommand(zapytanie, DbHelper.Polaczenie);

            DbHelper.Polaczenie.Open();

            komenda.ExecuteNonQuery();

            DbHelper.Polaczenie.Close();
        }
        public static string PobierzMiasto(int id)
        {
            var polaczenie = DbHelper.StworzPolaczenie();
            var zapytanie = string.Format("SELECT Nazwa FROM miasta WHERE Id_miasta={0}",id);
            var komenda = new MySqlCommand(zapytanie, polaczenie);

            polaczenie.Open();
            
            var reader = komenda.ExecuteReader();

           if(reader.Read())
            {
                var nazwa =  reader["Nazwa"].ToString();
                polaczenie.Close();
                return nazwa;
            }
           else
            {
                polaczenie.Close();
                return string.Empty;
            }
           
        }
        public static Miasto PobierzMiastoObjekt(int id)
        {
            var polaczenie = DbHelper.StworzPolaczenie();
            var zapytanie = string.Format("SELECT * FROM miasta WHERE Id_miasta={0}", id);
            var komenda = new MySqlCommand(zapytanie, polaczenie);

            polaczenie.Open();

            var reader = komenda.ExecuteReader();

            if (reader.Read())
            {
                var nazwa = reader["Nazwa"].ToString();
                var ID = (int)reader["Id_miasta"];
                polaczenie.Close();
                var miasto = new Miasto(ID, nazwa);
                return miasto;
            }
            else
            {
                polaczenie.Close();
                return null;
            }

        }
    }
}
