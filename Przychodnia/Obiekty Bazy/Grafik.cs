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
        public int IdOddzialu { get; set; }

        public Grafik(int id,int idlekarza,DateTime dzienod,int? idpacjenta,string opis,int idodzialu)
        {
            this.ID = id;
            this.IdLekarza = idlekarza;
            this.Dzien_od = dzienod;
            this.IdPacjenta = idpacjenta;
            this.Opis = opis;
            this.IdOddzialu = idodzialu;
        }
        public static List<Grafik> PobierzGrafikDleLekarza(int idlekarza)
        {
            int id;
            DateTime dzienod;
           // int? idpacjenta;
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
