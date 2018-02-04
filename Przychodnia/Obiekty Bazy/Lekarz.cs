using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Przychodnia.Obiekty_Bazy;
namespace Przychodnia
{
    class Lekarz
    {
        public int ID { get; private set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public DateTime DataUrodzenia { get; set; }
        public string Adres { get; set; }
        public int IdMiasta { get; set; }
        public string Telefon { get; set; }

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
