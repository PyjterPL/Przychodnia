using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Przychodnia.Obiekty_Bazy;

namespace Przychodnia.Obiekty_Bazy
{
    class Pacjent
    {
        public int? ID { get; private set; }
        public string Pesel { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public DateTime DataUrodzenia { get; set; }
        public string Adres { get; set; }
        public int IdMiasta { get; set; }
        public string Telefon { get; set; }
        public char Plec { get; set; }
        public int IdLekarza { get; set; }
        public string NazwaMiasta { get; set; }
        public Lekarz LekarzProwadzacy{ get; set; }

        public Pacjent(int? id,string pesel,string imie,string nazwisko,DateTime dataur,string adres,int idmiasta,string telefon,char plec, int idlekarza)
        {
            this.ID = id;
            this.Pesel = pesel;
            this.Imie = imie;
            this.Nazwisko = nazwisko;
            this.DataUrodzenia = dataur;
            this.Adres = adres;
            this.IdMiasta = idmiasta;
            this.Telefon = telefon;
            this.Plec = plec;
            this.IdLekarza = idlekarza;
            this.NazwaMiasta = Miasto.PobierzMiasto(idmiasta);
            this.LekarzProwadzacy = Lekarz.PobierzLekarza(IdLekarza);
        }
        public static List<Pacjent> PobierzWszystkichPacjentow()
        {
            int id;
            string pesel;
            string imie;
            string nazwisko;
            DateTime dataurodzenia;
            string adres;
            int idmiasta;
            string telefon;
            char plec;
            int idlekarza;

            var pacjenci = new List<Pacjent>();

            var zapytanie = "SELECT * FROM pacjenci";
            var komenda = new MySqlCommand(zapytanie, DbHelper.Polaczenie);

            DbHelper.Polaczenie.Open();

            var reader = komenda.ExecuteReader();
            while(reader.Read())
            {

                id = (int)reader["Id_pacjenta"];
                pesel = reader["Pesel"].ToString();
                imie = reader["Imie"].ToString();
                nazwisko = reader["Nazwisko"].ToString();
                dataurodzenia = (DateTime)reader["Data_urodzenia"];
                adres = reader["Adres"].ToString();
                idmiasta = (int)reader["Id_miasta"];
                telefon = reader["Telefon"].ToString();
                plec = char.Parse(reader["Plec"].ToString());
                idlekarza = (int)reader["Id_lekarza"];

                var pacjent = new Pacjent(id, pesel, imie, nazwisko, dataurodzenia, adres, idmiasta, telefon, plec, idlekarza);
                pacjenci.Add(pacjent);
            }
            DbHelper.Polaczenie.Close();
            return pacjenci;
        }

        public static void DodajPacjenta(Pacjent pacjent)
        {
            var zapytanie = string.Format("INSERT INTO pacjenci VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", null,pacjent.Pesel, pacjent.Imie, pacjent.Nazwisko, pacjent.DataUrodzenia.Date.ToString("yyyy-MM-dd"), pacjent.Adres, pacjent.IdMiasta, pacjent.Telefon,pacjent.Plec,pacjent.IdLekarza);
            var komenda = new MySqlCommand(zapytanie, DbHelper.Polaczenie);

            DbHelper.Polaczenie.Open();

            komenda.ExecuteNonQuery();

            DbHelper.Polaczenie.Close();
        }
    }
}
