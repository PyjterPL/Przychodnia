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
        public int Id_lekarza { get; set; }
        public string Specjalalizacja { get; set; }
        public DateTime Dzien_od { get; set; }
        public Odwolane(int? id_odw,int id_pac,int id_lek,string spec,DateTime dzie_od)
        {
            this.Id_odwolania = id_odw;
            this.Id_pacjenta = id_pac;
            this.Id_lekarza = id_lek;
            this.Specjalalizacja = spec;
            this.Dzien_od = dzie_od;
        }

        public static void DodajOdwolanie(Grafik grafik,string specjalizacja)
        {
            var lekarz = Lekarz.PobierzLekarza(grafik.IdLekarza);
            var zapytanie = string.Format("INSERT INTO odwolane VALUES('{0}','{1}','{2}','{3}','{4}')", null, grafik.IdPacjenta, lekarz.Imie+" "+lekarz.Nazwisko, specjalizacja, grafik.Dzien_od.ToString("yyyy-MM-dd HH:mm:ss")); 
            var komenda = new MySqlCommand(zapytanie, DbHelper.Polaczenie);

            DbHelper.Polaczenie.Open();

            komenda.ExecuteNonQuery();

            DbHelper.Polaczenie.Close();
        }
        public static List<Odwolane> PobierzWszystkieOdwolaneWiztyty()
        {
            List<Odwolane> lista = new List<Odwolane>();

        //    var zapytanie = string.Format("")

            return lista;

        }
    }
}
