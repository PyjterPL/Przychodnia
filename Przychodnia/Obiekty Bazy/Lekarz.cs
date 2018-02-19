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

        public static Lekarz PobierzLekarza(int? index)
        {
            if(index == null)
            {
                return new Lekarz("Brak","Brak", new DateTime(), "", 0, "");
            }
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
             return new Lekarz("Brak", "", new DateTime(), "", 0, ""); ;

        }
        public static void DodajLekarza(Lekarz lekarz)
        {
            

            var zapytanie = "INSERT INTO lekarze VALUES(@null,@lekarz.imie,@lekarz.nazwisko,@lekarz.dataurodzenia,@lekarz.adres,@lekarz.idmiasta,@lekarz.telefon)";
           
            
            //,null, lekarz.Imie, lekarz.Nazwisko, lekarz.DataUrodzenia.Date.ToString("yyyy-MM-dd"), lekarz.Adres, lekarz.IdMiasta,lekarz.Telefon);
            var komenda = new MySqlCommand(zapytanie, DbHelper.Polaczenie);
            komenda.Parameters.AddWithValue("@null", null);
            komenda.Parameters.AddWithValue("@lekarz.imie", lekarz.Imie);
            komenda.Parameters.AddWithValue("@lekarz.nazwisko", lekarz.Nazwisko);
            komenda.Parameters.AddWithValue("@lekarz.dataurodzenia", lekarz.DataUrodzenia.Date.ToString("yyyy-MM-dd"));
            komenda.Parameters.AddWithValue("@lekarz.adres", lekarz.Adres);
            komenda.Parameters.AddWithValue("@lekarz.idmiasta", lekarz.IdMiasta);
            komenda.Parameters.AddWithValue("@lekarz.telefon", lekarz.Telefon);
            DbHelper.Polaczenie.Open();

            komenda.ExecuteNonQuery();

            DbHelper.Polaczenie.Close();
        }

        public static void EdytujLekarza(Lekarz lekarz)
        {
            var zapytanie = "UPDATE lekarze SET Imie=@lekarz.imie,Nazwisko=@lekarz.nazwisko,Data_urodzenia=@lekarz.dataurodzenia,Adres=@lekarz.adres,Id_miasta=@lekarz.idmiasta,Telefon=@lekarz.telefon WHERE Id_lekarza=@lekarz.id ";
          //  , lekarz.Imie, lekarz.Nazwisko, lekarz.DataUrodzenia.Date.ToString("yyyy-MM-dd"), lekarz.Adres, lekarz.IdMiasta, lekarz.Telefon,lekarz.ID);
            var komenda = new MySqlCommand(zapytanie, DbHelper.Polaczenie);
            komenda.Parameters.AddWithValue("@lekarz.id", lekarz.ID);
            komenda.Parameters.AddWithValue("@lekarz.imie", lekarz.Imie);
            komenda.Parameters.AddWithValue("@lekarz.nazwisko", lekarz.Nazwisko);
            komenda.Parameters.AddWithValue("@lekarz.dataurodzenia", lekarz.DataUrodzenia.Date.ToString("yyyy-MM-dd"));
            komenda.Parameters.AddWithValue("@lekarz.adres", lekarz.Adres);
            komenda.Parameters.AddWithValue("@lekarz.idmiasta", lekarz.IdMiasta);
            komenda.Parameters.AddWithValue("@lekarz.telefon", lekarz.Telefon);
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
