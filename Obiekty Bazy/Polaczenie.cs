using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Przychodnia.Obiekty_Bazy
{
    static class DbHelper
    {
        private static string _server = "localhost";
        private static string _baza = "przychodnia";
        private static string _user = "root";
        private static string _haslo = "";

      //  public static MySqlConnection Polaczenie;
        private static MySqlConnection _polaczenie;
        public static MySqlConnection Polaczenie {
            get
            {
                if (_polaczenie == null)
                {
                    _polaczenie = StworzPolaczenie();
                }
                return _polaczenie;
            }
             set { }
        }


        public static MySqlConnection StworzPolaczenie()
        {
            var _builder = new MySqlConnectionStringBuilder();
            _builder.Server = _server;
            _builder.Database = _baza;
            _builder.UserID = _user;
            _builder.Password = _haslo;

            var _connString = _builder.ToString();
            return new MySqlConnection(_connString);
        }
    }
}
