using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia.Obiekty_Bazy
{
    class Grafik
    {
        public int ID { get; private set; }
        public int IdLekarza { get; set; }
        public DateTime Dzien_od { get; set; }
        public int? IdPacjenta { get; set; }//może być nullem  
        public string Opis { get; set; }
        public int? IdOddzialu { get; set; }
        public string NazwaPacjent { get; set; }

        public string NazwaSpecjalizacji { get; set; }
        public Grafik(int id,int idlekarza,DateTime dzienod,int? idpacjenta,string opis,int? idodzialu)
        {
            this.ID = id;
            this.IdLekarza = idlekarza;
            this.Dzien_od = dzienod;
            this.IdPacjenta = idpacjenta;
            this.Opis = opis;
            this.IdOddzialu = idodzialu;
            if(IdPacjenta >0 )
            {   
                var pacjent = Pacjent.PobierzPacjenta((int)IdPacjenta);
                NazwaPacjent = pacjent.Imie + " "+ pacjent.Nazwisko;
            }
            if(idodzialu > 0)
            {
                var oddzial = Oddzial.PobierzOddzial((int)idodzialu);
                var specjalizacja = Specjalizacja.PobierzSpecjalizacje(oddzial.IdSpecjalizacji);
                NazwaSpecjalizacji = specjalizacja.nazwa;
            }

           // this.NazwaPacjenta = Pacjent.PobierzPacjenta(IdPacjenta).Imie;
        }
        public static void DodajGrafik(Grafik grafik)
        {
            var zapytanie = string.Format("INSERT INTO grafik VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", null, grafik.IdLekarza, grafik.Dzien_od.ToString("yyyy-MM-dd HH:mm:ss"),grafik.IdPacjenta,grafik.Opis,grafik.IdOddzialu); // lekarz.DataUrodzenia.Date.ToString("yyyy-MM-dd"), lekarz.Adres, lekarz.IdMiasta, lekarz.Telefon);
            var komenda = new MySqlCommand(zapytanie, DbHelper.Polaczenie);

            DbHelper.Polaczenie.Open();

            komenda.ExecuteNonQuery();

            DbHelper.Polaczenie.Close();
        }
        public static List<Grafik> PobierzGrafikDleLekarza(int idlekarza)
        {
            int id;
            DateTime dzienod;
            string opis;
            int idoddzialu;

            var polaczenie = DbHelper.StworzPolaczenie();

            var zapytanie = string.Format("SELECT * FROM grafik WHERE Id_lekarza='{0}'", idlekarza);
            var komenda = new MySqlCommand(zapytanie, polaczenie);

            polaczenie.Open();

            var reader = komenda.ExecuteReader();
            var lista = new List<Grafik>();
            while (reader.Read())
            {

                id = (int)reader["Id_grafiku"];
                dzienod = (DateTime)reader["Dzien_od"];
               // idpacjenta = null;
              
                opis = reader["Opis"].ToString();
                idoddzialu = (int)reader["Id_oddzialu"];
                var idpacjenta = reader["Id_pacjenta"];
                if (idpacjenta is int)
                {
                    var grafik = new Grafik(id, idlekarza, dzienod, (int)idpacjenta, opis, idoddzialu);
                    lista.Add(grafik);
                  
                }
                else
                {
                    var grafik = new Grafik(id, idlekarza, dzienod, null, opis, idoddzialu);
                    lista.Add(grafik);
                }
            }
            polaczenie.Close();
            return lista;
        
        }
    }
}
