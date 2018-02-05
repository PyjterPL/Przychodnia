using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
namespace Przychodnia.Obiekty_Bazy
{
    class Miasto
    {
        public int ID { get; private set; }
        public string Nazwa { get; private set; }

        public Miasto(int id, string nazwa)
        {
            this.ID = id;
            this.Nazwa = nazwa;
        }
        public static List<Miasto> PobierzWszystkieMiasta()
        {
            int id;
            string nazwa;          
            var miasta = new List<Miasto>();

            var zapytanie = "SELECT * FROM miasta";
            var komenda = new MySqlCommand(zapytanie, DbHelper.Polaczenie);

            DbHelper.Polaczenie.Open();

            var reader = komenda.ExecuteReader();

            while (reader.Read())
            {
                id = (int)reader["Id_miasta"];
                nazwa = reader["Nazwa"].ToString();

                var miasto = new Miasto(id, nazwa);

                miasta.Add(miasto);
            }
            DbHelper.Polaczenie.Close();
            return miasta;

        }
    }
}
