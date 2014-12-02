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

            GetRecipeIngredients(1);
        }

        public DataSet QueryDatabase(string query)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, _connection);
            DataSet ds = new DataSet();

            adapter.Fill(ds);

            return ds;
        }

        public DataRowCollection GetAllIngredients()
        {
            DataSet ds = QueryDatabase("SELECT * FROM ingredients");

            return ds.Tables[0].Rows;
        }

        public DataRowCollection GetAllRecipeNames()
        {
            DataSet ds = QueryDatabase("SELECT * FROM item");

            return ds.Tables[0].Rows;
        }

        public DataRowCollection GetRecipeIngredients(int recipeID)
        {
            string query = String.Format("SELECT * FROM recipe where item = {0}", recipeID);
            DataSet ds = QueryDatabase(query);

            return ds.Tables[0].Rows;
        }
    }
}
