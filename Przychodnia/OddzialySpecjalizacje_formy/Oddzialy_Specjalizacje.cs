using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Przychodnia.Obiekty_Bazy;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace Przychodnia.OddzialySpecjalizacje_formy
{  ///<summary> 
   /// Klasa opakowująca. Zawiera Lekarza wraz z metodami zwracajacymi specjalizacje lekarza, w formie ID lub całego stringa
   /// </summary
    class Oddzialy_Specjalizacje
    {

        ///<summary> 
        /// Dostęp do konkretnego lekarza 
        /// </summary>
        public Lekarz lekarz { get; set; }
        ///<summary> 
        ///Lista w ktorym zawarte są ID specjalizacji lekarza, jeśli lekarz nie ma przypisanej specjalizacji zwraca zero
        /// </summary>
        public List<int> SpecIDs { get; set; }
        ///<summary> 
        /// Zwraca sformatowany string zwierajacy nazwy specjalizacji lekarza
        /// </summary>
        public string NazwaSpec { get; set; }
        private Oddzialy_Specjalizacje() { }

        public Oddzialy_Specjalizacje(int id_lekarza)// ID LEKARZA 
        {
         
            bool czyWieleSpec = false;
            string nazwaspec = "";

            var zapytanie = "SELECT specjalizacja.Nazwa" +
                  " FROM lekarze LEFT JOIN oddzialy ON lekarze.Id_lekarza=oddzialy.Id_lekarza " +
                  "LEFT JOIN specjalizacja ON oddzialy.Id_specjalizacji = specjalizacja.Id_specjalizacji " +
                  "WHERE lekarze.Id_lekarza =@IDlekarza ";

            var komenda = new MySqlCommand(zapytanie, DbHelper.Polaczenie);

            komenda.Parameters.AddWithValue("@IDlekarza", id_lekarza);

            lekarz = Lekarz.PobierzLekarza(id_lekarza);

            DbHelper.Polaczenie.Open();
            var reader = komenda.ExecuteReader();

            while (reader.Read())
            {
                if (reader.IsDBNull(0)) // może być konieczne zmiana na 1 
                {
                    nazwaspec = "brak okreslonej specjalizacji";
                }
                else
                {
                    if (czyWieleSpec == true) nazwaspec += ", " + (string)reader["Nazwa"];
                    else nazwaspec += (string)reader["Nazwa"];
                }
                czyWieleSpec = true;

            }
            NazwaSpec = nazwaspec;
            DbHelper.Polaczenie.Close();
            PobierzIDSpec(id_lekarza);
        }
        private void PobierzIDSpec(int id_lek) // pobiera WSZYSTKIE ID_specjalizacji lekarza i odkłada je na listę 
        {
            SpecIDs = new List<int>();
            var zapytanie = string.Format("SELECT * FROM  oddzialy WHERE Id_lekarza={0}", id_lek);
            var komenda = new MySqlCommand(zapytanie, DbHelper.Polaczenie);
            DbHelper.Polaczenie.Open();
            var reader = komenda.ExecuteReader();
         
            while(reader.Read())
            {
                if (reader.IsDBNull(2) == false)
                {
                    SpecIDs.Add((int)reader["Id_specjalizacji"]);
                }
                else SpecIDs.Add(0);
               
                   
                
                
            }
            DbHelper.Polaczenie.Close();
        }
        public static string PobierzWszystkieSpecjalizacjeLekarza(int id_lekarza)
        {

            bool czyWieleSpec = false;
            string nazwaspec = "";

            var zapytanie = "SELECT specjalizacja.Nazwa" +
                " FROM lekarze LEFT JOIN oddzialy ON lekarze.Id_lekarza=oddzialy.Id_lekarza " +
                "LEFT JOIN specjalizacja ON oddzialy.Id_specjalizacji = specjalizacja.Id_specjalizacji " +
                "WHERE lekarze.Id_lekarza =@IDlekarza ";

            var komenda = new MySqlCommand(zapytanie, DbHelper.Polaczenie);

            komenda.Parameters.AddWithValue("@IDlekarza", id_lekarza);
            Lekarz lekarz = Lekarz.PobierzLekarza(id_lekarza);

            DbHelper.Polaczenie.Open();
            var reader = komenda.ExecuteReader();

            while (reader.Read())
            {
                if (reader.IsDBNull(0)) // może być konieczne zmiana na 1 
                {
                    nazwaspec = "brak okreslonej specjalizacji";
                }
                else
                {
                    if (czyWieleSpec == true) nazwaspec += ", " + (string)reader["Nazwa"];
                    else nazwaspec += (string)reader["Nazwa"];
                }
                czyWieleSpec = true;

            }

            DbHelper.Polaczenie.Close();
            return nazwaspec;

        }
        public Oddzialy_Specjalizacje(Lekarz lek)
        {
            string nazwaspec = "";
            bool czyWieleSpec = false;
            var zapytanie = string.Format("SELECT specjalizacja.Nazwa" +
                " FROM lekarze LEFT JOIN oddzialy ON lekarze.Id_lekarza=oddzialy.Id_lekarza " +
                "LEFT JOIN specjalizacja ON oddzialy.Id_specjalizacji = specjalizacja.Id_specjalizacji " +
                "WHERE lekarze.Id_lekarza ='{0}'", lek.ID);

            var komenda = new MySqlCommand(zapytanie, DbHelper.Polaczenie);

            lekarz = lek;

            DbHelper.Polaczenie.Open();
            var reader = komenda.ExecuteReader();

            while (reader.Read())
            {
                if (reader.IsDBNull(0))
                {
                    nazwaspec = "brak okreslonej specjalizacji";
                }
                else
                {
                    if (czyWieleSpec == true) nazwaspec += ", " + (string)reader["Nazwa"];
                    else nazwaspec += (string)reader["Nazwa"];
                }
                czyWieleSpec = true;

            }
            NazwaSpec = nazwaspec;
            DbHelper.Polaczenie.Close();
            PobierzIDSpec(lek.ID);
        }

        public static List<Oddzialy_Specjalizacje> PobierzSpecjalizacjeWszystkichLekarzy()
        {
            Oddzialy_Specjalizacje tmp;
            List<Oddzialy_Specjalizacje> lista = new List<Oddzialy_Specjalizacje>();
            List<Lekarz> listaLekarzy = Lekarz.PobierzWszystkichLekarzy();

            foreach (Lekarz lek in listaLekarzy)
            {
                tmp = new Oddzialy_Specjalizacje(lek);
                lista.Add(tmp);
            }

            return lista;
        }

        public static void PrzypiszSpecDoLekarza(int IDLekarza, int IDSpec) 
        {
            //     var zapytanie = string.Format("INSERT INTO oddzialy VALUES('{0}','{1}','{2}' )", null, IDSpec, IDLekarza);
            var zapytanie = "INSERT INTO oddzialy VALUES(@null,@spec,@idlek)";
            var komenda = new MySqlCommand(zapytanie, DbHelper.Polaczenie);
            komenda.Parameters.AddWithValue("@null", null);
            komenda.Parameters.AddWithValue("@spec", IDSpec);
            komenda.Parameters.AddWithValue("@idlek", IDLekarza);
            DbHelper.Polaczenie.Open();
            komenda.ExecuteNonQuery();
            DbHelper.Polaczenie.Close();
        }

        public static void UsunSpecLekarza(int IDLekarza, int IDSpec)
        {
            {
                var zapytanie = "DELETE FROM oddzialy WHERE Id_lekarza =@idlekarza AND Id_specjalizacji=@idspecjalizacji";
                var komenda = new MySqlCommand(zapytanie, DbHelper.Polaczenie);
                komenda.Parameters.AddWithValue("@idlekarza", IDLekarza);
                komenda.Parameters.AddWithValue("@idspecjalizacji", IDSpec);
                DbHelper.Polaczenie.Open();
                komenda.ExecuteNonQuery();
                DbHelper.Polaczenie.Close();
            }
        }
        public static void UsunWszystkieSpecLekarza(int IDLekarza)
        {
            //  var zapytanie = string.Format("DELETE FROM oddzialy WHERE Id_lekarza ='{0}' ", IDLekarza);

           var zapytanie = "DELETE FROM oddzialy WHERE Id_lekarza =@IDLekarza"; // to jest ta parametryzacja,której w teorii należy używać
           var komenda = new MySqlCommand(zapytanie, DbHelper.Polaczenie);
            komenda.Parameters.AddWithValue("@IDLekarza", IDLekarza);  
            try
            {
                DbHelper.Polaczenie.Open();
                komenda.ExecuteNonQuery();
                DbHelper.Polaczenie.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Uwaga, lekarz lub lekarze,których specjalizacje starasz się usunąć, nadal mają umówione wizyty.Najpierw usun wszystkie wizyty,następnie ponów próbę", "Błąd");
            }
        }

        public static void UsunWszystkieSpecWszystkich()
        {
            var zapytanie = string.Format("DELETE FROM oddzialy");
            var komenda = new MySqlCommand(zapytanie, DbHelper.Polaczenie);
            try
            {
                DbHelper.Polaczenie.Open();
                komenda.ExecuteNonQuery();
                DbHelper.Polaczenie.Close();
            }
            catch(MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Uwaga, lekarz lub lekarze,których specjalizacje starasz się usunąć, nadal mają umówione wizyty.Najpierw usun wszystkie wizyty,następnie ponów próbę", "Błąd");
            }
        }
    }


}
