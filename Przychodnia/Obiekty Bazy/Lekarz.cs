using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Przychodnia.Obiekty_Bazy;
namespace Przychodnia
{
   public class Lekarz
    {
        public int ID { get; private set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public DateTime DataUrodzenia { get; set; }
        public string Adres { get; set; }
        public int IdMiasta { get; set; }
        public string Telefon { get; set; }
        public string NazwaMiasta { get; set; }

        public Lekarz(int id,string imie,string nazwisko,DateTime dataUrodzenia,string adres,int idmiasta,string telefon)
        {
            //TODO: walidacja id miasta (czy istniele w bazie)
            this.ID = id;
            this.Imie = imie;
            this.Nazwisko = nazwisko;
            this.DataUrodzenia = dataUrodzenia;
            this.Adres = adres;
            this.IdMiasta = idmiasta;
            this.Telefon = telefon;
            this.NazwaMiasta = Miasto.PobierzMiasto(idmiasta);
        }
        public Lekarz( string imie, string nazwisko, DateTime dataUrodzenia, string adres, int idmiasta, string telefon)
        {
            this.Imie = imie;
            this.Nazwisko = nazwisko;
            this.DataUrodzenia = dataUrodzenia;
            this.Adres = adres;
            this.IdMiasta = idmiasta;
            this.Telefon = telefon;
            this.NazwaMiasta = Miasto.PobierzMiasto(idmiasta);
        }
        public static List<Lekarz> PobierzWszystkichLekarzy()
        {
            int id;
            string imie;
            string nazwisko;
            DateTime dataUrodzenia;
            string adres;
            int idMiasta;
            string telefon;


            var lekarze = new List<Lekarz>();

            var zapytanie = "SELECT * FROM lekarze";
            var komenda = new MySqlCommand(zapytanie, DbHelper.Polaczenie);

            DbHelper.Polaczenie.Open();

            var reader = komenda.ExecuteReader();
            
            while(reader.Read())
            {
                id = (int)reader["Id_lekarza"];
                imie = reader["Imie"].ToString();
                nazwisko = reader["Nazwisko"].ToString();
                dataUrodzenia = (DateTime)reader["Data_urodzenia"];
                adres = reader["Adres"].ToString();
                idMiasta = (int)reader["Id_miasta"];
                telefon = reader["Telefon"].ToString();

                var lekarz = new Lekarz(id, imie, nazwisko, dataUrodzenia, adres, idMiasta, telefon);

                lekarze.Add(lekarz);
            }
            DbHelper.Polaczenie.Close();
            return lekarze;

        }

        public static Lekarz PobierzLekarza(int index)
        {
            int id;
            string imie;
            string nazwisko;
            DateTime dataUrodzenia;
            string adres;
            int idMiasta;
            string telefon;

            var polaczenie = DbHelper.StworzPolaczenie();

            var zapytanie = string.Format("SELECT * FROM lekarze WHERE Id_lekarza='{0}'",index);
            var komenda = new MySqlCommand(zapytanie, polaczenie);

            polaczenie.Open();

            var reader = komenda.ExecuteReader();

           if(reader.Read())
            {
                id = (int)reader["Id_lekarza"];
                imie = reader["Imie"].ToString();
                nazwisko = reader["Nazwisko"].ToString();
                dataUrodzenia = (DateTime)reader["Data_urodzenia"];
                adres = reader["Adres"].ToString();
                idMiasta = (int)reader["Id_miasta"];
                telefon = reader["Telefon"].ToString();

                var lekarz = new Lekarz(id, imie, nazwisko, dataUrodzenia, adres, idMiasta, telefon);
                polaczenie.Close();
                return lekarz;
                
            }
            polaczenie.Close();
            return null;

        }
        public static void DodajLekarza(Lekarz lekarz)
        {
            var zapytanie = string.Format("INSERT INTO lekarze VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",null, lekarz.Imie, lekarz.Nazwisko, lekarz.DataUrodzenia.Date.ToString("yyyy-MM-dd"), lekarz.Adres, lekarz.IdMiasta,lekarz.Telefon);
            var komenda = new MySqlCommand(zapytanie, DbHelper.Polaczenie);

            DbHelper.Polaczenie.Open();

            komenda.ExecuteNonQuery();

            DbHelper.Polaczenie.Close();
        }

        public static void EdytujLekarza(Lekarz lekarz)
        {
            var zapytanie = string.Format("UPDATE lekarze SET Imie='{0}',Nazwisko='{1}',Data_urodzenia='{2}',Adres='{3}',Id_miasta='{4}',Telefon='{5}' WHERE Id_lekarza='{6}' "
            , lekarz.Imie, lekarz.Nazwisko, lekarz.DataUrodzenia.Date.ToString("yyyy-MM-dd"), lekarz.Adres, lekarz.IdMiasta, lekarz.Telefon,lekarz.ID);
            var komenda = new MySqlCommand(zapytanie, DbHelper.Polaczenie);

            DbHelper.Polaczenie.Open();

            komenda.ExecuteNonQuery();

            DbHelper.Polaczenie.Close();
        }
        public static void UsunLekarza(int index)
        {
            var zapytanie = string.Format("DELETE FROM lekarze WHERE Id_lekarza={0}",index.ToString());
            var komenda = new MySqlCommand(zapytanie, DbHelper.Polaczenie);

            DbHelper.Polaczenie.Open();

            komenda.ExecuteNonQuery();

            DbHelper.Polaczenie.Close();
        }
    }
}
