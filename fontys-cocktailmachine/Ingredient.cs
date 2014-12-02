using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fontys_cocktailmachine
{
    public class Ingredient
    {
        private string _name;
        private int _id;

        public Ingredient(string name, int id)
        {
            _name = name;
            _id = id;
        }

        public string Name
        {
            get { return _name; }
        }

        public int Id
        {
            get { return _id; }
        }
    }
}
