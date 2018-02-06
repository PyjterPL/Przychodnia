using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Przychodnia.Obiekty_Bazy
{
    class Recepta
    {
        public int ID_recepty { get; private set; }
        public int ID_lekarza { get; set; }
        public int ID_pacjenta { get; set; }
        public int ID_grafiku { get; set; }
        public string Tresc { get; set; }
        public DateTime Data_waznosci { get; set; }

        private Recepta() {}
        public Recepta (int ID_recepty, int ID_lekarza, int ID_pacjenta,int ID_grafiku,string Tresc,DateTime Data_waznosci)
        {
            this.ID_grafiku = ID_grafiku;
            this.ID_lekarza = ID_lekarza;
            this.ID_pacjenta = ID_pacjenta;
            this.ID_recepty = ID_recepty;
            this.Tresc = Tresc;
            this.Data_waznosci = Data_waznosci;
        }
        public static List<Recepta> PobierzWszystkieRecepty()
        {
            // tNazwa zmiennej ---> temp + nazwa zmiennej 

            int tID_recepty;
            int tID_lekarza;
            int tID_pacjenta;
            int tID_grafiku;
            string tTresc;
            DateTime tData_waznosci;

            var recepty = new List<Recepta>();
            var zapytanie = "SELECT * FROM recepty";
            var komenda = new MySqlCommand(zapytanie, DbHelper.Polaczenie);

            DbHelper.Polaczenie.Open();

            var reader = komenda.ExecuteReader();

            while(reader.Read())
            {
                tID_recepty      = (int)reader["Id_recepty"];
                tID_lekarza      = (int)reader["Id_lekarza"];
                tID_pacjenta     = (int)reader["Id_pacjenta"];
                tID_grafiku      = (int)reader["Id_grafiku"];
                tTresc           = reader["Tresc"].ToString();
                tData_waznosci = (DateTime)reader["Data_waznosci"];

                var recepta = new Recepta(tID_recepty, tID_lekarza, tID_pacjenta, tID_grafiku, tTresc, tData_waznosci);
                recepty.Add(recepta);
            }
            DbHelper.Polaczenie.Close();
            return recepty;
        }
        public void UsunRecepte(int indeks)
        {
            var zapytanie = string.Format("DELETE FROM recepty WHERE Id_recepty={0}", indeks.ToString());
            var komenda = new MySqlCommand(zapytanie, DbHelper.Polaczenie);

            DbHelper.Polaczenie.Open();

            komenda.ExecuteNonQuery();

            DbHelper.Polaczenie.Close();
        }
        public static void DodajRecepte( int ID_lekarza, int ID_pacjenta, int ID_grafiku, string Tresc, DateTime Data_waznosci)
        {
            var zapytanie = string.Format("INSERT INTO recepty (Id_recepty,Id_lekarza,Id_pacjenta,Tresc,Data_waznosci,Id_grafiku) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')",
            null,ID_lekarza.ToString(),ID_pacjenta.ToString(),Tresc,Data_waznosci.ToString("yyy-MM-dd"),ID_grafiku.ToString());

            var komenda = new MySqlCommand(zapytanie, DbHelper.Polaczenie);

            DbHelper.Polaczenie.Open();

            komenda.ExecuteNonQuery();

            DbHelper.Polaczenie.Close();

        }

        public static void UsunReceptę(int index)
        {
            var zapytanie = string.Format("DELETE FROM recepty WHERE Id_recepty={0}", index.ToString());
            var komenda = new MySqlCommand(zapytanie, DbHelper.Polaczenie);

            DbHelper.Polaczenie.Open();

            komenda.ExecuteNonQuery();

            DbHelper.Polaczenie.Close();
        }

    }
}
