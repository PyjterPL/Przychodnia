using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przychodnia.Obiekty_Bazy
{
    public class Odwolane
    {
        public int? Id_odwolania { get; set; }
        public int Id_pacjenta { get; set; }
     // public int Id_lekarza { get; set; } nie ma zastosowania. ID i tak jest pobierane z grafiku a pola Id_lekarza nie ma w tabeli odwolane
        public string ImieNazwisko { get; set; }
        public string Specjalalizacja { get; set; }
        public DateTime Dzien_od { get; set; }
  
        /*   public Odwolane(int? id_odw,int id_pac,int id_lek,string spec,DateTime dzie_od)
        {
            this.Id_odwolania = id_odw;
            this.Id_pacjenta = id_pac;
            this.Id_lekarza = id_lek;
            this.Specjalalizacja = spec;
            this.Dzien_od = dzie_od;
        }
        */

        public Odwolane(int? id_odw, int id_pac,string imieInazwisko, string spec, DateTime dzie_od)
        {
            this.Id_odwolania = id_odw;
            this.Id_pacjenta = id_pac;
            this.ImieNazwisko = imieInazwisko;
            this.Specjalalizacja = spec;
            this.Dzien_od = dzie_od;
        }
        public static void DodajOdwolanie(Grafik grafik,string specjalizacja)
        {
            var lekarz = Lekarz.PobierzLekarza(grafik.IdLekarza);
            //  var zapytanie = string.Format("INSERT INTO odwolane VALUES('{0}','{1}','{2}','{3}','{4}')", null, grafik.IdPacjenta, lekarz.Imie+" "+lekarz.Nazwisko, specjalizacja, grafik.Dzien_od.ToString("yyyy-MM-dd HH:mm:ss")); 
            string imieInazwisko = lekarz.Imie + " " + lekarz.Nazwisko;
            var zapytanie = " INSERT INTO odwolane VALUES(@null,@grafikIDpac,@imieInazwisko,@specjalizacja,@grafikDzien)";
            var komenda = new MySqlCommand(zapytanie, DbHelper.Polaczenie);

            // Nie jestem do konca pewny czy to jest w tym miejscu potrzebne, ale Strzyżonego... 
            komenda.Parameters.AddWithValue("@null", "NULL");
            komenda.Parameters.AddWithValue("@grafikIDpac", grafik.IdPacjenta);
            komenda.Parameters.AddWithValue("@imieInazwisko", imieInazwisko);
            komenda.Parameters.AddWithValue("@specjalizacja", specjalizacja);
            komenda.Parameters.AddWithValue("@grafikDzien", grafik.Dzien_od.ToString("yyyy-MM-dd HH:mm:ss"));

            DbHelper.Polaczenie.Open();

            komenda.ExecuteNonQuery();

            DbHelper.Polaczenie.Close();
        }
        public static List<Odwolane> PobierzWszystkieOdwolaneWiztyty()
        {
            List<Odwolane> lista = new List<Odwolane>();
            int? idOdwolania;
            int idPacjenta;
            string specjalizacja,imieNazwisko;
            DateTime dzienOD;

            var zapytanie = " SELECT * FROM odwolane";
            var komenda =new MySqlCommand(zapytanie, DbHelper.Polaczenie);

            DbHelper.Polaczenie.Open();
            var reader = komenda.ExecuteReader();

            while(reader.Read())
            {
                if (reader.IsDBNull(1) == true)
                {
                    idOdwolania = null;
                }
                else idOdwolania = (int?)reader["Id_odwolania"];

                idPacjenta = (int)reader["Id_pacjenta"];
                imieNazwisko = (string)reader["Lekarz"];
                specjalizacja = (string)reader["Specjalizacja"];
                dzienOD = (DateTime)reader["Dzien_od"];

                lista.Add(new Odwolane(idOdwolania, idPacjenta, imieNazwisko, specjalizacja, dzienOD));

            }
            DbHelper.Polaczenie.Close();
            return lista;

        }
    }
}
