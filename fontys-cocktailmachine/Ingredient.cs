using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fontys_cocktailmachine
{
    class Ingredient
    {
        private string _name;
        private string _id;

        public Ingredient(string name, string id)
        {
            _name = name;
            _id = id;
        }

        public string Name
        {
            get { return _name; }
        }

        public string Id
        {
            get { return _id; }
        }
    }
}
