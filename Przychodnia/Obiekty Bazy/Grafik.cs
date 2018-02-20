using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Przychodnia.Obiekty_Bazy
{
    public class Grafik
    {
        public int ID { get; private set; }
        public int IdLekarza { get; set; }
        public DateTime Dzien_od { get; set; }
        public int? IdPacjenta { get; set; }//może być nullem  
        public string Opis { get; set; }
        public int? IdOddzialu { get; set; }
        public string NazwaPacjent { get; set; }

        public string NazwaSpecjalizacji { get; set; }
        public Grafik(int id, int idlekarza, DateTime dzienod, int? idpacjenta, string opis, int? idodzialu)
        {
            this.ID = id;
            this.IdLekarza = idlekarza;
            this.Dzien_od = dzienod;
            this.IdPacjenta = idpacjenta;
            this.Opis = opis;
            this.IdOddzialu = idodzialu;
            this.NazwaSpecjalizacji = "Brak specjalizacji";
            if (IdPacjenta > 0)
            {
                var pacjent = Pacjent.PobierzPacjenta((int)IdPacjenta);
                NazwaPacjent = pacjent.Imie + " " + pacjent.Nazwisko;
            }
            if (IdOddzialu > 0)
            {
                
                var oddzial = Oddzial.PobierzOddzial((int)idodzialu);
                if (oddzial == null)
                {
                    NazwaSpecjalizacji = "Brak specjalizacji";
                }
                else
                {
                    var specjalizacja = Specjalizacja.PobierzSpecjalizacje(oddzial.IdSpecjalizacji); // EXCEPTION 
                    NazwaSpecjalizacji = specjalizacja.nazwa;
                }
            }

            // this.NazwaPacjenta = Pacjent.PobierzPacjenta(IdPacjenta).Imie;
        }
        public static void DodajGrafik(Grafik grafik)
        { 
            DateTime dzis = new DateTime(), pobrane = new DateTime();
        
            dzis = DateTime.Now;
            pobrane = grafik.Dzien_od;
            DbHelper.Polaczenie.Close();
            if (pobrane > DateTime.Now) // Sprawdzenie czy pobrana data jest w "przyszłości" 
            {
             var   zapytanie = "INSERT INTO grafik VALUES(@null,@grafikIdLek,@grafikDzienOd,@grafikIDpac,@grafikOpis,@grafikIdOddzialu)"; //null, grafik.IdLekarza, grafik.Dzien_od.ToString("yyyy-MM-dd HH:mm:ss"), grafik.IdPacjenta, grafik.Opis, grafik.IdOddzialu); // lekarz.DataUrodzenia.Date.ToString("yyyy-MM-dd"), lekarz.Adres, lekarz.IdMiasta, lekarz.Telefon);
             var  komenda = new MySqlCommand(zapytanie, DbHelper.Polaczenie);

                komenda.Parameters.AddWithValue("@null", null);
                komenda.Parameters.AddWithValue("@grafikIdLek", grafik.IdLekarza);
                komenda.Parameters.AddWithValue("@grafikDzienOd", grafik.Dzien_od.ToString("yyy-MM-dd HH:mm:ss"));
                komenda.Parameters.AddWithValue("@grafikIDpac", grafik.IdPacjenta);
                komenda.Parameters.AddWithValue("@grafikOpis", grafik.Opis);
                komenda.Parameters.AddWithValue("@grafikIdOddzialu", grafik.IdOddzialu);
                DbHelper.Polaczenie.Open();

                komenda.ExecuteNonQuery();
                DbHelper.Polaczenie.Close();
            }
           
            else throw new Exception("NIe można umawiać wizyt w przeszłości ");


       
          



        }
        public static void UmowWizyte(int idpacjenta, int idgrafiku)
        {


            var zapytanie = "UPDATE grafik SET Id_pacjenta=@idPacjenta WHERE Id_grafiku=@idGrafiku";
            var komenda = new MySqlCommand(zapytanie, DbHelper.Polaczenie);

            komenda.Parameters.AddWithValue("@idPacjenta", idpacjenta);
            komenda.Parameters.AddWithValue("@idGrafiku", idgrafiku);

            DbHelper.Polaczenie.Open();

            komenda.ExecuteNonQuery();

            DbHelper.Polaczenie.Close();
        }
        public static void OdwolajWizyte(int idgrafiku)
        {
            DateTime dzis= new DateTime(), pobrane = new DateTime();
            var zapytanie = "SELECT Dzien_od FROM grafik WHERE id_grafiku= @idGrafiku ";
            var komenda = new MySqlCommand(zapytanie, DbHelper.Polaczenie);
            komenda.Parameters.AddWithValue("@idGrafiku", idgrafiku);

            DbHelper.Polaczenie.Open();
            var reader = komenda.ExecuteReader();

            while(reader.Read())
            {
                pobrane = (DateTime)reader["Dzien_od"];
            }
            dzis = DateTime.Now;
            DbHelper.Polaczenie.Close();
            if (pobrane > DateTime.Now) // Sprawdzenie czy pobrana data jest w "przyszłości" 
            {
                zapytanie = "UPDATE grafik SET Id_pacjenta=@null WHERE Id_grafiku=@idGrafiku";
                komenda = new MySqlCommand(zapytanie, DbHelper.Polaczenie);

                komenda.Parameters.AddWithValue("@null", null);
                komenda.Parameters.AddWithValue("@idGrafiku", idgrafiku);
                DbHelper.Polaczenie.Open();

                komenda.ExecuteNonQuery();

                DbHelper.Polaczenie.Close();
            }
            else throw new Exception("NIe można odwoływać przeszłych wizyt");
        }

        //public static void OdwolajWizyte(int idgrafiku)
        //{
        //    var zapytanie = string.Format("UPDATE grafik SET Id_pacjenta='{0}' WHERE Id_grafiku='{1}'", null, idgrafiku);
        //    var komenda = new MySqlCommand(zapytanie, DbHelper.Polaczenie);

        //    DbHelper.Polaczenie.Open();

        //    komenda.ExecuteNonQuery();

        //    DbHelper.Polaczenie.Close();
        //}


        public static void UsunGrafik(int id)
        {

            var zapytanie = "DELETE FROM grafik WHERE Id_grafiku=@id"; // lekarz.DataUrodzenia.Date.ToString("yyyy-MM-dd"), lekarz.Adres, lekarz.IdMiasta, lekarz.Telefon);
            var komenda = new MySqlCommand(zapytanie, DbHelper.Polaczenie);

            komenda.Parameters.AddWithValue("@id", id);

            DbHelper.Polaczenie.Open();

            komenda.ExecuteNonQuery();

            DbHelper.Polaczenie.Close();

        }
        public static Grafik PobierzGrafik(int ID)
        {
            int id;
            DateTime dzienod;
            string opis;
            int idoddzialu;
            var polaczenie = DbHelper.StworzPolaczenie();

            var zapytanie = string.Format("SELECT * FROM grafik WHERE Id_grafiku='{0}'", ID);
            var komenda = new MySqlCommand(zapytanie, polaczenie);
            polaczenie.Open();
            var reader = komenda.ExecuteReader();
            if (reader.Read())
            {
                id = (int)reader["Id_grafiku"];
                dzienod = (DateTime)reader["Dzien_od"];

                opis = reader["Opis"].ToString();


                //   idoddzialu = (int)reader["Id_oddzialu"];
                if (reader.IsDBNull(5))
                {
                    idoddzialu = 0;
                }
                else idoddzialu = (int)reader["Id_oddzialu"];

                var idpacjenta = (int)reader["Id_pacjenta"];
                var id_lekarza = (int)reader["Id_lekarza"];
                var grafik = new Grafik(id, id_lekarza, dzienod, idpacjenta, opis, idoddzialu);
                polaczenie.Close();
                return grafik;
            }
            polaczenie.Close();
            return null;
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

             //   idoddzialu = (int)reader["Id_oddzialu"];
                if(reader.IsDBNull(5))
                {
                    idoddzialu = 0;
                }
               else   idoddzialu = (int)reader["Id_oddzialu"];
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
        public static void ZaaktualizujOpisWizyty(int id_grafiku,int id_lekarza,string opis)
        {
            var zapytanie = "UPDATE grafik SET Opis=@Opis WHERE Id_grafiku=@idGrafiku AND Id_lekarza=@idLekarza ";
            var komenda = new MySqlCommand(zapytanie, DbHelper.Polaczenie);

            komenda.Parameters.AddWithValue("@Opis", opis);
            komenda.Parameters.AddWithValue("@idGrafiku", id_grafiku);
            komenda.Parameters.AddWithValue("@idLekarza", id_lekarza);

            DbHelper.Polaczenie.Open();
            komenda.ExecuteNonQuery();
            DbHelper.Polaczenie.Close();
        }
    

    }
}