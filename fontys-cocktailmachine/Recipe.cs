using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace fontys_cocktailmachine
{
    internal class Recipe
    {
        private string _name;
        private int _id;
        private Dictionary<Ingredient, int> _ingredients; 

        public Recipe(string name, int id)
        {
            _name = name;
            _id = id;
        }

        public string Name
        {
            get { return _name; }
        }

        public Dictionary<Ingredient, int> Ingredients
        {
            get { return ingredients; }
        }

        public int Id
        {
            get { return _id; }
        }

        public void PopulateIngredients(DataBase database)
        {
            DataRowCollection rows = database.GetRecipeIngredients(_id);

            foreach (DataRow dataRow in rows)
            {
                _ingredients[new Ingredient("test", 1)] = dataRow[1];
            }
        }
    }
}
