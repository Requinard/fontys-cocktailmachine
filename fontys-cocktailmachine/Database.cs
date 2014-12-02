using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace fontys_cocktailmachine
{
    public class DataBase
    {
        private MySqlConnection _connection;
        const string connString = "SERVER=terarion.com;PORT=3306;DATABASE=fontys;UID=fontys;PASSWORD=proftaak;";

        public DataBase()
        {
            _connection = new MySqlConnection(connString);

            _connection.Open();
        }

        public DataSet QueryDatabase(string query)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, _connection);
            DataSet ds = new DataSet();

            adapter.Fill(ds);

            return ds;
        }
    }
}
