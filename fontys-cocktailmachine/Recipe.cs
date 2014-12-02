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
    public class Recipe
    {
        private string _name;
        private int _id;
        private Dictionary<Ingredient, int> _ingredients; 

        public Recipe(string name, int id)
        {
            _name = name;
            _id = id;

            _ingredients = new Dictionary<Ingredient, int>();
        }

        public string Name
        {
            get { return _name; }
        }

        public Dictionary<Ingredient, int> Ingredients
        {
            get { return _ingredients; }
        }

        public int Id
        {
            get { return _id; }
        }

        public void AddIngredient(Ingredient ingredient, int amount)
        {
            _ingredients[ingredient] = amount;
        }
    }
}
