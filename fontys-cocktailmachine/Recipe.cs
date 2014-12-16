using System.Collections.Generic;

namespace fontys_cocktailmachine
{
    public class Recipe
    {
        private readonly int _id;
        private readonly Dictionary<Ingredient, int> _ingredients;
        private readonly string _name;

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