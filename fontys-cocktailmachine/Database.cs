using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace fontys_cocktailmachine
{
    public class DataBase
    {
        private const string connString = "SERVER=terarion.com;PORT=3306;DATABASE=fontys;UID=fontys;PASSWORD=proftaak;";
        private readonly MySqlConnection _connection;

        public DataBase()
        {
            _connection = new MySqlConnection(connString);

            _connection.Open();
        }

        /// <summary>
        ///     Queries a database for specific queries
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        private DataSet QueryDatabase(string query)
        {
            var adapter = new MySqlDataAdapter(query, _connection);
            var ds = new DataSet();

            adapter.Fill(ds);

            return ds;
        }

        /// <summary>
        ///     Returns a dataset that contains all ingredients
        /// </summary>
        /// <returns></returns>
        private DataRowCollection GetAllIngredients()
        {
            DataSet ds = QueryDatabase("SELECT * FROM ingredients");

            return ds.Tables[0].Rows;
        }

        private DataRowCollection GetAllRecipeNames()
        {
            DataSet ds = QueryDatabase("SELECT * FROM item");

            return ds.Tables[0].Rows;
        }

        private DataRowCollection GetRecipeIngredients(int recipeID)
        {
            string query = String.Format("SELECT * FROM recipe where item = {0}", recipeID);
            DataSet ds = QueryDatabase(query);

            return ds.Tables[0].Rows;
        }

        /// <summary>
        ///     Pulls all ingredients from the Database and dumps them into a list of ingredients
        /// </summary>
        /// <returns>List of ingredient objects</returns>
        public List<Ingredient> CreateIngredientList()
        {
            var _ingredients = new List<Ingredient>();

            DataRowCollection rows = GetAllIngredients();

            foreach (DataRow dataRow in rows)
            {
                var ing = new Ingredient((string) dataRow[1], (int) dataRow[0]);
                _ingredients.Add(ing);
            }

            return _ingredients;
        }

        public List<Recipe> CreateRecipeList(List<Ingredient> ingredients)
        {
            var _recipes = new List<Recipe>();

            DataRowCollection rows = GetAllRecipeNames();

            foreach (DataRow dataRow in rows)
            {
                var rec = new Recipe((string) dataRow[1], (int) dataRow[0]);

                foreach (DataRow recipeIngredient in GetRecipeIngredients(rec.Id))
                {
                    Ingredient ingredient = ingredients[(int) recipeIngredient[3] - 1];
                    rec.AddIngredient(ingredient, (int) recipeIngredient[1]);
                }

                _recipes.Add(rec);
            }

            return _recipes;
        }
    }
}